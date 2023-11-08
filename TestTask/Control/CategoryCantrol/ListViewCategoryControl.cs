using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Page.Categories;
using TestTask.Core.Models.Products;
using TestTask.Extension;
using TestTask.Forms.Categories;

namespace TestTask.Control.CategoryCantrol
{
    public partial class ListViewCategoryControl : BaseUserControl
    {
        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        //Index column from ListView
        private const int IndexId = 0;
        private const int IndexColumnCompanyName = 1;

        private IServiceProvider _serviceProvider;
        private CategoryService _categoryService;
        private ProductService _productService;
        private IMessageBox _messageBox;

        private PagedList<Category> _pagedList;

        private bool Resizing = false;

        public ListViewCategoryControl()
            : base()
        {
            InitializeComponent();
        }

        public SearchRequestCategory SearchRequest = new SearchRequestCategory();

        public PageModel Page { get; set; } = new PageModel();

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            cmbPageSize.DataSource = Page.Items;
            LoadData();
            Page.ChangeCurrentPage += LoadData;
        }

        public void Closing() => Page.ChangeCurrentPage -= LoadData;

        protected void BtnAddItem_Click(object sender, EventArgs e)
        {
            using (var addFormMode = _serviceProvider.GetRequiredService<AddCategoryForm>())
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormMode.GetCategoryModel().ToCategory();
                _categoryService.Add(item);
                LoadData();
            }
        }

        protected void BtnEditItem_Click(object sender, EventArgs e)
        {
            var indexEditItem = listView.SelectedIndices.Cast<int>();

            if (indexEditItem.Count() != 1)
            {
                _messageBox.ShowWarning("Select one item.");
                return;
            }

            var row = indexEditItem.First();
            var oldItem = GetCategory(row);

            using (var editCompanyForm = _serviceProvider.GetRequiredService<EditCategoryForm>())
            {
                editCompanyForm.Initialize(oldItem);

                if (editCompanyForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var updateItem = editCompanyForm.EditItem();
                _categoryService.Update(updateItem);
                Update(updateItem, row);
            }
        }

        protected void BtnDeleteItems_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = listView.SelectedIndices;

            if (selectedRowIndex.Count == NoItemsSelected)
            {
                _messageBox.ShowWarning(MessageNotSelectedItem);
                return;
            }

            if (!_messageBox.ShowQuestion("Delete selected items?"))
            {
                foreach (ListViewItem item in listView.Items)
                {
                    item.Selected = false;
                }
                return;
            }

            RemoveItemRowListViewCategory();
            LoadData();
        }

        protected void BtnFirstPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasPrevious)
            {
                Page.Number = 1;
            }
        }

        protected void BtnBackPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasPrevious)
            {
                Page.Number--;
            }
        }

        protected void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasNext)
            {
                Page.Number++;
            }
        }

        protected void BtnLastPage_Click(object sender, EventArgs e)
        {
            if (_pagedList.HasNext)
            {
                Page.Number = _pagedList.PageCount;
            }
        }

        protected void TbCurrentPage_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbCurrentPage.Text, out var pageNumber)
                && pageNumber <= _pagedList.PageCount
                && _pagedList.PageNumber == Page.Number)
            {
                Page.Number = pageNumber;
            }

            tbCurrentPage.Text = string.Format("{0}/{1}", Page.Number, _pagedList.PageCount);
        }

        protected void CmbPageSize_Changed(object sender, EventArgs e)
        {
            var pageSizeCmb = Page.Items[cmbPageSize.SelectedIndex];

            if (Page.ChangedPage(pageSizeCmb))
            {
                Page.Size = pageSizeCmb;
                Page.Number = 1;
            }
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
        {
            if (!Resizing)
            {
                Resizing = true;

                float totalColumnWidth = 0;

                for (int i = 0; i < listView.Columns.Count; i++)
                    totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                //Column Tage = Width custom size
                for (int i = 0; i < listView.Columns.Count; i++)
                {
                    float colPercenTage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                    listView.Columns[i].Width = (int)(colPercenTage * listView.ClientRectangle.Width);
                }
            }
            Resizing = false;
        }

        public void LoadData()
        {
            var query = SearchRequest.ApplyFilter(_categoryService.GetQueryableAll());
            query = SearchRequest.ApplyOrderBy(query);
            _pagedList = query.GetPagedList(Page.GetPage());

            if (IsNotFirstPageCategoryEmpty())
            {
                Page.Number -= 1;
            }

            var item = _pagedList.Items;

            listView.Items.Clear();
            FillListView(item);
            CustomUpdateFormStatePagination();

            tbCurrentPage.Text = _pagedList.PageNumber.ToString();
        }

        public void Update(Category editItem, int row)
        {
            listView.Items[row].SubItems[IndexId].Text = editItem.Id.ToString();
            listView.Items[row].SubItems[IndexColumnCompanyName].Text = editItem.Name.ToString();
        }

        private Category GetCategory(int indexRow)
        {
            var rowItem = listView.Items[indexRow];

            var id = CellElement(rowItem, IndexId).ParseInt();
            var name = CellElement(rowItem, IndexColumnCompanyName) ?? throw new ArgumentException("Name cannot be null.");

            return new Category(name, id);
        }

        private string CellElement(ListViewItem rowItem, int indexColumn) => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        private void FillListView(List<Category> items)
        {
            foreach (var item in items)
            {
                var itemsRow = new string[] { item.Id.ToString(), item.Name };
                listView.Items.Add(new ListViewItem(itemsRow));
            }
        }

        private void RemoveItemRowListViewCategory()
        {
            for (var i = 0; i < listView.Items.Count; i++)
            {
                var item = listView.Items[i];
                if (item.Selected)
                {
                    var id = CellElement(item, IndexId).ParseInt();
                    _productService.RemoveProductRelatedToCategory(id);
                    _categoryService.Remove(id);
                }
            }
        }

        private void CustomUpdateFormStatePagination()
        {
            btnFirstPage.Enabled = btnFirstPage.Visible =
                btnLastPage.Enabled = btnLastPage.Visible =
                    btnNextPage.Enabled = btnNextPage.Visible =
                        btnBackPage.Enabled = btnBackPage.Visible =
                            tbCurrentPage.Enabled = tbCurrentPage.Visible =
                                    _pagedList.PageCount > 0 ? true : false;
        }

        private bool IsNotFirstPageCategoryEmpty() => _pagedList.Count == 0 && Page.Number != 1;
    }
}

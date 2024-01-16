using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem.Pages;
using TestTask.BindingItem.Pages.Sort;
using TestTask.Controls.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Types;
using TestTask.Extension;
using TestTask.Forms.Type;

namespace TestTask.Controls.PageTabControls
{
    public partial class TypeProductListView : UserControl, IListViewDataProvider, IInitialize, ILoad
    {
        private const int IndexId = 0;
        private const int IndexColumnTypeName = 1;
        private const int IndexColumnNameCategory = 2;
        private const int IndexColumnIdCategory = 3;

        private IServiceProvider _serviceProvider;
        private CategoryRepository _categoryService;
        private ProductTypeRepository _typeService;
        private IMessageBox _messageBox;
        private SortTypeProductModel _selectSortField = new SortTypeProductModel();
        private bool _isAscending = true;

        public TypeProductListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("ID", 100, e => ((ProductType)e).Id),
            new ListViewColumn("Name", 350, e => ((ProductType)e).Name),
            new ListViewColumn("Category", 300, e => ((ProductType)e).Category),
            new ListViewColumn("CategoryId", 1, e => ((ProductType)e).CategoryId),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoryService = _serviceProvider.GetRequiredService<CategoryRepository>();
            _typeService = _serviceProvider.GetRequiredService<ProductTypeRepository>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
            checkCmbField.Items.AddRange(_selectSortField.SelectField);
        }

        public void LoadData() => listView.LoadData();

        public bool Add()
        {
            var listCategory = _categoryService.GetQueryableAll();

            if (listCategory.Count() == 0)
            {
                _messageBox.ShowWarning("Add a category to the table to add a product.");
                return false;
            }

            using (var addForm = _serviceProvider.GetRequiredService<AddProductTypeForm>())
            {
                addForm.Initialize(listCategory.ToList());

                if (addForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var item = addForm.GetTypeProductModel().ToProductType();
                _typeService.Add(item);
            }

            return true;
        }

        public bool Edit(Entity entity)
        {
            var listCategory = _categoryService.GetAll();
            var oldItem = (ProductType)entity;

            using (var editForm = _serviceProvider.GetRequiredService<EditProductTypeForm>())
            {
                editForm.Initialize(listCategory, oldItem);

                if (editForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editForm.GetEditTypeProduct();
                _typeService.Updata(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var id = item.GetNonNullableString(IndexId).ParseInt();
            var name = item.GetNonNullableString(IndexColumnTypeName);
            var categoryId = item.GetNonNullableString(IndexColumnIdCategory).ParseInt();

            return new ProductType(name, categoryId, id);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _typeService.GetQueryableAll();
            queriable = GetSearchType(queriable);
            queriable = _selectSortField.Apply(queriable, _isAscending);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity) => _typeService.Remove(entity.Id);

        private void ButtonUseFilter_Click(object sender, EventArgs e)
        {
            SelectSortField();
            LoadData();
        }

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            tbSearchStrName.Text = string.Empty;
            _selectSortField.SortFields = new HashSet<ProductTypeSortType>();
            checkCmbField.ClearSelection();
            _isAscending = true;
            btnTypeSort.Text = TypeSortFields.Ascending.Name;
            LoadData();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private IQueryable<ProductType> GetSearchType(IQueryable<ProductType> items)
            => string.IsNullOrEmpty(tbSearchStrName.Text)
            ? items
            : items.Where(e => e.Name.Contains(tbSearchStrName.Text));

        private void SelectSortField()
        {
            var selectField = new HashSet<ProductTypeSortType>();
            foreach (string item in checkCmbField.Items)
            {
                var checkBoxItem = checkCmbField.CheckBoxItems[item];

                if (checkBoxItem.Checked && ProductTypeSortType.TryFromName(item, out var sortField))
                {
                    selectField.Add(sortField);
                }
            }
            _selectSortField.SortFields = selectField;
        }

        private void BtnTypeSort_Click(object sender, EventArgs e)
        {
            if (_isAscending)
            {
                _isAscending = false;
                btnTypeSort.Text = TypeSortFields.Descending.Name;
            }
            else
            {
                _isAscending = true;
                btnTypeSort.Text = TypeSortFields.Ascending.Name;
            }

            LoadData();
        }
    }
}

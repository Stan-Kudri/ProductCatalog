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
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.Extension;
using TestTask.Forms.Products;

namespace TestTask.Controls.PageTabControls
{
    public partial class ProductListView : UserControl, IListViewDataProvider, IInitialize, ILoad
    {
        private const int IndexId = 0;
        private const int IndexColumnName = 1;
        private const int IndexColumnCompanyName = 2;
        private const int IndexColumnCategoryName = 3;
        private const int IndexColumnType = 4;
        private const int IndexColumnPrice = 5;
        private const int IndexColumnDestination = 6;
        private const int IndexColumnIdCompany = 7;
        private const int IndexColumnIdCategory = 8;
        private const int IndexColumnIdType = 9;

        private IServiceProvider _serviceProvider;
        private CompanyRepository _companyService;
        private CategoryRepository _categoryService;
        private ProductTypeRepository _typeService;
        private ProductRepository _productService;
        private IMessageBox _messageBox;
        private SortProductModel _selectSortField = new SortProductModel();
        private bool _isAscending = true;

        public ProductListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("ID", 60, e => ((Product)e).Id),
            new ListViewColumn("Name", 80, e => ((Product)e).Name),
            new ListViewColumn("Company", 120, e => ((Product)e).Company),
            new ListViewColumn("Category", 130, e => ((Product)e).Category),
            new ListViewColumn("Type", 120, e => ((Product)e).Type),
            new ListViewColumn("Price", 100, e => ((Product)e).Price),
            new ListViewColumn("Destination", 142, e => ((Product)e).Destination),
            new ListViewColumn("CompanyId", 1, e => ((Product)e).CompanyId),
            new ListViewColumn("CategoryId", 1, e => ((Product)e).CategoryId),
            new ListViewColumn("TypeId", 1, e => ((Product)e).TypeId),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _productService = _serviceProvider.GetRequiredService<ProductRepository>();
            _companyService = _serviceProvider.GetRequiredService<CompanyRepository>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryRepository>();
            _typeService = _serviceProvider.GetRequiredService<ProductTypeRepository>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
            checkCmbField.Items.AddRange(_selectSortField.SelectField);
        }

        public void LoadData() => listView.LoadData();

        public bool Add()
        {
            var listCompany = _companyService.GetQueryableAll();
            var listCategory = _categoryService.GetQueryableAll();
            var listTypeProduct = _typeService.GetQueryableAll();

            if (listCompany.Count() == 0)
            {
                _messageBox.ShowWarning("Add a company to the table to add a product.");
                return false;
            }

            if (listCategory.Count() == 0)
            {
                _messageBox.ShowWarning("Add a category to the table to add a product.");
                return false;
            }

            if (listTypeProduct.Count() == 0)
            {
                _messageBox.ShowWarning("Add a type to the table to add a product.");
                return false;
            }

            using (var addForm = _serviceProvider.GetRequiredService<AddItemProductForm>())
            {
                addForm.Initialize(listCompany.ToList(), listCategory.ToList(), listTypeProduct.ToList());

                if (addForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var item = addForm.GetProductModel().ToProduct();
                _productService.Add(item);
            }

            return true;
        }

        public bool Edit(Entity entity)
        {
            var listCompany = _companyService.GetAll();
            var listCategory = _categoryService.GetAll();
            var listTypeProduct = _typeService.GetAll();
            var oldItem = (Product)entity;

            using (var editForm = _serviceProvider.GetRequiredService<EditItemProductForm>())
            {
                editForm.Initialize(listCompany, listCategory, listTypeProduct, oldItem);

                if (editForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editForm.GetEditProduct();
                _productService.Updata(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var idProduct = item.GetNonNullableString(IndexId).ParseInt();
            var name = item.GetNonNullableString(IndexColumnName);
            var price = item.GetNonNullableString(IndexColumnPrice).ParseDecimal();
            var destination = item.GetNonNullableString(IndexColumnDestination);
            var companyId = item.GetNonNullableString(IndexColumnIdCompany).ParseInt();
            var categoryId = item.GetNonNullableString(IndexColumnIdCategory).ParseInt();
            var typeId = item.GetNonNullableString(IndexColumnIdType).ParseInt();

            return new Product(name, companyId, categoryId, typeId, destination, price, idProduct);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _productService.GetQueryableAll();
            queriable = GetSearchType(queriable);
            queriable = _selectSortField.Apply(queriable, _isAscending);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity) => _productService.Remove(entity.Id);

        private void ButtonUseFilter_Click(object sender, EventArgs e)
        {
            SelectSortField();
            LoadData();
        }

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            tbSearchStrName.Text = string.Empty;
            _selectSortField.SortFields = new HashSet<ProductSortType>();
            checkCmbField.ClearSelection();
            _isAscending = true;
            btnTypeSort.Text = TypeSortFields.Ascending.Name;
            LoadData();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private IQueryable<Product> GetSearchType(IQueryable<Product> items)
            => string.IsNullOrEmpty(tbSearchStrName.Text)
            ? items
            : items.Where(e => e.Name.Contains(tbSearchStrName.Text));


        private void SelectSortField()
        {
            var selectField = new HashSet<ProductSortType>();
            foreach (string item in checkCmbField.Items)
            {
                var checkBoxItem = checkCmbField.CheckBoxItems[item];

                if (checkBoxItem.Checked && ProductSortType.TryFromName(item, out var sortField))
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

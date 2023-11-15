using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem.Pages.Products;
using TestTask.Control.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.Extension;
using TestTask.Forms.Products;

namespace TestTask.Control.PageTabControls
{
    public partial class ProductListView : UserControl, IListViewDataProvider, IInitialize, ILoad
    {
        private const int IndexId = 0;
        private const int IndexColumnCompanyName = 1;
        private const int IndexColumnCategoryName = 2;
        private const int IndexColumnType = 3;
        private const int IndexColumnPrice = 4;
        private const int IndexColumnDestination = 5;
        private const int IndexColumnIdCompany = 6;
        private const int IndexColumnIdCategory = 7;
        private const int IndexColumnIdType = 8;

        private IServiceProvider _serviceProvider;
        private CompanyService _companyService;
        private CategoryService _categoryService;
        private ProductTypeService _typeService;
        private ProductService _productService;
        private IMessageBox _messageBox;
        private SortProducts _sortProduct = new SortProducts();

        public ProductListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("ID", 60, e => ((Product)e).Id),
            new ListViewColumn("Company", 140, e => ((Product)e).Company),
            new ListViewColumn("Category", 130, e => ((Product)e).Category),
            new ListViewColumn("Type", 150, e => ((Product)e).Type),
            new ListViewColumn("Price", 100, e => ((Product)e).Price),
            new ListViewColumn("Destination", 172, e => ((Product)e).Destination),
            new ListViewColumn("CompanyId", 1, e => ((Product)e).CompanyId),
            new ListViewColumn("CategoryId", 1, e => ((Product)e).CategoryId),
            new ListViewColumn("TypeId", 1, e => ((Product)e).TypeId),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            _companyService = _serviceProvider.GetRequiredService<CompanyService>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
            cmbSortField.DataSource = _sortProduct.Items;
            cmbSortField.SelectedItem = _sortProduct.SortField;

        }

        public void LoadData() => listView.LoadData();

        public bool Add()
        {
            var listCompany = _companyService.GetQueryableAll();
            var listCategory = _categoryService.GetQueryableAll();

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

            using (var addForm = _serviceProvider.GetRequiredService<AddItemProductForm>())
            {
                addForm.Initialize(listCompany.ToList(), listCategory.ToList());

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
            var oldItem = (Product)entity;

            using (var editForm = _serviceProvider.GetRequiredService<EditItemProductForm>())
            {
                editForm.Initialize(listCompany, listCategory, oldItem);

                if (editForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editForm.GetEditProduct();
                _productService.Update(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var idProduct = item.GetNonNullableString(IndexId).ParseInt();
            var price = item.GetNonNullableString(IndexColumnPrice).ParseDecimal();
            var destination = item.GetNonNullableString(IndexColumnDestination);
            var companyId = item.GetNonNullableString(IndexColumnIdCompany).ParseInt();
            var categoryId = item.GetNonNullableString(IndexColumnIdCategory).ParseInt();
            var typeId = item.GetNonNullableString(IndexColumnIdType).ParseInt();

            return new Product(companyId, categoryId, typeId, destination, price, idProduct);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _productService.GetQueryableAll();
            queriable = GetSearchType(queriable);
            queriable = _sortProduct.Apply(queriable);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity)
            => _productService.Remove(entity.Id);

        private void ButtonUseFilter_Click(object sender, EventArgs e) => LoadData();

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            cmbSortField.SelectedItem = SortProducts.NoSorting;
            _sortProduct.SortField = cmbSortField.SelectedItem.ToString();
            tbSearchStrType.Text = string.Empty;
            LoadData();
        }

        private void CmbSortField_Changed(object sender, EventArgs e)
        {
            _sortProduct.SortField = cmbSortField.SelectedItem.ToString();
            LoadData();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private IQueryable<Product> GetSearchType(IQueryable<Product> items)
            => string.IsNullOrEmpty(tbSearchStrType.Text)
            ? items
            : items.Where(e => e.Destination.Contains(tbSearchStrType.Text));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.BindingItem.Pages;
using ProductCatalog.BindingItem.Pages.Sort;
using ProductCatalog.Controls.PageTabControls.Model;
using ProductCatalog.Core;
using ProductCatalog.Core.Models;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Page;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.Extension;
using ProductCatalog.Forms.Products;
using ProductCatalog.Messages;

namespace ProductCatalog.Controls.PageTabControls
{
    public partial class ProductListView : UserControl, IListViewDataProvider, IInitialize, ILoad
    {
        private const int IndexColumnName = 0;
        private const int IndexColumnPrice = 4;
        private const int IndexColumnDestination = 5;
        private const int IndexId = 6;
        private const int IndexColumnIdCompany = 7;
        private const int IndexColumnIdCategory = 8;
        private const int IndexColumnIdType = 9;

        private IServiceProvider _serviceProvider;
        private CompanyService _companyRepository;
        private CategoryService _categoryRepository;
        private ProductTypeService _typeRepository;
        private ProductService _productRepository;

        private MessageByTable<Product> _messageByTable;
        private readonly SortProductModel _selectSortField = new SortProductModel();
        private bool _isAscending = true;

        public ProductListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("Name", 140, e => ((Product)e).Name),
            new ListViewColumn("Company", 140, e => ((Product)e).Company),
            new ListViewColumn("Category", 130, e => ((Product)e).Category),
            new ListViewColumn("Type", 120, e => ((Product)e).Type),
            new ListViewColumn("Price", 100, e => ((Product)e).Price),
            new ListViewColumn("Destination", 121, e => ((Product)e).Destination),
            new ListViewColumn("ID", 0, e => ((Product)e).Id),
            new ListViewColumn("CompanyId", 0, e => ((Product)e).CompanyId),
            new ListViewColumn("CategoryId", 0, e => ((Product)e).CategoryId),
            new ListViewColumn("TypeId", 0, e => ((Product)e).TypeId),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _productRepository = _serviceProvider.GetRequiredService<ProductService>();
            _companyRepository = _serviceProvider.GetRequiredService<CompanyService>();
            _categoryRepository = _serviceProvider.GetRequiredService<CategoryService>();
            _typeRepository = _serviceProvider.GetRequiredService<ProductTypeService>();
            _messageByTable = _serviceProvider.GetRequiredService<MessageByTable<Product>>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
            checkCmbField.Items.AddRange(_selectSortField.SelectField);
            LoadData();
        }

        public void LoadData() => listView.LoadData();

        public async Task<bool> Add()
        {
            var listCompany = _companyRepository.GetQueryableAll();
            var listCategory = _categoryRepository.GetQueryableAll();
            var listTypeProduct = _typeRepository.GetQueryableAll();

            if (!await _messageByTable.ShouldNotBeEmpty(listCompany)
                || !await _messageByTable.ShouldNotBeEmpty(listCategory)
                || !await _messageByTable.ShouldNotBeEmpty(listTypeProduct))
            {
                return false;
            }

            using (var addForm = _serviceProvider.GetRequiredService<AddItemProductForm>())
            {
                addForm.Initialize(listCompany.ToList(), listCategory.ToList(), listTypeProduct.ToList());

#pragma warning disable CA1849 // Call async methods when in an async method
                if (addForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
#pragma warning restore CA1849 // Call async methods when in an async method

                var item = addForm.GetProductModel().ToProduct();
                await _productRepository.AddAsync(item);
            }

            return true;
        }

        public async Task<bool> Edit(Entity entity)
        {
            var listCompany = await _companyRepository.GetAll();
            var listCategory = await _categoryRepository.GetAll();
            var listTypeProduct = await _typeRepository.GetAll();
            var oldItem = (Product)entity;

            using (var editForm = _serviceProvider.GetRequiredService<EditItemProductForm>())
            {
                editForm.Initialize(listCompany, listCategory, listTypeProduct, oldItem);

                var dialogResult = await editForm.FormShowDialogAsync();

                if (dialogResult != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editForm.GetEditProduct();
                await _productRepository.UpdataAsync(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var idProduct = item.GetNonNullableString(IndexId).ParseGuid();
            var name = item.GetNonNullableString(IndexColumnName);
            var price = item.GetNonNullableString(IndexColumnPrice).ParseDecimal();
            var destination = item.GetNonNullableString(IndexColumnDestination);
            var companyId = item.GetNonNullableString(IndexColumnIdCompany).ParseGuid();
            var categoryId = item.GetNonNullableString(IndexColumnIdCategory).ParseGuid();
            var typeId = item.GetNonNullableString(IndexColumnIdType).ParseGuid();

            return new Product(name, companyId, categoryId, typeId, destination, price, idProduct);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _productRepository.GetQueryableAll();
            queriable = GetSearchType(queriable);
            queriable = _selectSortField.Apply(queriable, _isAscending);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public async Task Remove(Entity entity) => await _productRepository.RemoveAsync(entity.Id);

        private void ButtonUseFilter_Click(object sender, EventArgs e)
            => UsedFilter();

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            tbSearchStrName.Text = string.Empty;
            _selectSortField.SortFields = new HashSet<ProductSortField>();
            checkCmbField.ClearSelection();
            _isAscending = true;
            btnTypeSort.Text = TypeSortFields.Ascending.Name;
            LoadData();
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

            UsedFilter();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private IQueryable<Product> GetSearchType(IQueryable<Product> items)
            => string.IsNullOrEmpty(tbSearchStrName.Text)
            ? items
            : items.Where(e => e.Name.Contains(tbSearchStrName.Text));

        private void SelectSortField()
        {
            var selectField = new HashSet<ProductSortField>();
            foreach (string item in checkCmbField.Items)
            {
                var checkBoxItem = checkCmbField.CheckBoxItems[item];

                if (checkBoxItem.Checked && ProductSortField.TryFromName(item, out var sortField))
                {
                    selectField.Add(sortField);
                }
            }
            _selectSortField.SortFields = selectField;
        }

        private void UsedFilter()
        {
            SelectSortField();
            LoadData();
        }
    }
}

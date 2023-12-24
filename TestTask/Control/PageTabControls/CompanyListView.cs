using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem.Pages;
using TestTask.BindingItem.Pages.Companies;
using TestTask.Control.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Extension;
using TestTask.Forms.Companies;

namespace TestTask.Control.PageTabControls
{
    public partial class CompanyListView : UserControl, IListViewDataProvider, IInitialize, ILoad
    {
        private const int IndexId = 0;
        private const int IndexColumnName = 1;
        private const int IndexColumnDataCreate = 2;
        private const int IndexColumnCountry = 3;

        private IServiceProvider _serviceProvider;
        private CompanyRepository _companyService;
        private ProductRepository _productService;
        private SortCompaniesModel _sortField = new SortCompaniesModel();
        private TypeSortFieldModel _typeSort = new TypeSortFieldModel();

        public CompanyListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("ID", 100, e => ((Company)e).Id),
            new ListViewColumn("Name", 300, e => ((Company)e).Name),
            new ListViewColumn("DateCreation", 155, e => ((Company)e).DateCreation.ToString("d")),
            new ListViewColumn("Country", 200, e => ((Company)e).Country),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _companyService = _serviceProvider.GetRequiredService<CompanyRepository>();
            _productService = _serviceProvider.GetRequiredService<ProductRepository>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());

            cmbSortField.DataSource = _sortField.Items;
            cmbSortField.SelectedItem = _sortField.SortField;
            cmbTypeSort.DataSource = _typeSort.Items;
            cmbTypeSort.SelectedItem = _typeSort.SortType;
        }

        public void LoadData() => listView.LoadData();

        public bool Add()
        {
            using (var addForm = _serviceProvider.GetRequiredService<AddItemCompanyForm>())
            {
                if (addForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var item = addForm.GetCompanyModel().ToCompany();
                _companyService.Add(item);
            }

            return true;
        }

        public bool Edit(Entity entity)
        {
            var oldItem = (Company)entity;
            using (var editForm = _serviceProvider.GetRequiredService<EditItemCompanyForm>())
            {
                editForm.Initialize(oldItem);

                if (editForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editForm.GetEditCompany();
                _companyService.Updata(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var id = item.GetNonNullableString(IndexId).ParseInt();
            var name = item.GetNonNullableString(IndexColumnName) ?? throw new ArgumentException("Name cannot be null.");
            var strDateCreation = item.GetNonNullableString(IndexColumnDataCreate);
            DateTime dateCreation = strDateCreation != null ? DateTime.Parse(strDateCreation) : throw new ArgumentException("Data create cannot be null.");
            var country = item.GetNonNullableString(IndexColumnCountry) ?? throw new ArgumentException("Country cannot be null.");

            return new Company(name, dateCreation, country, id);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _companyService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = _sortField.Apply(queriable, _typeSort.IsAscending);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity)
        {
            _productService.RemoveProductRelatedToCompany(entity.Id);
            _companyService.Remove(entity.Id);
        }

        private void ButtonUseFilter_Click(object sender, EventArgs e) => LoadData();

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            cmbSortField.SelectedItem = SortCompaniesModel.IdSort;
            cmbTypeSort.SelectedItem = TypeSortField.NoSorting;
            _sortField.SortField = cmbSortField.SelectedItem.ToString();
            _typeSort.SetSort(cmbTypeSort.SelectedItem.ToString());
            tbSearchStrName.Text = string.Empty;
            LoadData();
        }

        private void CmbSortField_Changed(object sender, EventArgs e)
        {
            _sortField.SortField = cmbSortField.SelectedItem.ToString();
            LoadData();
        }

        private void CmbTypeSort_Changed(object sender, EventArgs e)
        {
            _typeSort.SetSort(cmbTypeSort.SelectedItem.ToString());

            if (_typeSort.IsAscending == null)
            {
                cmbSortField.Enabled = cmbSortField.Visible
                    = labelSortField.Enabled = labelSortField.Visible = false;
            }
            else
            {
                cmbSortField.Enabled = cmbSortField.Visible
                        = labelSortField.Enabled = labelSortField.Visible = true;
            }

            LoadData();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private IQueryable<Company> GetSearchName(IQueryable<Company> items)
            => string.IsNullOrEmpty(tbSearchStrName.Text)
            ? items
            : items.Where(e => e.Name.Contains(tbSearchStrName.Text) || e.Country.Contains(tbSearchStrName.Text) || e.DateCreation.ToString().Contains(tbSearchStrName.Text));
    }
}

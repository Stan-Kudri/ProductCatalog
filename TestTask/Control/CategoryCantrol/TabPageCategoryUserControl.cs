using Microsoft.Extensions.DependencyInjection;
using System;
using TestTask.BindingItem.Pages.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page.Categories;

namespace TestTask.Control.CategoryCantrol
{
    public partial class TabPageCategoryUserControl : BaseUserControl
    {
        private SearchRequestCategory _searchRequest = new SearchRequestCategory();
        private CategoryService _categoryService;
        private SortPageCategories _sortPage;
        private FilterModelCategories _filterName;

        public TabPageCategoryUserControl()
            : base() => InitializeComponent();

        public void Initialize(IServiceProvider serviceProvider)
        {
            listViewCategoryControl.Initialize(serviceProvider);
            _categoryService = serviceProvider.GetRequiredService<CategoryService>();

            _filterName = new FilterModelCategories(_categoryService.GetAll());
            _sortPage = new SortPageCategories();

            cmbFilterCategory.DataSource = _filterName.Items;
            cmbSortName.DataSource = _sortPage.Items;
            cmbFilterCategory.SelectedItem = _filterName.Category;
            cmbSortName.SelectedItem = _sortPage.SortType;

            _searchRequest = new SearchRequestCategory(_filterName.GetFilterCategoryName(), _sortPage.ToSortCategory(), listViewCategoryControl.Page.GetPage());
            listViewCategoryControl.ChangeCategories += Update;
            listViewCategoryControl.ChangePageCurrent += LoadData;
        }

        private void CmbSortName_Changed(object sender, EventArgs e)
        {
            _sortPage.SetSort(cmbSortName.SelectedItem.ToString());
            _searchRequest.Sort = _sortPage.ToSortCategory();
            LoadData();
        }

        private void CmbFilterCategory_Changed(object sender, EventArgs e)
        {

            _filterName.Category = cmbFilterCategory.SelectedItem.ToString();
            _searchRequest.Filter = _filterName.GetFilterCategoryName();
            LoadData();
        }

        public void LoadData()
        {
            var query = _searchRequest.ApplyFilter(_categoryService.GetQueryableAll());
            query = _searchRequest.ApplyOrderBy(query);
            listViewCategoryControl.LoadDataPage(query);
        }

        public void Closing()
        {
            listViewCategoryControl.ChangeCategories -= Update;
            listViewCategoryControl.Closing();
        }

        public void Update()
        {
            _filterName = new FilterModelCategories(_categoryService.GetAll());
            cmbFilterCategory.DataSource = _filterName.Items;
            cmbFilterCategory.SelectedItem = _filterName.Category;
        }
    }
}

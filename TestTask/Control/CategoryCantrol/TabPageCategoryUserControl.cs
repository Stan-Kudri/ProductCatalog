using Microsoft.Extensions.DependencyInjection;
using System;
using TestTask.BindingItem.Pages.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page.Categories;

namespace TestTask.Control.CategoryCantrol
{
    public partial class TabPageCategoryUserControl : BaseUserControl
    {
        private CategoryService _categoryService;
        private SortPageCategories _sortPage;
        private FilterModelCategories _filterName;

        public TabPageCategoryUserControl()
            : base()
        {
            InitializeComponent();
        }

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

            listViewCategoryControl.SearchRequest = new SearchRequestCategory(_filterName.GetFilterCategoryName(), _sortPage.ToSortCategory(), listViewCategoryControl.Page.GetPage());
        }

        private void CmbSortName_Changed(object sender, EventArgs e)
        {
            _sortPage.SetSort(cmbSortName.SelectedItem.ToString());
            listViewCategoryControl.SearchRequest.Sort = _sortPage.ToSortCategory();
            LoadData();
        }

        private void CmbFilterCategory_Changed(object sender, EventArgs e)
        {
            _filterName.Category = cmbFilterCategory.SelectedItem.ToString();
            listViewCategoryControl.SearchRequest.Filter = _filterName.GetFilterCategoryName();
            LoadData();
        }

        public void LoadData() => listViewCategoryControl.LoadData();

        public void Closing() => listViewCategoryControl.Closing();
    }
}

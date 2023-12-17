using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Categories
{
    public partial class CategoryPage
    {
        [Inject] CategoryService CategoryService { get; set; }
        [Inject] ProductTypeService ProductTypeService { get; set; }
        [Inject] ProductService ProductService { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] NavigationManager Navigation { get; set; }


        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<Category>? categories;
        private HashSet<Category> selectedItems = new HashSet<Category>();
        private bool isSelectItems = true;

        private string? searchString = null;

        private SortCategories sortField = new SortCategories();
        private PageModel pageModel = new PageModel();

        private bool IsAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();


        private void OnSelectItems(HashSet<Category> items)
        {
            selectedItems = items;
            isSelectItems = selectedItems.Count <= 0;
        }

        private void AddCategoryPage() => Navigation.NavigateTo($"/category");

        private void EditCategpryPage(int id) => Navigation.NavigateTo($"category/{id}");

        private async Task Remove()
        {
            if (selectedItems.Count <= NoItemsSelected)
            {
                await ShowMessageWarning(MessageNotSelectedItem);
                return;
            }

            bool? result = await DialogService.ShowMessageBox(
                "Warning",
                "Delete selecte items?",
                yesText: "Yes", cancelText: "No");

            if (result != true)
            {
                return;
            }

            foreach (var item in selectedItems)
            {
                ProductTypeService.RemoveProductRelatedToCategory(item.Id);
                ProductService.RemoveProductRelatedToCategory(item.Id);
                CategoryService.Remove(item.Id);
            }

            LoadData();
        }

        private void Update(int id) => EditCategpryPage(id);

        private async Task Remove(int id)
        {
            bool? result = await DialogService.ShowMessageBox(
               "Warning",
               "Delete selecte items?",
               yesText: "Yes", cancelText: "No");

            if (result != true)
            {
                return;
            }

            ProductTypeService.RemoveProductRelatedToCategory(id);
            ProductService.RemoveProductRelatedToCategory(id);
            CategoryService.Remove(id);
            LoadData();
        }

        private void ClearFilter()
        {
            IsAscending = true;
            sortField.Clear();
            LoadData();
        }

        public void OnToggledChanged(bool toggled)
        {
            IsAscending = toggled;
            LoadData();
        }

        private void OnSearch(string text)
        {
            searchString = text;
            LoadData();
        }

        private void LoadData()
        {
            IQueryable<Category> queriable = CategoryService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = sortField.Apply(queriable, IsAscending);
            var result = queriable.GetPagedList(pageModel);
            categories = result.Items;
            StateHasChanged();
        }

        private IQueryable<Category> GetSearchName(IQueryable<Category> items)
                => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString));

        private Task ShowMessageWarning(string message)
        {
            return DialogService.ShowMessageBox(
                    "Warning",
                     message,
                     yesText: "Ok"
                );
        }
    }
}

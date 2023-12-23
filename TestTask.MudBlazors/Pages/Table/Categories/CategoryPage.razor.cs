using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using TestTask.Core.Import;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Categories
{
    public partial class CategoryPage
    {
        [Inject] private CategoryService CategoryService { get; set; } = null!;
        [Inject] private ProductTypeService ProductTypeService { get; set; } = null!;
        [Inject] private ExcelImporter<Category> ExcelImportCategory { get; set; } = null!;
        [Inject] private ProductService ProductService { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;


        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<Category>? categories;
        private HashSet<Category> selectedItems = new HashSet<Category>();
        private bool isSelectItems = true;

        private string? searchString = null;

        private SortCategories sortField = new SortCategories();
        private PageModel pageModel = new PageModel();

        private bool isAscending { get; set; } = true;

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
            isAscending = true;
            sortField.Clear();
            LoadData();
        }

        private async Task UploadFiles(IBrowserFile fileload)
        {
            if (fileload.Size == decimal.Zero)
            {
                return;
            }

            var buffer = new byte[fileload.Size];
            await fileload.OpenReadStream().ReadAsync(buffer);

            var categoryRead = ExcelImportCategory.Import(buffer);
            foreach (var row in categoryRead)
            {
                if (row.Success)
                {
                    CategoryService.Upsert(row.Value);
                }
            }
            LoadData();
        }

        public void OnToggledChanged(bool toggled)
        {
            isAscending = toggled;
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
            queriable = sortField.Apply(queriable, isAscending);
            var result = queriable.GetPagedList(pageModel);
            categories = result.Items;
            StateHasChanged();
        }

        private IQueryable<Category> GetSearchName(IQueryable<Category> items)
                => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString));

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }
}

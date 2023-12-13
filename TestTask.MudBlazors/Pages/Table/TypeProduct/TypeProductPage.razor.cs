using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.TypeProduct
{
    public partial class TypeProductPage
    {
        [Inject] ProductTypeService TypeService { get; set; }
        [Inject] ProductService ProductService { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] NavigationManager Navigation { get; set; }

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<ProductType>? typeProduct;
        private HashSet<ProductType> selectedItems = new HashSet<ProductType>();

        private string? searchString = null;

        private SortType sortField = new SortType();
        private PageModel pageModel = new PageModel();

        private bool IsAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private void AddCompanyPage() => Navigation?.NavigateTo("/addtype");

        private void EditTypePage(int id) => Navigation?.NavigateTo($"edittype/{id}");

        private async Task Remove()
        {
            if (selectedItems.Count <= NoItemsSelected)
            {
                ShowMessageWarning(MessageNotSelectedItem);
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
                ProductService.RemoveProductRelatedToType(item.Id);
                TypeService.Remove(item.Id);
            }

            LoadData();
        }

        private void Update(int id) => EditTypePage(id);

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

            ProductService.RemoveProductRelatedToType(id);
            TypeService.Remove(id);
            LoadData();
        }

        private void UseFilter() => LoadData();

        private void ClearFilter()
        {
            IsAscending = true;
            sortField.Clear();
            LoadData();
        }

        private void OnSearch(string text)
        {
            searchString = text;
            LoadData();
        }

        private void LoadData()
        {
            IQueryable<ProductType> queriable = TypeService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = sortField.Apply(queriable, IsAscending);
            var result = queriable.GetPagedList(pageModel);
            typeProduct = result.Items;
            StateHasChanged();
        }

        private IQueryable<ProductType> GetSearchName(IQueryable<ProductType> items)
                => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString));

        private async void ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }
}

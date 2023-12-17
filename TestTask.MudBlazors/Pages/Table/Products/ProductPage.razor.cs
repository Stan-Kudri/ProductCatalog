using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Products;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Products
{
    public partial class ProductPage
    {
        [Inject] ProductService ProductService { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] NavigationManager Navigation { get; set; }

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<Product>? product;
        private HashSet<Product> selectedItems = new HashSet<Product>();
        private bool isSelectItems = true;

        private string? searchString = null;

        private SortProduct sortField = new SortProduct();
        private PageModel pageModel = new PageModel();

        private bool IsAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private void OnSelectItems(HashSet<Product> items)
        {
            selectedItems = items;
            isSelectItems = selectedItems.Count <= 0;
        }

        private void AddPage() => Navigation?.NavigateTo("/product");

        private void EditPage(int id) => Navigation?.NavigateTo($"product/{id}");

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
                ProductService.Remove(item.Id);
            }

            LoadData();
        }

        private void Update(int id) => EditPage(id);

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

            ProductService.Remove(id);
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
            IQueryable<Product> queriable = ProductService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = sortField.Apply(queriable, IsAscending);
            var result = queriable.GetPagedList(pageModel);
            product = result.Items;
            StateHasChanged();
        }

        private IQueryable<Product> GetSearchName(IQueryable<Product> items)
                => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Company.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString)
                                || e.Type.Name.Contains(searchString)
                                || e.Price.ToString().Contains(searchString));

        private async void ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }
}

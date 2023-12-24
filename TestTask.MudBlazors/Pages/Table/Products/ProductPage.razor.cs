using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System.Globalization;
using TestTask.Core.Import;
using TestTask.Core.Models.Products;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Products
{
    public partial class ProductPage
    {
        [Inject] private ProductRepository ProductRepository { get; set; } = null!;
        [Inject] private ExcelImporter<Product> ExcelImportProduct { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<Product>? product;
        private HashSet<Product> selectedItems = new HashSet<Product>();
        private bool isSelectItems = true;

        private string? searchString = null;

        private SortProduct sortField = new SortProduct();
        private PageModel pageModel = new PageModel();

        private bool isAscending { get; set; } = true;

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
                ProductRepository.Remove(item.Id);
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

            ProductRepository.Remove(id);
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

            var productRead = ExcelImportProduct.Import(buffer);
            foreach (var row in productRead)
            {
                if (row.Success)
                {
                    ProductRepository.Upsert(row.Value);
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
            IQueryable<Product> queriable = ProductRepository.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = sortField.Apply(queriable, isAscending);
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
                                || e.Price.ToString(CultureInfo.InvariantCulture).Contains(searchString));

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }
}

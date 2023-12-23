using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using TestTask.Core.Import;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.TypeProduct
{
    public partial class TypeProductPage
    {
        [Inject] private ProductTypeService TypeService { get; set; } = null!;
        [Inject] private ProductService ProductService { get; set; } = null!;
        [Inject] private ExcelImporter<ProductType> ExcelImportProductType { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<ProductType>? typeProduct;
        private HashSet<ProductType> selectedItems = new HashSet<ProductType>();
        private bool isSelectItems = true;

        private string? searchString = null;

        private SortType sortField = new SortType();
        private PageModel pageModel = new PageModel();

        private bool isAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private void OnSelectItems(HashSet<ProductType> items)
        {
            selectedItems = items;
            isSelectItems = selectedItems.Count <= 0;
        }

        private void AddPage() => Navigation?.NavigateTo("/type");

        private void EditTypePage(int id) => Navigation?.NavigateTo($"type/{id}");

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

        public void OnToggledChanged(bool toggled)
        {
            isAscending = toggled;
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

            var typeProductRead = ExcelImportProductType.Import(buffer);
            foreach (var row in typeProductRead)
            {
                if (row.Success)
                {
                    TypeService.Upsert(row.Value);
                }
            }
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
            queriable = sortField.Apply(queriable, isAscending);
            var result = queriable.GetPagedList(pageModel);
            typeProduct = result.Items;
            StateHasChanged();
        }

        private IQueryable<ProductType> GetSearchName(IQueryable<ProductType> items)
                => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString));

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }
}

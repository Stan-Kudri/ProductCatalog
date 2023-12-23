using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using TestTask.Core.Import;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Companies
{
    public partial class CompanyPage
    {
        [Inject] private CompanyService CompanyService { get; set; } = null!;
        [Inject] private ProductService ProductService { get; set; } = null!;
        [Inject] private ExcelImporter<Company> ExcelImportCompany { get; set; } = null!;
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<Company>? companies;
        private HashSet<Company> selectedItems = new HashSet<Company>();
        private bool isSelectItems = true;

        private string? searchString = null;

        private SortCompany sortField = new SortCompany();
        private PageModel pageModel = new PageModel();

        private bool isAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private void OnSelectItems(HashSet<Company> items)
        {
            selectedItems = items;
            isSelectItems = selectedItems.Count <= 0;
        }

        private void AddPage() => Navigation?.NavigateTo("/company");

        private void EditCompanyPage(int id) => Navigation?.NavigateTo($"company/{id}");

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
                ProductService.RemoveProductRelatedToCompany(item.Id);
                CompanyService.Remove(item.Id);
            }

            LoadData();
        }

        private void Update(int id) => EditCompanyPage(id);

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

            ProductService.RemoveProductRelatedToCompany(id);
            CompanyService.Remove(id);
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

            var companyRead = ExcelImportCompany.Import(buffer);
            foreach (var row in companyRead)
            {
                if (row.Success)
                {
                    CompanyService.Upsert(row.Value);
                }
            }
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
            IQueryable<Company> queriable = CompanyService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = sortField.Apply(queriable, isAscending);
            var result = queriable.GetPagedList(pageModel);
            companies = result.Items;
            StateHasChanged();
        }

        private IQueryable<Company> GetSearchName(IQueryable<Company> items)
                => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Country.Contains(searchString)
                                || e.DateCreation.ToString().Contains(searchString));

        private async Task ShowMessageWarning(string message)
            => await DialogService.ShowMessageBox("Warning", message, yesText: "Ok");
    }
}

using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models.Companies;
using TestTask.MudBlazors.Extension;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table.Companies
{
    public partial class CompanyPage
    {
        [Inject] CompanyService CompanyService { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] NavigationManager Navigation { get; set; }

        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        private IEnumerable<Company>? companies;
        private HashSet<Company> selectedItems = new HashSet<Company>();

        private string? searchString = null;

        private SortCompany sortField = new SortCompany();
        private PageModel pageModel = new PageModel();

        private bool IsAscending { get; set; } = true;

        protected override void OnInitialized() => LoadData();

        private void AddCompanyPage() => Navigation?.NavigateTo("/addcompany");

        private void EditCompanyPage(int id) => Navigation?.NavigateTo($"editcompany/{id}");

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

            CompanyService.Remove(id);
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
            IQueryable<Company> queriable = CompanyService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = sortField.Apply(queriable, IsAscending);
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

        private async void ShowMessageWarning(string message)
        {
            await DialogService.ShowMessageBox(
                    "Warning",
                     message,
                     yesText: "Ok"
                );
        }
    }
}

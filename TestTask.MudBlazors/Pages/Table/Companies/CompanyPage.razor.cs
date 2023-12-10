using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.Core.Models;
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

        private int totalItems;
        private string? searchString = null;

        private string valueTypeSort { get; set; } = TypeSortField.NoSorting;

        private bool isNotDisableFilter => valueTypeSort == TypeSortField.NoSorting || valueTypeSort == null ? true : false;

        private SortCompanies sortField = new SortCompanies();
        private TypeSortField typeSortField = new TypeSortField();
        private PageModel pageModel = new PageModel();

        protected override void OnInitialized() => LoadData();

        private void AddCompanyPage() => Navigation?.NavigateTo("/addcompany");

        private void EditCompanyPage(int id) => Navigation?.NavigateTo($"editcompany/{id}");

        private async void Remove()
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

        private async void Remove(int id)
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

        private void UseFilter()
        {
            typeSortField.SetSort(valueTypeSort);
            LoadData();
        }

        private void ClearFilter()
        {
            valueTypeSort = TypeSortField.NoSorting;
            typeSortField.SetSort(valueTypeSort);
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
            queriable = sortField.Apply(queriable, typeSortField.IsAscending);
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

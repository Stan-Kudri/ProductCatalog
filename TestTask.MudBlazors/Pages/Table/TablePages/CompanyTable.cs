using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.TablePages
{
    public partial class CompanyTable : IDataProcessor
    {
        private NavigationManager _navigation;

        public CompanyTable(NavigationManager navigation)
        {
            _navigation = navigation;
        }

        public void AddItemPage() => _navigation.NavigateTo("/company");

        public void EditItemPage(int id) => _navigation.NavigateTo($"company/{id}");
    }
}

using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.TablePages
{
    public partial class CompanyPage : IDataProcessor
    {
        private NavigationManager _navigation;

        public CompanyPage(NavigationManager navigation)
        {
            _navigation = navigation;
        }

        public void AddItemPage() => _navigation.NavigateTo("/company");

        public void EditItemPage(int id) => _navigation.NavigateTo($"company/{id}");
    }
}

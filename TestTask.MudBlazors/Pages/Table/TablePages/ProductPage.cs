using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.TablePages
{
    public class ProductPage : IDataProcessor
    {
        private readonly NavigationManager _navigation;

        public ProductPage(NavigationManager navigation) => _navigation = navigation;

        public void AddItemPage() => _navigation.NavigateTo("/product");

        public void EditItemPage(int id) => _navigation.NavigateTo($"product/{id}");
    }
}

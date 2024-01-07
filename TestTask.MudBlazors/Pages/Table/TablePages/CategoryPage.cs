using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.TablePages
{
    public class CategoryPage : IDataProcessor
    {
        private readonly NavigationManager _navigation;

        public CategoryPage(NavigationManager navigation)
            => _navigation = navigation;

        public void AddItemPage() => _navigation.NavigateTo("/category");

        public void EditItemPage(int id) => _navigation.NavigateTo($"category/{id}");
    }
}

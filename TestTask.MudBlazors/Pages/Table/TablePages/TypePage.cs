using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.TablePages
{
    public class TypePage : IDataProcessor
    {
        private readonly NavigationManager _navigation;

        public TypePage(NavigationManager navigation) => _navigation = navigation;

        public void AddItemPage() => _navigation.NavigateTo("/type");

        public void EditItemPage(int id) => _navigation.NavigateTo($"type/{id}");
    }
}

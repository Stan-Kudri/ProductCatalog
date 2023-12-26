using Microsoft.AspNetCore.Components;
using MudBlazor;
using TestTask.MudBlazors.Model;
using TestTask.MudBlazors.Pages.Import;

namespace TestTask.MudBlazors.Pages.Table
{
    public partial class TablePage
    {
        [Inject] private IDialogService DialogService { get; set; } = null!;
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        [Parameter]
        public int SelectIndexTab { get; set; } = TabTable.Company.ActiveTabIndex;

        private void NavigationSelectTab(int selectIndexTab)
        {
            SelectIndexTab = selectIndexTab;
            Navigation.NavigateTo($"/table/{SelectIndexTab}");
        }

        private async void OpenDialog()
        {
            DialogOptions closeOnEscapeKey = new DialogOptions { CloseOnEscapeKey = true };
            DialogService.Show<DialogImportData>("Import table", closeOnEscapeKey);
        }
    }
}

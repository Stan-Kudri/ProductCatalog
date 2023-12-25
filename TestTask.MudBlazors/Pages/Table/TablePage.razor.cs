using Microsoft.AspNetCore.Components;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table
{
    public partial class TablePage
    {
        [Inject] private NavigationManager Navigation { get; set; } = null!;

        [Parameter]
        public int SelectIndexTab { get; set; } = TabTable.Company.ActiveTabIndex;

        private void ChangeTab() => Navigation.NavigateTo($"/table/{SelectIndexTab}");
    }
}

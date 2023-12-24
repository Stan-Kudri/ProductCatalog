using Microsoft.AspNetCore.Components;
using TestTask.MudBlazors.Model;

namespace TestTask.MudBlazors.Pages.Table
{
    public partial class TablePage
    {
        [Parameter]
        public int SelectIndexTab { get; set; } = TabTable.Company.ActiveTabIndex;
    }
}

using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.Model
{
    public interface IItemDialog
    {
        [Parameter] int? Id { get; set; }
    }
}

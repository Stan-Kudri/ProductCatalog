using Microsoft.AspNetCore.Components;

namespace TestTask.MudBlazors.Pages.Table.Model
{
    public interface IItemDialog
    {
#pragma warning disable BL0007 // Component parameters should be auto properties
        [Parameter] Guid? Id { get; set; }
#pragma warning restore BL0007 // Component parameters should be auto properties
    }
}

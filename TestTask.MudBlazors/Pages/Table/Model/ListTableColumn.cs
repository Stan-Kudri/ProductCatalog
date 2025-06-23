using TestTask.Core.Exeption;
using TestTask.Core.Models;

namespace TestTask.MudBlazors.Pages.Table.Model
{
    public class ListTableColumn
    {
        public ListTableColumn(string name, int widthValuePercent, Func<Entity, object> valueSelector)
        {
            BusinessLogicException.ThrowIfNullOrEmpty(name);
            BusinessLogicException.EnsureRangeMinValue(widthValuePercent, 0);
            BusinessLogicException.ThrowIfNull(valueSelector);

            Name = name;
            WidthValuePercent = widthValuePercent;
            ValueSelector = valueSelector;
        }

        public string Name { get; }

        public int WidthValuePercent { get; }

        public Func<Entity, object> ValueSelector { get; }
    }
}

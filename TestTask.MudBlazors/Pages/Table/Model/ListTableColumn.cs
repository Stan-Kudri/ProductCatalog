using TestTask.Core.Models;

namespace TestTask.MudBlazors.Pages.Table.Model
{
    public class ListTableColumn
    {
        public ListTableColumn(string name, int widthValuePercent, Func<Entity, object> valueSelector)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The column name cannot be empty.", nameof(name));
            }

            if (widthValuePercent <= 0)
            {
                throw new ArgumentException("The width is greater than zero.", nameof(widthValuePercent));
            }

            if (valueSelector == null)
            {
                throw new ArgumentNullException("ValueSelector should not be null");
            }

            Name = name;
            WidthValuePercent = widthValuePercent;
            ValueSelector = valueSelector;
        }

        public string Name { get; }

        public int WidthValuePercent { get; }

        public Func<Entity, object> ValueSelector { get; }
    }
}

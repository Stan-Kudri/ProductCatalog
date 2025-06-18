using System;
using TestTask.Core.Models;

namespace TestTask.Controls.PageTabControls.Model
{
    public class ListViewColumn
    {
        public ListViewColumn(string name, int width, Func<Entity, object> valueSelector)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The column name cannot be empty.", nameof(name));
            }

            if (width <= 0)
            {
                throw new ArgumentException("The width is greater than zero.", nameof(width));
            }

            if (valueSelector == null)
            {
                throw new ArgumentNullException("ValueSelector should not be null");
            }

            Name = name;
            Width = width;
            ValueSelector = valueSelector;
        }

        public string Name { get; }

        public int Width { get; }

        public Func<Entity, object> ValueSelector { get; }
    }
}

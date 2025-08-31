using System;
using ProductCatalog.Core.Models;

namespace ProductCatalog.Controls.PageTabControls.Model
{
    public class ListViewColumn
    {
        public ListViewColumn(string name, int width, Func<Entity, object> valueSelector)
        {
            ArgumentException.ThrowIfNullOrEmpty(name, nameof(name));
            ArgumentNullException.ThrowIfNull(valueSelector, nameof(valueSelector));

            if (width < 0)
            {
                throw new ArgumentException("The width is greater than zero.", nameof(width));
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

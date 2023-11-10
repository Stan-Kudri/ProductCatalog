using System;

namespace TestTask.Core.Models
{
    public class ColumnListView
    {
        private readonly string _nameColumn;
        private readonly int _width;

        public ColumnListView(string name, int width)
        {
            _nameColumn = name != string.Empty && name != null ? _nameColumn = name : throw new ArgumentException("The column name cannot be empty.", nameof(name));
            _width = width > 0 ? _width = width : throw new ArgumentException("The width is greater than zero.", nameof(width));
        }

        public string Name => _nameColumn;

        public int Width => _width;
    }
}

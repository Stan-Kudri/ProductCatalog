using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.DataTable;

namespace TestTask.Model
{
    public class SelectTableModel
    {
        protected HashSet<Tables> _selectTable = new HashSet<Tables>();

        public Tables Table { get; set; }

        public void Add(Tables table)
            => _selectTable.Add(table);

        public virtual HashSet<Tables> SelectTables
        {
            get => _selectTable;
            set => _selectTable = value;
        }
        public ObservableCollection<Tables> Items { get; set; } = new ObservableCollection<Tables>(Tables.List);
    }
}

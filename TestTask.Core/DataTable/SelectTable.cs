using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestTask.Core.DataTable
{
    public class SelectTable
    {
        protected IEnumerable<Tables> _selectTable = new HashSet<Tables>();

        public Tables Table { get; set; }

        public SelectTable()
        {
        }

        public virtual IEnumerable<Tables> SelectTables
        {
            get => _selectTable;
            set => _selectTable = value;
        }

        public ObservableCollection<Tables> Items { get; set; } = new ObservableCollection<Tables>(Tables.List);
    }
}

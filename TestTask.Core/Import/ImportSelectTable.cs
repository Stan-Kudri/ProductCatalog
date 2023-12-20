using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestTask.Core.Import
{
    public class ImportSelectTable
    {
        private IEnumerable<ImportTable> _selectTable = new HashSet<ImportTable>();

        public ImportTable importTable { get; set; }

        public ImportSelectTable()
        {
        }

        public virtual IEnumerable<ImportTable> SelectTable
        {
            get => _selectTable;
            set => _selectTable = value;
        }
        public ObservableCollection<ImportTable> Items { get; set; } = new ObservableCollection<ImportTable>(ImportTable.List);
    }
}

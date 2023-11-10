using System.Collections.Generic;

namespace TestTask.Core.Models
{
    public interface IListViewTableColumn
    {
        List<ColumnListView> Columns { get; set; }
    }
}

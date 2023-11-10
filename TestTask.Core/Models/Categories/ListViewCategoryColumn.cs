using System.Collections.Generic;

namespace TestTask.Core.Models.Categories
{
    public class ListViewCategoryColumn : IListViewTableColumn
    {
        public ListViewCategoryColumn() => SetDefaultValue();

        public List<ColumnListView> Columns { get; set; }

        private void SetDefaultValue()
        {
            Columns = new List<ColumnListView>()
            {
                new ColumnListView("ID", 200),
                new ColumnListView("Name", 555),
            };
        }
    }
}

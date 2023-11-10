using System.Collections.Generic;

namespace TestTask.Core.Models.Companies
{
    public class ListViewCompanyColumn : IListViewTableColumn
    {
        public ListViewCompanyColumn() => SetDefaultValue();

        public List<ColumnListView> Columns { get; set; }

        private void SetDefaultValue()
        {
            Columns = new List<ColumnListView>()
            {
                new ColumnListView("ID", 80),
                new ColumnListView("Name", 300),
                new ColumnListView("DateCreation", 195),
                new ColumnListView("Country", 180),
            };
        }
    }
}

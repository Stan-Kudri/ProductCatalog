using System.Collections.Generic;

namespace TestTask.Core.Models.Products
{
    public class ListViewProductsColumn : IListViewTableColumn
    {
        public ListViewProductsColumn() => SetDefaultValue();

        public List<ColumnListView> Columns { get; set; }

        private void SetDefaultValue()
        {
            Columns = new List<ColumnListView>()
            {
                new ColumnListView("ID", 50),
                new ColumnListView("Company", 140),
                new ColumnListView("Category", 110),
                new ColumnListView("Type", 150),
                new ColumnListView("Price", 90),
                new ColumnListView("Destination", 160),
                new ColumnListView("CompanyId", 0),
                new ColumnListView("CategoryId", 0),
            };
        }
    }
}

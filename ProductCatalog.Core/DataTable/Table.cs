using Ardalis.SmartEnum;

namespace ProductCatalog.Core.DataTable
{
    public class Table(string name, int value) : SmartEnum<Table>(name, value)
    {
        public static readonly Table Company = new("Company", 0);
        public static readonly Table Category = new("Category", 1);
        public static readonly Table TypeProduct = new("Type Product", 2);
        public static readonly Table Product = new("Product", 3);
    }
}

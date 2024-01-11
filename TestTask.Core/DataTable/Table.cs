using Ardalis.SmartEnum;

namespace TestTask.Core.DataTable
{
    public class Table : SmartEnum<Table>
    {
        public static readonly Table Company = new Table("Company", 0);
        public static readonly Table Category = new Table("Category", 1);
        public static readonly Table TypeProduct = new Table("Type Product", 2);
        public static readonly Table Product = new Table("Product", 3);

        public Table(string name, int value)
            : base(name, value)
        {
        }
    }
}

using Ardalis.SmartEnum;

namespace TestTask.Core.Import
{
    public class ImportTable : SmartEnum<ImportTable>
    {
        public static readonly ImportTable Company = new ImportTable("Company", 0);
        public static readonly ImportTable Category = new ImportTable("Category", 1);
        public static readonly ImportTable TypeProduct = new ImportTable("Type Product", 2);
        public static readonly ImportTable Product = new ImportTable("Product", 3);

        public ImportTable(string name, int value)
            : base(name, value)
        {
        }
    }
}

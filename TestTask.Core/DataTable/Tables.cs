using Ardalis.SmartEnum;

namespace TestTask.Core.DataTable
{
    public class Tables : SmartEnum<Tables>
    {
        public static readonly Tables Company = new("Company", 0);
        public static readonly Tables Category = new("Category", 1);
        public static readonly Tables TypeProduct = new("Type Product", 2);
        public static readonly Tables Product = new("Product", 3);

        public Tables(string name, int value)
            : base(name, value)
        {
        }
    }
}

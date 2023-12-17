using Ardalis.SmartEnum;

namespace TestTask.MudBlazors.Model
{
    public class TabTable : SmartEnum<TabTable>
    {
        public static readonly TabTable Company = new TabTable("Company", 0);
        public static readonly TabTable Category = new TabTable("Category", 1);
        public static readonly TabTable TypeProduct = new TabTable("Type Product", 2);
        public static readonly TabTable Product = new TabTable("Product", 3);

        public TabTable(string name, int value)
            : base(name, value)
        {

        }

        public int ActiveTabIndex => Value;
    }
}

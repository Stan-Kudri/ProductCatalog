using Ardalis.SmartEnum;

namespace TestTask.BindingItem.Pages
{
    public class TypeSortFields : SmartEnum<TypeSortFields>
    {
        public static TypeSortFields Unknown = new("Unknown", 0);
        public static TypeSortFields Ascending = new("↑", 1);
        public static TypeSortFields Descending = new("↓", 2);

        public TypeSortFields(string name, int value)
            : base(name, value)
        {
        }
    }
}

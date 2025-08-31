using Ardalis.SmartEnum;

namespace ProductCatalog.WinForms.BindingItem.Pages
{
    public class TypeSortFields(string name, int value) 
        : SmartEnum<TypeSortFields>(name, value)
    {
        public static TypeSortFields Unknown = new("Unknown", 0);
        public static TypeSortFields Ascending = new("↑", 1);
        public static TypeSortFields Descending = new("↓", 2);
    }
}

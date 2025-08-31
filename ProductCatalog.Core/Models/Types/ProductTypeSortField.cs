using ProductCatalog.Core.Models.SortModel;

namespace ProductCatalog.Core.Models.Types
{
    public class ProductTypeSortField(string name, int value, ISortableField<ProductType> field)
        : SortableSmartEnumField<ProductTypeSortField, ProductType>(name, value, field)
    {
        public static readonly ProductTypeSortField Id = new("Id", 0, CreateField(e => e.Id));
        public static new readonly ProductTypeSortField Name = new("Name", 1, CreateField(e => e.Name));
        public static readonly ProductTypeSortField Category = new("Category", 2, CreateField(e => e.Category));
    }
}

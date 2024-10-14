namespace TestTask.Core.Models.Types
{
    public class ProductTypeSortField : SortableSmartEnumField<ProductTypeSortField, ProductType>
    {
        public static readonly ProductTypeSortField Id = new ProductTypeSortField("Id", 0, CreateField(e => e.Id));
        public static readonly ProductTypeSortField Name = new ProductTypeSortField("Name", 1, CreateField(e => e.Name));
        public static readonly ProductTypeSortField Category = new ProductTypeSortField("Category", 2, CreateField(e => e.Category));

        public ProductTypeSortField(string name, int value, ISortableField<ProductType> field)
            : base(name, value, field)
        {
        }
    }
}

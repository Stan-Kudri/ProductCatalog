using TestTask.Core.Models.SortModel;

namespace TestTask.Core.Models.Products
{
    public class ProductSortField : SortableSmartEnumField<ProductSortField, Product>
    {
        public static readonly ProductSortField Id = new ProductSortField("Id", 0, CreateField(e => e.Id));
        public static readonly ProductSortField Name = new ProductSortField("Name", 1, CreateField(e => e.Name));
        public static readonly ProductSortField Company = new ProductSortField("Company", 2, CreateField(e => e.Company));
        public static readonly ProductSortField Category = new ProductSortField("Category", 3, CreateField(e => e.Category));
        public static readonly ProductSortField ProductType = new ProductSortField("Product Type", 4, CreateField(e => e.Type));
        public static readonly ProductSortField Price = new ProductSortField("Price", 5, CreateField(e => e.Price));

        private ProductSortField(string name, int value, ISortableField<Product> field)
            : base(name, value, field)
        {
        }
    }
}

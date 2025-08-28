using ProductCatalog.Core.Models.SortModel;

namespace ProductCatalog.Core.Models.Categories
{
    public class CategoriesSortField : SortableSmartEnumField<CategoriesSortField, Category>
    {
        public static readonly CategoriesSortField Id = new("Id", 0, CreateField(e => e.Id));
        public static new readonly CategoriesSortField Name = new("Name", 1, CreateField(e => e.Name));

        private CategoriesSortField(string name, int value, ISortableField<Category> field)
            : base(name, value, field)
        {
        }
    }
}

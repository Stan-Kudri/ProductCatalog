namespace TestTask.Core.Models.Categories
{
    public class CategoriesSortField : SortableSmartEnumField<CategoriesSortField, Category>
    {
        public static readonly CategoriesSortField Id = new CategoriesSortField("Id", 0, CreateField(e => e.Id));
        public static readonly CategoriesSortField Name = new CategoriesSortField("Name", 1, CreateField(e => e.Name));

        private CategoriesSortField(string name, int value, ISortableField<Category> field)
            : base(name, value, field)
        {
        }
    }
}

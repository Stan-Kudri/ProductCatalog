using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Pages.Table.PageTableProvider
{
    public class CategoryDetailProvider : ITableDetailProvider<Category>
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryDetailProvider
            (CategoryRepository categoryRepository,
            ProductRepository productRepository,
            ProductTypeRepository productTypeRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("ID", 25, e => ((Category)e).Id),
            new ListTableColumn("Name", 35, e => ((Category)e).Name),
        };

        public IQueryable<Category> GetQueryableAll()
            => _categoryRepository.GetQueryableAll();

        public IQueryable<Category> GetSearchName(IQueryable<Category> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString));

        public void Remove(int id) => _categoryRepository.Remove(id);

        public void Upsert(Category entity) => _categoryRepository.Upsert(entity);
    }
}

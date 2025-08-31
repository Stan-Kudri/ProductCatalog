using ProductCatalog.Core.Models.Categories;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Pages.Table.PageTableProvider
{
    public class CategoryDetailProvider(CategoryService categoryService) 
        : ITableDetailProvider<Category>
    {
        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("Name", 80, e => ((Category)e).Name),
        };

        public IQueryable<Category> GetQueryableAll()
            => categoryService.GetQueryableAll();

        public IQueryable<Category> GetSearchName(IQueryable<Category> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString));

        public async Task Remove(Guid id) => await categoryService.RemoveAsync(id);

        public async Task Upsert(Category entity) => await categoryService.UpsertAsync(entity);
    }
}

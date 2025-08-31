using ProductCatalog.Core.Models.Types;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Pages.Table.PageTableProvider
{
    public class TypeDetailProvider(ProductTypeService productTypeService)
        : ITableDetailProvider<ProductType>
    {
        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("Name", 30, e => ((ProductType)e).Name),
            new ListTableColumn("Category", 35, e => ((ProductType)e).Category),
        };

        public IQueryable<ProductType> GetQueryableAll()
            => productTypeService.GetQueryableAll();

        public IQueryable<ProductType> GetSearchName(IQueryable<ProductType> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString));

        public async Task Remove(Guid id) => await productTypeService.RemoveAsync(id);

        public async Task Upsert(ProductType entity) => await productTypeService.UpsertAsync(entity);
    }
}

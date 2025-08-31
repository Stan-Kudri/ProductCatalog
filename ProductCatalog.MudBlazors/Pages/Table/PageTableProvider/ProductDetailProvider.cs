using System.Globalization;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.MudBlazors.Pages.Table.Model;

namespace ProductCatalog.MudBlazors.Pages.Table.PageTableProvider
{
    public class ProductDetailProvider(ProductService productService)
        : ITableDetailProvider<Product>
    {
        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("Name", 20, e => ((Product)e).Name),
            new ListTableColumn("Company", 15, e => ((Product)e).Company),
            new ListTableColumn("Category", 15, e => ((Product)e).Category),
            new ListTableColumn("Type", 15, e => ((Product)e).Type),
            new ListTableColumn("Price", 15, e => ((Product)e).Price),
        };

        public IQueryable<Product> GetQueryableAll()
            => productService.GetQueryableAll();

        public IQueryable<Product> GetSearchName(IQueryable<Product> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Company.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString)
                                || e.Type.Name.Contains(searchString)
                                || e.Price.ToString(CultureInfo.InvariantCulture).Contains(searchString));

        public async Task Remove(Guid id) => await productService.RemoveAsync(id);

        public async Task Upsert(Product entity) => await productService.UpsertAsync(entity);
    }
}

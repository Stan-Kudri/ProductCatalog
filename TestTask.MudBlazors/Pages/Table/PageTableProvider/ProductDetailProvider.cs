using System.Globalization;
using TestTask.Core.Models.Products;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Pages.Table.PageTableProvider
{
    public class ProductDetailProvider : ITableDetailProvider<Product>
    {
        private readonly ProductRepository _productRepository;

        public ProductDetailProvider(ProductRepository productRepository)
            => _productRepository = productRepository;

        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("ID", 5, e => ((Product)e).Id),
            new ListTableColumn("Name", 15, e => ((Product)e).Name),
            new ListTableColumn("Company", 15, e => ((Product)e).Company),
            new ListTableColumn("Category", 15, e => ((Product)e).Category),
            new ListTableColumn("Type", 15, e => ((Product)e).Type),
            new ListTableColumn("Price", 15, e => ((Product)e).Price),
        };

        public IQueryable<Product> GetQueryableAll()
            => _productRepository.GetQueryableAll();

        public IQueryable<Product> GetSearchName(IQueryable<Product> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Company.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString)
                                || e.Type.Name.Contains(searchString)
                                || e.Price.ToString(CultureInfo.InvariantCulture).Contains(searchString));

        public void Remove(int id) => _productRepository.Remove(id);

        public void Upsert(Product entity) => _productRepository.Upsert(entity);
    }
}

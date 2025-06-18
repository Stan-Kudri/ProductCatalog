using TestTask.Core.Models.Types;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Pages.Table.PageTableProvider
{
    public class TypeDetailProvider : ITableDetailProvider<ProductType>
    {
        private readonly ProductTypeRepository _typeRepository;

        public TypeDetailProvider(ProductTypeRepository productTypeRepository)
            => _typeRepository = productTypeRepository;

        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("ID", 10, e => ((ProductType)e).Id),
            new ListTableColumn("Name", 25, e => ((ProductType)e).Name),
            new ListTableColumn("Category", 35, e => ((ProductType)e).Category),
        };

        public IQueryable<ProductType> GetQueryableAll()
            => _typeRepository.GetQueryableAll();

        public IQueryable<ProductType> GetSearchName(IQueryable<ProductType> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Category.Name.Contains(searchString));

        public void Remove(int id) => _typeRepository.Remove(id);

        public void Upsert(ProductType entity) => _typeRepository.Upsert(entity);
    }
}

using System.Globalization;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.MudBlazors.Pages.Table.Model;

namespace TestTask.MudBlazors.Pages.Table.PageTableView
{
    public class CompanyDetailProvider : ITableDetailProvider<Company>
    {
        private readonly CompanyRepository _companyRepository;
        private readonly ProductRepository _productRepository;

        public CompanyDetailProvider(CompanyRepository companyRepository, ProductRepository productRepository)
        {
            _companyRepository = companyRepository;
            _productRepository = productRepository;
        }

        public IReadOnlyList<ListTableColumn> Columns => new List<ListTableColumn>
        {
            new ListTableColumn("ID", 5, e => ((Company)e).Id),
            new ListTableColumn("Name", 10, e => ((Company)e).Name),
            new ListTableColumn("DateCreation", 15, e => ((Company)e).DateCreation.ToString("d")),
            new ListTableColumn("Country", 25, e => ((Company)e).Country),
        };

        public IQueryable<Company> GetQueryableAll()
            => _companyRepository.GetQueryableAll();

        public IQueryable<Company> GetSearchName(IQueryable<Company> items, string? searchString)
            => string.IsNullOrEmpty(searchString)
                ? items
                : items.Where(e => e.Name.Contains(searchString)
                                || e.Country.Contains(searchString)
                                || e.DateCreation.ToString(CultureInfo.InvariantCulture).Contains(searchString));

        public void Remove(int id)
        {
            _productRepository.RemoveProductRelatedToCompany(id);
            _companyRepository.Remove(id);
        }

        public void Upsert(Company entity)
            => _companyRepository.Upsert(entity);
    }
}

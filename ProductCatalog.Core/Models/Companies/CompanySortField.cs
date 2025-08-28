using ProductCatalog.Core.Models.SortModel;

namespace ProductCatalog.Core.Models.Companies
{

    public class CompanySortField : SortableSmartEnumField<CompanySortField, Company>
    {
        public static readonly CompanySortField Id = new("Id", 0, CreateField(e => e.Id));
        public static readonly CompanySortField Name = new("Name", 1, CreateField(e => e.Name));
        public static readonly CompanySortField Country = new("Country", 2, CreateField(e => e.Country));
        public static readonly CompanySortField DataCreate = new("DataCreate", 3, CreateField(e => e.DateCreation));

        private CompanySortField(string name, int value, ISortableField<Company> field)
            : base(name, value, field)
        {
        }
    }
}

namespace TestTask.Core.Models.Companies
{

    public class CompanySortField : SortableSmartEnumField<CompanySortField, Company>
    {
        public static readonly CompanySortField Id = new CompanySortField("Id", 0, CreateField(e => e.Id));
        public static readonly CompanySortField Name = new CompanySortField("Name", 1, CreateField(e => e.Name));
        public static readonly CompanySortField Country = new CompanySortField("Country", 2, CreateField(e => e.Country));
        public static readonly CompanySortField DataCreate = new CompanySortField("DataCreate", 3, CreateField(e => e.DateCreation));

        private CompanySortField(string name, int value, ISortableField<Company> field)
            : base(name, value, field)
        {
        }
    }
}

using System;
using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.Core.Import.Importers.Model
{
    public class CompanyImporter : BaseImporter<Company, CompanyField>
    {
        public override bool IsModelSheet(string sheetName)
            => sheetName.Equals(typeof(Company).Name, StringComparison.OrdinalIgnoreCase);
    }
}

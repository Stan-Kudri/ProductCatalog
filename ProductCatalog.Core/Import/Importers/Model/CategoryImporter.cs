using System;
using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.Core.Import.Importers.Model
{
    public class CategoryImporter : BaseImporter<Category, CategoryField>
    {
        public override bool IsModelSheet(string sheetName)
            => sheetName.Equals(typeof(Category).Name, StringComparison.OrdinalIgnoreCase);
    }
}

using System;
using TestTask.Core.Models.Products;

namespace TestTask.Core.Import.Importers.Model
{
    public class ProductImporter : BaseImporter<Product, ProductField>
    {
        public override bool IsModelSheet(string sheetName)
            => sheetName.Equals(typeof(Product).Name, StringComparison.OrdinalIgnoreCase);
    }
}

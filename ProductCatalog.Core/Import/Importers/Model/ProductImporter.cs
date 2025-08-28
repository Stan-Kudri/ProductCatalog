using System;
using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Core.Import.Importers.Model
{
    public class ProductImporter : BaseImporter<Product, ProductField>
    {
        public override bool IsModelSheet(string sheetName)
            => sheetName.Equals(typeof(Product).Name, StringComparison.OrdinalIgnoreCase);
    }
}

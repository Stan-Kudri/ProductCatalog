using System;
using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.Core.Import.Importers.Model
{
    public class TypeProductImporter : BaseImporter<ProductType, ProductTypeField>
    {
        public override bool IsModelSheet(string sheetName)
            => sheetName.Equals(typeof(ProductType).Name, StringComparison.OrdinalIgnoreCase);
    }
}

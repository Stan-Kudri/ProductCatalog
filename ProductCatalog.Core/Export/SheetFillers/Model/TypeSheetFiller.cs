using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class TypeSheetFiller : SheetFiller<ProductType, ProductTypeField>
    {
        public TypeSheetFiller(ProductTypeService service) : base(service)
        {
        }
    }
}

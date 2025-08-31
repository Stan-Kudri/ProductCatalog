using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class TypeSheetFiller(ProductTypeService service) : SheetFiller<ProductType, ProductTypeField>(service)
    {
    }
}

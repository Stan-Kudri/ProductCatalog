using TestTask.Core.Models.Types;

namespace TestTask.Core.Export.SheetFillers.Model
{
    public class TypeSheetFiller : SheetFiller<ProductType, ProductTypeField>
    {
        public TypeSheetFiller(ProductTypeService service) : base(service)
        {
        }
    }
}

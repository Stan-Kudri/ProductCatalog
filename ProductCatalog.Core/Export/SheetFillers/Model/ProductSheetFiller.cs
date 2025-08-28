using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class ProductSheetFiller : SheetFiller<Product, ProductField>
    {
        public ProductSheetFiller(ProductService service) : base(service)
        {
        }
    }
}

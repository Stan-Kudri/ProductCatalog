using ProductCatalog.Core.Models.Products;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class ProductSheetFiller(ProductService service) : SheetFiller<Product, ProductField>(service)
    {
    }
}

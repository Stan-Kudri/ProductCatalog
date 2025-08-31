using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class CategorySheetFiller(CategoryService service) : SheetFiller<Category, CategoryField>(service)
    {
    }
}

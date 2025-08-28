using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.Core.Export.SheetFillers.Model
{
    public class CategorySheetFiller : SheetFiller<Category, CategoryField>
    {
        public CategorySheetFiller(CategoryService service) : base(service)
        {
        }
    }
}

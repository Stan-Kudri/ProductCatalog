using TestTask.Core.Models.Categories;

namespace TestTask.Core.Export.SheetFillers.Model
{
    public class CategorySheetFiller : SheetFiller<Category, CategoryField>
    {
        public CategorySheetFiller(CategoryService service) : base(service)
        {
        }
    }
}

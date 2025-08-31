using System;
using ProductCatalog.WinForms.Forms.Categories;

namespace ProductCatalog.WinForms.Forms.Categories
{
    public class AddCategoryForm : CategoryFormBase
    {
        public AddCategoryForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Add Category";
    }
}

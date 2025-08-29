using System;

namespace ProductCatalog.Forms.Categories
{
    public class AddCategoryForm : CategoryFormBase
    {
        public AddCategoryForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Add Category";
    }
}

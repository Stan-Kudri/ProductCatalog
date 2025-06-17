using System;

namespace TestTask.Forms.Categories
{
    public class AddCategoryForm : CategoryFormBase
    {
        public AddCategoryForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Add Category";
    }
}

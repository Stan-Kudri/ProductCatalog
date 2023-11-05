using System;

namespace TestTask.Forms.CategoryForm
{
    public class AddCategoryForm : CategoryFormBase
    {
        public AddCategoryForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Add Category";
    }
}

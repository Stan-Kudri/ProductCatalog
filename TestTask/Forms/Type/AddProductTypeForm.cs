using System;
using System.Collections.Generic;
using TestTask.BindingItem.ObservableCollection;
using TestTask.Core.Models.Categories;

namespace TestTask.Forms.Type
{
    public partial class AddProductTypeForm : ProductTypeBaseForm
    {
        public AddProductTypeForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Type";
        }

        public void Initialize(List<Category> category)
        {
            _categories = new SelectCategory(category);
        }
    }
}

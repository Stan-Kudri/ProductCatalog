using System;
using System.Collections.Generic;
using ProductCatalog.BindingItem.ObservableCollection;
using ProductCatalog.Core.Models.Categories;

namespace ProductCatalog.Forms.Type
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

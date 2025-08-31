using System;
using System.Collections.Generic;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.WinForms.BindingItem.ObservableCollection;

namespace ProductCatalog.WinForms.Forms.Type
{
    public partial class AddProductTypeForm : ProductTypeBaseForm
    {
        public AddProductTypeForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Add Type";

        public void Initialize(List<Category> category)
            => _categories = new SelectCategory(category);
    }
}

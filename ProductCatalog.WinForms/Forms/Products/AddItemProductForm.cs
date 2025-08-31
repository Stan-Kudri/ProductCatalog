using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.WinForms.BindingItem.ObservableCollection;
using System;
using System.Collections.Generic;

namespace ProductCatalog.WinForms.Forms.Products
{
    public class AddItemProductForm : ProductFormBase
    {
        public AddItemProductForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Add Product";

        public void Initialize(List<Company> company, List<Category> category, List<ProductType> types)
        {
            _companies = new SelectCompany(company);
            _categories = new SelectCategory(category);
            _types = new SelectType(types);
            _categories.ChangedCategory += ReplaceTypeProduct;
        }
    }
}

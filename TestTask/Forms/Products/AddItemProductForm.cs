using System;
using System.Collections.Generic;
using TestTask.BindingItem.ObservableCollection;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Forms.Products
{
    public class AddItemProductForm : ProductFormBase
    {
        public AddItemProductForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Product";
        }

        public void Initialize(List<Company> company, List<Category> category, List<ProductType> types)
        {
            _companies = new SelectCompany(company);
            _categories = new SelectCategory(category);
            _types = new SelectType(types);
            _categories.ChangedCategory += ReplaceTypeProduct;
        }
    }
}

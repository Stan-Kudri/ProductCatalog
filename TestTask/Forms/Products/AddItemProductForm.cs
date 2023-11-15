using System;
using System.Collections.Generic;
using TestTask.BindingItem.ObservableCollection;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;

namespace TestTask.Forms.Products
{
    public class AddItemProductForm : ProductFormBase
    {
        public AddItemProductForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Product";
        }

        public void Initialize(List<Company> company, List<Category> category)
        {
            _companies = new SelectCompany(company);
            _categories = new SelectCategory(category);
        }
    }
}

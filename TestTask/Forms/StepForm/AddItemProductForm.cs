using System;
using System.Collections.Generic;
using TestTask.BindingItem.UserBinding.ProductBinding;
using TestTask.Core.Models.Companies;

namespace TestTask.Forms.StepForm
{
    public class AddItemProductForm : ProductFormBase
    {
        public AddItemProductForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Product";
        }

        public void Initialize(List<Company> company) => _companies = new SelectCompany(company);
    }
}

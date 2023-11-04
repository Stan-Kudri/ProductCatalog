using System;
using System.Collections.Generic;
using TestTask.BindingItem.UserBinding.StepBinding;
using TestTask.Core.Models.Company;

namespace TestTask.Forms.StepForm
{
    public class AddItemStepForm : StepFormBase
    {
        public AddItemStepForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Step";
        }

        public void Initialize(List<Company> company) => _companies = new SelectCompany(company);
    }
}

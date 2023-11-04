using System;

namespace TestTask.Forms.CompanyForm
{
    public class AddItemCompanyForm : CompanyFormBase
    {
        public AddItemCompanyForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Add Company";
        }

    }
}

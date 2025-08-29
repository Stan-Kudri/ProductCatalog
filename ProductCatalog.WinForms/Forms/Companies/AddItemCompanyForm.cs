using System;

namespace ProductCatalog.Forms.Companies
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

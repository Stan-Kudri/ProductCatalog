using System;
using System.Windows.Forms;
using TestTask.Core.Models.Companies;

namespace TestTask.Forms.Companies
{
    public class EditItemCompanyForm : CompanyFormBase
    {
        private Company _oldCompany;
        private Company _editCompany;
        private bool _сhangedName = false;

        public EditItemCompanyForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Edit Company";
        }

        public void Initialize(Company company) => _oldCompany = company;

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if (tbNameCompany.Text == string.Empty)
            {
                _messageBox.ShowWarning("Fill in the field Name");
                return;
            }

            if (tbContry.Text == string.Empty)
            {
                _messageBox.ShowWarning("Enter the company's country.");
            }

            _editCompany = GetCompanyModel().ToCompany(_oldCompany.Id);
            if (_oldCompany.Equals(_editCompany))
            {
                _messageBox.ShowInfo("The company has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            _сhangedName = _editCompany.Name != _oldCompany.Name;
            DialogResult = DialogResult.OK;
        }

        protected override void DefaultValue()
        {
            tbNameCompany.Text = _oldCompany.Name;
            tbContry.Text = _oldCompany.Country;
            dtpCreateCompany.MaxDate = DateTime.Now;
            dtpCreateCompany.Value = _oldCompany.DateCreation;
        }

        public Company GetEditCompany() => _editCompany;

        public bool ChangedCompanyName() => _сhangedName;
    }
}

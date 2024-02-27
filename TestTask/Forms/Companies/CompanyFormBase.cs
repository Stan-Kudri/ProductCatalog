using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.Core;
using TestTask.Core.Models.Companies;

namespace TestTask.Forms.Companies
{
    public partial class CompanyFormBase : BaseForm
    {
        protected readonly IMessageBox _messageBox;
        protected readonly CompanyRepository _companyRepository;

        private CompanyFormBase()
        {
            InitializeComponent();
        }

        public CompanyFormBase(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
            _companyRepository = serviceProvider.GetRequiredService<CompanyRepository>();
        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
            var nameCompany = tbNameCompany.Text;

            if (nameCompany == string.Empty)
            {
                _messageBox.ShowWarning("Fill in the field Name");
                return;
            }

            if (!_companyRepository.IsFreeName(nameCompany))
            {
                _messageBox.ShowWarning("Name company is not free.");
                return;
            }

            if (tbContry.Text == string.Empty)
            {
                _messageBox.ShowWarning("Enter the company's country.");
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e) => DefaultValue();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected virtual void AddModeForm_Load(object sender, EventArgs e) => DefaultValue();

        protected virtual void DefaultValue()
        {
            tbNameCompany.Text = string.Empty;
            tbContry.Text = "Belarus";
            var dateNow = DateTime.Now;
            dtpCreateCompany.MaxDate = dateNow;
            dtpCreateCompany.Value = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
        }

        public CompanyModel GetCompanyModel()
        {
            if (tbNameCompany.Text == string.Empty)
            {
                throw new Exception("The name company field is empty.");
            }

            if (tbContry.Text == string.Empty)
            {
                throw new Exception("The country field is empty.");
            }

            if (dtpCreateCompany.Value == null)
            {
                throw new Exception("Error in date selection.");
            }

            return new CompanyModel(tbNameCompany.Text, dtpCreateCompany.Value, tbContry.Text);
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding;
using TestTask.Core;

namespace TestTask.Forms.CompanyForm
{
    public partial class CompanyFormBase : BaseForm
    {
        protected readonly IMessageBox _messageBox;

        private CompanyFormBase()
        {
            InitializeComponent();
        }

        public CompanyFormBase(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            DefaultValue();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
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

        private void TbMaxBottle_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

        private void TbMaxUsedType_KeyPress(object sender, KeyPressEventArgs e) => KeyPressDigit(e);

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

        private void KeyPressDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem.UserBinding.ProductBinding;
using TestTask.Core;
using TestTask.Core.Models.Companies;

namespace TestTask.Forms.StepForm
{
    public partial class ProductFormBase : BaseForm
    {
        protected readonly IMessageBox _messageBox;

        protected SelectCompany _companies;

        private ProductFormBase()
        {
            InitializeComponent();
        }

        public ProductFormBase(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        protected Company SelectedCompany =>
            cmbCompanyValue.SelectedValue != null ? (Company)cmbCompanyValue.SelectedValue : throw new Exception("Wrong combo box format");

        protected virtual void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e) => SetDefaultValueData();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected virtual void AddStepForm_Load(object sender, EventArgs e)
        {
            selectCompanyBindingSource.DataSource = _companies.Items;
            SetDefaultValueData();
        }

        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        protected virtual void SetDefaultValueData()
        {
            cmbCompanyValue.SelectedItem = _companies.Company;
            tbCategory.Text = string.Empty;
            tbType.Text = string.Empty;
            tbPrice.Text = "0";
            tbDestination.Text = string.Empty;
        }

        protected bool IsDataFilled(out string message)
        {
            if (cmbCompanyValue.Text.Length <= 0)
            {
                message = "Select your company.";
                return false;
            }

            if (tbCategory.Text.Length == decimal.Zero)
            {
                message = "Please enter a Category.";
                return false;
            }

            if (tbType.Text.Length == decimal.Zero)
            {
                message = "Please enter a Type.";
                return false;
            }

            if (tbPrice.Text.Length == decimal.Zero)
            {
                message = "Please enter a Price.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        public ProductModel GetStepModel()
        {
            if (tbCategory.Text == string.Empty)
            {
                throw new Exception("The Category field is filled in incorrectly.");
            }

            if (tbType.Text == string.Empty)
            {
                throw new Exception("The Type field is filled in incorrectly.");
            }

            if (!decimal.TryParse(tbPrice.Text, out var price))
            {
                throw new Exception("The Price field is filled in incorrectly.");
            }

            return new ProductModel(SelectedCompany, tbCategory.Text, tbType.Text, price, tbDestination.Text);
        }
    }
}

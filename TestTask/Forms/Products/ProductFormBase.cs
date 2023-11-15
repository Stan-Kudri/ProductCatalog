using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem.ObservableCollection;
using TestTask.BindingItem.UserBinding;
using TestTask.Core;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using ProductType = TestTask.Core.Models.Types.ProductType;

namespace TestTask.Forms.Products
{
    public partial class ProductFormBase : BaseForm
    {
        protected readonly IMessageBox _messageBox;

        protected SelectCompany _companies;
        protected SelectCategory _categories;
        protected SelectType _types;

        private ProductFormBase()
            => InitializeComponent();

        public ProductFormBase(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }

        protected Company SelectedCompany =>
            cmbCompanyValue.SelectedValue != null ? (Company)cmbCompanyValue.SelectedValue : throw new Exception("Wrong combo box format");

        protected Category SelectedCategory =>
            cmbCategoryValue.SelectedValue != null ? (Category)cmbCategoryValue.SelectedValue : throw new Exception("Wrong combo box format");

        protected ProductType SelectedType =>
            cmbTypeValue.SelectedValue != null ? (ProductType)cmbTypeValue.SelectedValue : throw new Exception("Wrong combo box format");

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
            companyBindingSource.DataSource = _companies.Items;
            categoryBindingSource.DataSource = _categories.Items;
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
            cmbCategoryValue.SelectedItem = _categories.Category;
            cmbTypeValue.SelectedItem = _types.Type;
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

            if (cmbCategoryValue.Text.Length <= 0)
            {
                message = "Select your category.";
                return false;
            }

            if (cmbTypeValue.Text.Length <= 0)
            {
                message = "Select your type.";
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

        public ProductModel GetProductModel()
        {
            if (!decimal.TryParse(tbPrice.Text, out var price))
            {
                throw new Exception("The Price field is filled in incorrectly.");
            }

            return new ProductModel(SelectedCompany, SelectedCategory, SelectedType, price, tbDestination.Text);
        }
    }
}

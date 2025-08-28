using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.BindingItem.DBItemModel;
using ProductCatalog.BindingItem.ObservableCollection;
using ProductCatalog.Core;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.Forms.Products
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

        private Company SelectedCompany =>
            cmbCompanyValue.SelectedValue != null ? (Company)cmbCompanyValue.SelectedValue : throw new BusinessLogicException("Wrong combo box format");

        private Category SelectedCategory =>
            cmbCategoryValue.SelectedValue != null ? (Category)cmbCategoryValue.SelectedValue : throw new BusinessLogicException("Wrong combo box format");

        private ProductType SelectedType =>
            cmbTypeValue.SelectedValue != null ? (ProductType)cmbTypeValue.SelectedValue : throw new BusinessLogicException("Wrong combo box format");

        protected virtual async void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                await _messageBox.ShowInfo(message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e) => SetDefaultValueData();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            _categories.ChangedCategory -= ReplaceTypeProduct;
            Close();
        }

        private void CmbCategoryValue_Changed(object sender, EventArgs e)
        {
            var category = (Category)cmbCategoryValue.SelectedItem;

            if (category != null)
            {
                _categories.Category = category;
                SetTypeProductSelector();
            }
        }

        protected virtual void AddForm_Load(object sender, EventArgs e)
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

        private void SetTypeProductSelector()
        {
            _types.SetItemsByCategory(_categories.Category);
            cmbTypeValue.Enabled = _types.ItemsByCategory != null && _types.ItemsByCategory.Count > 0;

            if (cmbTypeValue.Enabled)
            {
                itemsBindingSourceTypes.DataSource = _types.ItemsByCategory;
            }
        }

        protected virtual void SetDefaultValueData()
        {
            tbName.Text = string.Empty;
            cmbCompanyValue.SelectedItem = _companies.Company;
            cmbCategoryValue.SelectedItem = _categories.Category;
            SetTypeProductSelector();
            tbPrice.Text = "0";
            tbDestination.Text = string.Empty;
        }

        protected bool IsDataFilled(out string message)
        {
            if (tbName.Text == string.Empty || tbName.Text == null)
            {
                message = "Please entr name product.";
                return false;
            }

            if (cmbCompanyValue.Text.Length <= decimal.Zero)
            {
                message = "Select your company.";
                return false;
            }

            if (cmbCategoryValue.Text.Length <= decimal.Zero)
            {
                message = "Select your category.";
                return false;
            }

            if (cmbTypeValue.Text.Length <= decimal.Zero)
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

        protected void ReplaceTypeProduct(List<ProductType> itmes)
        {
            var typeProduct = _types.Items.Where(e => e.Category == _categories.Category).ToList();
            _types.ReplaceCollection(typeProduct);
        }

        public ProductModel GetProductModel()
            => !decimal.TryParse(tbPrice.Text, out var price)
                ? throw new BusinessLogicException("The Price field is filled in incorrectly.")
                : new ProductModel(tbName.Text, SelectedCompany, SelectedCategory, SelectedType, price, tbDestination.Text);
    }
}

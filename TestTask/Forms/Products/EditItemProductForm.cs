using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.BindingItem.ObservableCollection;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.Forms.Products
{
    public class EditItemProductForm : ProductFormBase
    {
        private Product _oldItem;
        private Product _editItem;

        public EditItemProductForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Edit Product";
        }

        public void Initialize(List<Company> company, List<Category> categories, List<ProductType> types, Product oldItem)
        {
            _companies = new SelectCompany(company);
            _categories = new SelectCategory(categories);
            _types = new SelectType(types);
            _oldItem = oldItem;
            _categories.ChangedCategory += ReplaceTypeProduct;
        }

        protected override async void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                await _messageBox.ShowInfo(message);
                return;
            }

            _editItem = GetProductModel().ToProduct(_oldItem.Id);
            if (!_oldItem.Equals(_editItem))
            {
                await _messageBox.ShowInfo("The product has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            DialogResult = DialogResult.OK;
        }

        protected override void AddForm_Load(object sender, EventArgs e)
        {
            tbName.Text = _oldItem.Name;
            companyBindingSource.DataSource = _companies.Items;
            categoryBindingSource.DataSource = _categories.Items;
            itemsBindingSourceTypes.DataSource = _types.Items;
            _companies.SetValueCompany(_oldItem.CompanyId);
            _categories.SetValueCategory(_oldItem.CategoryId);
            _types.SetValueType(_oldItem.TypeId);
            SetDefaultValueData();
        }

        protected override void SetDefaultValueData()
        {
            tbName.Text = _oldItem.Name;
            cmbCompanyValue.SelectedItem = _companies.Company;
            cmbCategoryValue.SelectedItem = _categories.Category;
            cmbTypeValue.SelectedItem = _types.Type;
            tbPrice.Text = _oldItem.Price.ToString();
            tbDestination.Text = _oldItem.Destination;
        }

        public Product GetEditProduct() => _editItem;
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTask.BindingItem.ObservableCollection;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;

namespace TestTask.Forms.Type
{
    public partial class EditProductTypeForm : ProductTypeBaseForm
    {

        private ProductType _oldItem;
        private ProductType _editItem;

        public EditProductTypeForm(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Text = "Edit Type";
        }

        public void Initialize(List<Category> category, ProductType oldItem)
        {
            _categories = new SelectCategory(category);
            _oldItem = oldItem;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            _editItem = GetTypeProductModel().ToProductType(_oldItem.Id);
            if (!_oldItem.Equals(_editItem))
            {
                _messageBox.ShowInfo("The product has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            DialogResult = DialogResult.OK;
        }

        protected override void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void TypeBaseForm_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = _categories.Items;
            SetDefaultValueData();
        }

        protected override void SetDefaultValueData()
        {
            _categories.SetValueCategory(_oldItem.CategoryId);
            cmbListCategory.SelectedItem = _categories.Category;
            tbName.Text = _oldItem.Name;
        }

        public ProductType GetEditTypeProduct() => _editItem;
    }
}

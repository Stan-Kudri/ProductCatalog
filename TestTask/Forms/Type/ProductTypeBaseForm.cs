using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.BindingItem;
using TestTask.BindingItem.ObservableCollection;
using TestTask.Core;
using TestTask.Core.Models.Categories;

namespace TestTask.Forms.Type
{
    public partial class ProductTypeBaseForm : BaseForm
    {
        protected IMessageBox _messageBox;

        protected SelectCategory _categories;

        public ProductTypeBaseForm() => InitializeComponent();

        public ProductTypeBaseForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
        }
        protected Category SelectedCategory =>
            cmbListCategory.SelectedValue != null ? (Category)cmbListCategory.SelectedValue : throw new Exception("Wrong combo box format");

        private void BtnSave_Click(object sender, EventArgs e)
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

        protected virtual void SetDefaultValueData()
        {
            cmbListCategory.SelectedItem = _categories.Category;
            tbName.Text = string.Empty;
        }

        protected bool IsDataFilled(out string message)
        {
            if (cmbListCategory.Text.Length <= 0)
            {
                message = "Select your category.";
                return false;
            }

            if (tbName.Text.Length == 0)
            {
                message = "Please enter a name type.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        public ProductTypeModel GetProductModel()
        {
            var name = tbName.Text;

            if (name == string.Empty || name == null)
            {
                throw new Exception("The name type field is filled in incorrectly.");
            }

            return new ProductTypeModel(name, SelectedCategory);
        }
    }
}

using System;
using System.Windows.Forms;
using TestTask.Core.Models.Categories;

namespace TestTask.Forms.CategoryForm
{
    public class EditCategoryForm : CategoryFormBase
    {
        private Category _oldItem;
        private Category _editItem;

        public EditCategoryForm(IServiceProvider serviceProvider)
            : base(serviceProvider) => Text = "Edit Category";

        public void Initialize(Category oldItem) => _oldItem = oldItem;

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                _messageBox.ShowInfo(message);
                return;
            }

            _editItem = GetCategoryModel().ToCategory(_oldItem.Id);
            if (_oldItem.Equals(_editItem))
            {
                _messageBox.ShowInfo("The category has not been modified.");
                DialogResult = DialogResult.Cancel;
            }

            DialogResult = DialogResult.OK;
        }

        protected override void SetDefaultValueData()
        {
            tbCategory.Text = _oldItem.Name;
        }

        public Category EditItem() => _editItem;
    }
}

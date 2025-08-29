using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.BindingItem.DBItemModel;
using ProductCatalog.Core;
using ProductCatalog.Core.Exeption;

namespace ProductCatalog.Forms.Categories
{
    public partial class CategoryFormBase : BaseForm
    {
        private readonly IServiceProvider _serviceProvider;

        protected readonly IMessageBox _messageBox;

        private CategoryFormBase() => InitializeComponent();

        public CategoryFormBase(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
        }

        protected void FormBase_Load(object sender, EventArgs e) => SetDefaultValueData();

        protected void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected void BtnClear_Click(object sender, EventArgs e) => SetDefaultValueData();

        protected virtual async void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataFilled(out var message))
            {
                await _messageBox.ShowWarning(message);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        protected virtual void SetDefaultValueData() => tbCategory.Text = string.Empty;

        protected bool IsDataFilled(out string message)
        {
            if (tbCategory.Text.Length == decimal.Zero)
            {
                message = "Please enter a Category.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        public CategoryModel GetItemModel()
            => tbCategory.Text == string.Empty
                ? throw new BusinessLogicException("The Category field is filled in incorrectly.")
                : new CategoryModel(tbCategory.Text);
    }
}

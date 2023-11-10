using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Forms.Categories;

namespace TestTask.Control.CategoryCantrol
{
    public partial class TabPageCategoryUserControl : BaseUserControl
    {
        private const string MessageNotSelectedItem = "No items selected";
        private const int NoItemsSelected = 0;

        //Index column from ListView
        private const int IndexId = 0;
        private const int IndexColumnCompanyName = 1;

        private IServiceProvider _serviceProvider;
        private IMessageBox _messageBox;

        private CategoryService _categoryService;
        private ProductService _productService;

        public TabPageCategoryUserControl()
            : base()
        {
            InitializeComponent();
        }

        public void Initialize(IServiceProvider serviceProvider)
        {
            // listViewCategoryControl.Initialize(serviceProvider);
            _serviceProvider = serviceProvider;
            _messageBox = _serviceProvider.GetRequiredService<IMessageBox>();
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
        }

        protected void BtnAddItem_Click(object sender, EventArgs e)
        {
            using (var addFormMode = _serviceProvider.GetRequiredService<AddCategoryForm>())
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var item = addFormMode.GetCategoryModel().ToCategory();
                _categoryService.Add(item);
            }
        }
    }
}

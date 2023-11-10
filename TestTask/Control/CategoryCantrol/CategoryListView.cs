using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Extension;
using TestTask.Forms.Categories;

namespace TestTask.Control.CategoryCantrol
{
    public partial class CategoryListView : UserControl, ListViewControl.IListViewDataProvider
    {
        private const int IndexId = 0;
        private const int IndexColumnCompanyName = 1;

        private IServiceProvider _serviceProvider;
        private CategoryService _categoryService;
        private ProductService _productService;

        public CategoryListView()
        {
            InitializeComponent();
        }

        public IReadOnlyCollection<ListViewControl.ListViewColumn> Columns { get; } = new List<ListViewControl.ListViewColumn>
        {
            new ListViewControl.ListViewColumn("ID", 200, e => ((Category)e).Id),
            new ListViewControl.ListViewColumn("Name", 555, e => ((Category)e).Name),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            lstView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
        }

        public void LoadData() => lstView.LoadData();

        public bool Add()
        {
            using (var addFormMode = _serviceProvider.GetRequiredService<AddCategoryForm>())
            {
                if (addFormMode.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var item = addFormMode.GetCategoryModel().ToCategory();
                _categoryService.Add(item);
            }

            return true;
        }

        public bool Edit(Entity entity)
        {
            var oldItem = (Category)entity;
            using (var editCompanyForm = _serviceProvider.GetRequiredService<EditCategoryForm>())
            {
                editCompanyForm.Initialize(oldItem);

                if (editCompanyForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editCompanyForm.EditItem();
                _categoryService.Update(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var id = item.GetNonNullableString(IndexId).ParseInt();
            var name = item.GetNonNullableString(IndexColumnCompanyName) ?? throw new ArgumentException("Name cannot be null.");

            return new Category(name, id);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _categoryService.GetQueryableAll();
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                queriable = queriable.Where(e => e.Name.Contains(textBox1.Text));
            }
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity)
        {
            _productService.RemoveProductRelatedToCategory(entity.Id);
            _categoryService.Remove(entity.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

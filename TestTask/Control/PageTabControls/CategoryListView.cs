using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem.Pages.Categories;
using TestTask.Control.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Page;
using TestTask.Core.Models.Products;
using TestTask.Extension;
using TestTask.Forms.Categories;

namespace TestTask.Control.PageTabControls
{
    public partial class CategoryListView : UserControl, IListViewDataProvider
    {
        private const int IndexId = 0;
        private const int IndexColumnName = 1;

        private IServiceProvider _serviceProvider;
        private CategoryService _categoryService;
        private ProductService _productService;
        private SortPageCategories _sortCategory = new SortPageCategories();

        public CategoryListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("ID", 200, e => ((Category)e).Id),
            new ListViewColumn("Name", 555, e => ((Category)e).Name),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoryService = _serviceProvider.GetRequiredService<CategoryService>();
            _productService = _serviceProvider.GetRequiredService<ProductService>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
            cmbSortName.DataSource = _sortCategory.Items;
            cmbSortName.SelectedItem = _sortCategory.SortType;
        }

        public void LoadData() => listView.LoadData();

        public bool Add()
        {
            using (var addForm = _serviceProvider.GetRequiredService<AddCategoryForm>())
            {
                if (addForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var item = addForm.GetCategoryModel().ToCategory();
                _categoryService.Add(item);
            }

            return true;
        }

        public bool Edit(Entity entity)
        {
            var oldItem = (Category)entity;
            using (var editForm = _serviceProvider.GetRequiredService<EditCategoryForm>())
            {
                editForm.Initialize(oldItem);

                if (editForm.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                var updateItem = editForm.EditItem();
                _categoryService.Update(updateItem);
            }

            return true;
        }

        public Entity GetEntity(ListViewItem item)
        {
            var id = item.GetNonNullableString(IndexId).ParseInt();
            var name = item.GetNonNullableString(IndexColumnName) ?? throw new ArgumentException("Name cannot be null.");

            return new Category(name, id);
        }

        public PagedList<Entity> GetPage(Page page)
        {
            var queriable = _categoryService.GetQueryableAll();
            queriable = GetSearchName(queriable);
            queriable = GetSortName(queriable);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity)
        {
            _productService.RemoveProductRelatedToCategory(entity.Id);
            _categoryService.Remove(entity.Id);
        }

        private void ButtonUseFilter_Click(object sender, EventArgs e) => LoadData();

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            cmbSortName.SelectedItem = SortPageCategories.NoSorting;
            _sortCategory.SetSort(cmbSortName.SelectedItem.ToString());
            tbSearchStrName.Text = string.Empty;
            LoadData();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private void CmbSortName_Changed(object sender, EventArgs e)
        {
            _sortCategory.SetSort(cmbSortName.SelectedItem.ToString());
            LoadData();
        }

        private IQueryable<Category> GetSearchName(IQueryable<Category> items)
            => string.IsNullOrEmpty(tbSearchStrName.Text)
            ? items
            : items.Where(e => e.Name.Contains(tbSearchStrName.Text));

        private IQueryable<Category> GetSortName(IQueryable<Category> items)
        {
            if (_sortCategory.IsAscending == null)
            {
                return items;
            }

            return (bool)_sortCategory.IsAscending
                    ? items.OrderBy(e => e.Name).Select(e => e)
                    : items.OrderByDescending(e => e.Name).Select(e => e);
        }
    }
}

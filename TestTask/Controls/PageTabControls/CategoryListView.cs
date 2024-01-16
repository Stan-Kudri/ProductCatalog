using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask.BindingItem.Pages;
using TestTask.BindingItem.Pages.Sort;
using TestTask.Controls.PageTabControls.Model;
using TestTask.Core;
using TestTask.Core.Models;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Page;
using TestTask.Extension;
using TestTask.Forms.Categories;

namespace TestTask.Controls.PageTabControls
{
    public partial class CategoryListView : UserControl, IListViewDataProvider, IInitialize, ILoad
    {
        private const int IndexId = 0;
        private const int IndexColumnName = 1;

        private IServiceProvider _serviceProvider;
        private CategoryRepository _categoryService;
        private SortCategoryModel _selectSortField = new SortCategoryModel();
        private bool _isAscending = true;

        public CategoryListView() => InitializeComponent();

        public IReadOnlyList<ListViewColumn> Columns { get; } = new List<ListViewColumn>
        {
            new ListViewColumn("ID", 200, e => ((Category)e).Id),
            new ListViewColumn("Name", 555, e => ((Category)e).Name),
        };

        public void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoryService = _serviceProvider.GetRequiredService<CategoryRepository>();
            listView.Initialize(this, serviceProvider.GetRequiredService<IMessageBox>());
            checkCmbField.Items.AddRange(_selectSortField.SelectField);
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
                _categoryService.Updata(updateItem);
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
            queriable = _selectSortField.Apply(queriable, _isAscending);
            var result = queriable.GetPagedList(page);
            return new PagedList<Entity>(result, result.PageNumber, result.PageSize, result.TotalItems);
        }

        public void Remove(Entity entity) => _categoryService.Remove(entity.Id);

        private void ButtonUseFilter_Click(object sender, EventArgs e)
        {
            SelectSortField();
            LoadData();
        }

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            tbSearchStrName.Text = string.Empty;
            _selectSortField.SortFields = new HashSet<CategoriesSortType>();
            checkCmbField.ClearSelection();
            _isAscending = true;
            btnTypeSort.Text = TypeSortFields.Ascending.Name;
            LoadData();
        }

        private void ListView_SizeChanged(object sender, EventArgs e)
            => listView.ChangeSizeColumnListView();

        private IQueryable<Category> GetSearchName(IQueryable<Category> items)
            => string.IsNullOrEmpty(tbSearchStrName.Text)
            ? items
            : items.Where(e => e.Name.Contains(tbSearchStrName.Text));

        private void SelectSortField()
        {
            var selectField = new HashSet<CategoriesSortType>();
            foreach (string item in checkCmbField.Items)
            {
                var checkBoxItem = checkCmbField.CheckBoxItems[item];

                if (checkBoxItem.Checked && CategoriesSortType.TryFromName(item, out var sortField))
                {
                    selectField.Add(sortField);
                }
            }
            _selectSortField.SortFields = selectField;
        }

        private void BtnTypeSort_Click(object sender, EventArgs e)
        {
            if (_isAscending)
            {
                _isAscending = false;
                btnTypeSort.Text = TypeSortFields.Descending.Name;
            }
            else
            {
                _isAscending = true;
                btnTypeSort.Text = TypeSortFields.Ascending.Name;
            }

            LoadData();
        }
    }
}

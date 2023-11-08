using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Page.Categories;

namespace TestTask.BindingItem.Pages.Categories
{
    public class FilterModelCategories : ModelBase
    {
        private const string AllCategory = "All Item";

        protected string _category = AllCategory;

        public FilterModelCategories(List<Category> listMode)
        {
            Items = new ObservableCollection<string>() { AllCategory };

            if (listMode != null)
            {
                foreach (var item in listMode)
                {
                    Items.Add(item.Name);
                }
                _category = Items[0];
            }
        }

        public ObservableCollection<string> Items { get; set; }

        public string Category
        {
            get => _category;
            set => SetField(ref _category, value);
        }

        public FilterCategoryName GetFilterCategoryName() => new FilterCategoryName(Category);
    }
}

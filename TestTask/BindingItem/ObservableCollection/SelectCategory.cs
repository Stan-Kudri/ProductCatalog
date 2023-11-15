using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Categories;

namespace TestTask.BindingItem.ObservableCollection
{
    public class SelectCategory : ModelBase
    {
        protected Category _category = null;

        public SelectCategory(List<Category> listMode)
        {
            if (listMode != null)
            {
                Items = new ObservableCollection<Category>(listMode);
                _category = Items[0];
            }
        }

        public ObservableCollection<Category> Items { get; set; }

        public Category Category
        {
            get => _category;
            set => SetField(ref _category, value);
        }

        public void SetValueCategory(int categoryId)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (categoryId == Items[i].Id)
                {
                    _category = Items[i];
                }
            }
        }
    }
}

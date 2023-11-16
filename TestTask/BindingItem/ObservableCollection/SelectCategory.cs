using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;

namespace TestTask.BindingItem.ObservableCollection
{
    public class SelectCategory : ModelBase
    {
        protected Category _category = null;

        public event Action<List<ProductType>> ChangedCategory;

        public SelectCategory(List<Category> listCategory)
        {
            if (listCategory != null)
            {
                Items = new ObservableCollection<Category>(listCategory);
                _category = Items[0];
            }
        }

        public ObservableCollection<Category> Items { get; set; }

        public Category Category
        {
            get => _category;
            set
            {
                if (SetField(ref _category, value))
                {
                    ChangedCategory?.Invoke(_category.Types);
                }
            }
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

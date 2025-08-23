using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Types;

namespace TestTask.BindingItem.ObservableCollection
{
    public class SelectType : ModelBase
    {
        protected ProductType _type = null;

        public SelectType(List<ProductType> listType)
            => ReplaceCollection(listType);

        public ObservableCollection<ProductType> ItemsByCategory { get; private set; }

        public ObservableCollection<ProductType> Items { get; set; }

        public ProductType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        public void SetValueType(Guid typeId)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (typeId == Items[i].Id)
                {
                    _type = Items[i];
                }
            }
        }

        public void ReplaceCollection(List<ProductType> list)
        {
            if (list != null && list.Count > 0)
            {
                Items = new ObservableCollection<ProductType>(list);
                _type = Items[0];
            }
        }

        public void SetItemsByCategory(Category category)
            => ItemsByCategory = new ObservableCollection<ProductType>(Items.Where(e => e.CategoryId == category.Id).ToList());
    }
}

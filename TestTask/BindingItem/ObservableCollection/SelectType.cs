using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Types;

namespace TestTask.BindingItem.ObservableCollection
{
    public class SelectType : ModelBase
    {
        protected ProductType _type = null;

        public SelectType(List<ProductType> listMode)
        {
            if (listMode != null)
            {
                Items = new ObservableCollection<ProductType>(listMode);
                _type = Items[0];
            }
        }

        public ObservableCollection<ProductType> Items { get; set; }

        public ProductType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        public void SetValueType(int typeId)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (typeId == Items[i].Id)
                {
                    _type = Items[i];
                }
            }
        }
    }
}

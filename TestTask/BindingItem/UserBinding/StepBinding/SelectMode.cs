using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Components;

namespace TestTask.BindingItem.UserBinding.StepBinding
{
    public class SelectMode : ModelBase
    {
        private Mode _modeName = null;

        public SelectMode(List<Mode> listMode)
        {
            if (listMode != null)
            {
                Items = new ObservableCollection<Mode>(listMode);
                _modeName = Items[0];
            }
        }

        public ObservableCollection<Mode> Items { get; set; }

        public Mode Mode
        {
            get => _modeName;
            set => SetField(ref _modeName, value);
        }
    }
}

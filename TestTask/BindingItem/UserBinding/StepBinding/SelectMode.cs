using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Modes;

namespace TestTask.BindingItem.UserBinding.StepBinding
{
    public class SelectMode : ModelBase
    {
        private Mode _mode = null;

        public SelectMode(List<Mode> listMode)
        {
            if (listMode != null)
            {
                Items = new ObservableCollection<Mode>(listMode);
                _mode = Items[0];
            }
        }

        public ObservableCollection<Mode> Items { get; set; }

        public Mode Mode
        {
            get => _mode;
            set => SetField(ref _mode, value);
        }

        public void SetValueMode(int modeId)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (modeId == Items[i].Id)
                {
                    _mode = Items[i];
                }
            }
        }
    }
}

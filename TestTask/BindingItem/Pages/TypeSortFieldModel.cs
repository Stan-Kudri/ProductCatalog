using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestTask.Core.Models;

namespace TestTask.BindingItem.Pages
{
    public class TypeSortFieldModel : TypeSortField
    {
        private event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public TypeSortFieldModel()
            : this(null)
        {
        }

        public TypeSortFieldModel(bool? isAscending) => _isAscending = isAscending;


        public override bool? IsAscending
        {
            get => _isAscending;
            set
            {
                if (_isAscending != value)
                {
                    return;
                }

                _isAscending = value;
                OnPropertyChanged(nameof(IsAscending));
            }
        }
    }
}

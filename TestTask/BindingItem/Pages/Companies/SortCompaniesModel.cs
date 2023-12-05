using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.Pages.Companies
{
    public class SortCompaniesModel : SortCompanies
    {
        private event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public SortCompaniesModel()
            : base()
        {
        }

        public override string SortField
        {
            get => _sortField;
            set
            {
                if (!Items.Contains(value))
                {
                    throw new ArgumentException("The resulting string is not a sort element.", value);
                }

                if (_sortField == value)
                {
                    return;
                }

                _sortField = value;
                OnPropertyChanged(nameof(SortField));
            }
        }
    }
}

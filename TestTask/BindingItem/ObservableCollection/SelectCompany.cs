using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.ObservableCollection
{
    public class SelectCompany : ModelBase
    {
        private Company _company = null;

        public SelectCompany(List<Company> listCompany)
        {
            if (listCompany != null)
            {
                Items = new ObservableCollection<Company>(listCompany);
                _company = Items[0];
            }
        }

        public ObservableCollection<Company> Items { get; set; }

        public Company Company
        {
            get => _company;
            set => SetField(ref _company, value);
        }

        public void SetValueCompany(int companyId)
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (companyId == Items[i].Id)
                {
                    _company = Items[i];
                }
            }
        }
    }
}

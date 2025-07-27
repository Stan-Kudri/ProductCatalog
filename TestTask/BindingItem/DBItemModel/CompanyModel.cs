using System;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Companies;

namespace TestTask.BindingItem.DBItemModel
{
    public class CompanyModel : ModelBase
    {
        private string _name = string.Empty;
        private DateTime _dateCreation = DateTime.MinValue;
        private string _country = string.Empty;

        public CompanyModel(string name, DateTime dateCreation, string country)
        {
            BusinessLogicException.ThrowIfNull(dateCreation);

            _name = name;
            _country = country;
            _dateCreation = dateCreation;
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public DateTime DateCreation
        {
            get => _dateCreation;
            set => SetField(ref _dateCreation, value);
        }

        public string Country
        {
            get => _country;
            set => SetField(ref _country, value);
        }

        public Company ToCompany() => new(_name, _dateCreation, _country);

        public Company ToCompany(int id) => new(_name, _dateCreation, _country, id);
    }
}

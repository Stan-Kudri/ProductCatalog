using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Companies;

namespace TestTask.MudBlazors.Model
{
    public class CompanyModel
    {
        private string _name = string.Empty;
        private string _country = string.Empty;
        private DateTime? _dateCreation = null;

        public CompanyModel()
        {
        }

        public CompanyModel(string name, DateTime? dateCreation, string country)
        {
            Name = name;
            DateCreation = dateCreation;
            Country = country;
        }

        [Parameter]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [Parameter]
        public DateTime? DateCreation
        {
            get => _dateCreation;
            set => _dateCreation = value;
        }

        [Parameter]
        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public Company GetCompany() => new Company(Name, (DateTime)DateCreation, _country);

        //public Company GetCompany() => ValidField(out var message) ? new Company(Name, (DateTime)DateCreation, _country) : throw new Exception($"{message}");

        private bool ValidField(out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(Name))
            {
                message = string.Format($"The Field {nameof(Name)} is not in the correct format.");
                return false;
            }
            if (string.IsNullOrEmpty(Country))
            {
                message = string.Format($"The Field {nameof(Country)} is not in the correct format.");
                return false;
            }
            if (DateCreation == null || DateCreation >= DateTime.Now)
            {
                message = string.Format($"The Field {nameof(DateCreation)} is not in the correct format.");
                return false;
            }

            return true;
        }
    }
}

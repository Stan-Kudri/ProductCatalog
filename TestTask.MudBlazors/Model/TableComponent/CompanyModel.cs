using Microsoft.AspNetCore.Components;
using TestTask.Core.Models.Companies;

namespace TestTask.MudBlazors.Model.TableComponent
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

        public Company GetCompany() => new Company(Name, (DateTime)DateCreation, Country);

        public Company GetModifyCompany(int idOldItem) => new Company(Name, (DateTime)DateCreation, Country, idOldItem);

        public void ClearData()
        {
            Name = Country = string.Empty;
            DateCreation = null;
        }
    }
}

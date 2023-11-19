using FluentAssertions;
using TestTask.Core.Models.Companies;

namespace TestTask.Test.ServiceTest
{
    public class CompanyServiceTest
    {
        public static IEnumerable<object[]> CompanyItems() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                    new Company("HP", new DateTime(1939, 1, 1), "USA", 6),
                },
            }
        };

        public static IEnumerable<object[]> AddItemCompany() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                },
                new Company("HP", new DateTime(1939, 1, 1), "USA", 6),
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                    new Company("HP", new DateTime(1939, 1, 1), "USA", 6),
                },
            },
        };

        public static IEnumerable<object[]> UppdataItemCompany() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                    new Company("HP", new DateTime(1939, 1, 1), "USA", 6),
                },
                new Company("MSI", new DateTime(1986, 8, 4), "Taiwan", 6),
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                    new Company("MSI", new DateTime(1986, 8, 4), "Taiwan", 6),
                },
            },
        };

        public static IEnumerable<object[]> RemoveRangeCompany() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                    new Company("HP", new DateTime(1939, 1, 1), "USA", 6),
                },
                new List<int> { 2, 3, 6 },
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                },
            },
        };

        public static IEnumerable<object[]> AddCompanyWithBusyId() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                    new Company("Colin's", new DateTime(1983, 7, 12), "Turkey", 2),
                    new Company("Belvest", new DateTime(2005, 2, 13), "Belarus", 3),
                    new Company("Bershka", new DateTime(2002, 4, 22), "Spain", 4),
                    new Company("Apple", new DateTime(1976, 4, 1), "USA", 5),
                },
                new Company("HP", new DateTime(1939, 1, 1), "USA", 3),
            },
        };

        public static IEnumerable<object[]> NameCompanyById() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                1,
                "MF",
            },
        };

        [Theory]
        [MemberData(nameof(CompanyItems))]
        public void Load_Data_Company(List<Company> companies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            companyService.AddRange(companies);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(companies);
        }

        [Theory]
        [MemberData(nameof(AddItemCompany))]
        public void Equals_Collection_At_Add_Company_In_Service(List<Company> companies, Company addCompany, List<Company> expectCompanies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            dbContext.Company.AddRange(companies);
            dbContext.SaveChanges();
            companyService.Add(addCompany);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(UppdataItemCompany))]
        public void Equals_Collection_At_Updata_Item_Company(List<Company> companies, Company uppdataCompany, List<Company> expectCompanies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            dbContext.Company.AddRange(companies);
            dbContext.SaveChanges();
            companyService.Update(uppdataCompany);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(RemoveRangeCompany))]
        public void Equals_Collection_At_Remove_Range_Items_Company(List<Company> companies, List<int> removeID, List<Company> expectCompanies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            dbContext.Company.AddRange(companies);
            dbContext.SaveChanges();
            companyService.RemoveRange(removeID);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(NameCompanyById))]
        public void Equals_Name_At_Add_Item_Company(Company company, int id, string expectName)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            companyService.Add(company);

            //Act
            var actualName = companyService.CompanyName(id);

            //Assert
            actualName.Equals(expectName);
        }

        [Theory]
        [MemberData(nameof(AddCompanyWithBusyId))]
        public void Expect_Id_Is_Busy(List<Company> companies, Company company)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            companyService.AddRange(companies);

            //Assert
            Assert.Throws<ArgumentException>(() => { companyService.Add(company); });
        }
    }
}

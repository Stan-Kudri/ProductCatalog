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

        public static IEnumerable<object[]> UpdateItemCompany() => new List<object[]>
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
        public void Service_Should_Add_All_The_Item_Of_Database(List<Company> companies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyRepository(dbContext);
            companyService.AddRange(companies);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(companies);
        }

        [Theory]
        [MemberData(nameof(AddItemCompany))]
        public void Service_Should_Add_The_Item_To_The_Database(List<Company> companies, Company addCompany, List<Company> expectCompanies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyRepository(dbContext);
            dbContext.Company.AddRange(companies);
            dbContext.SaveChanges();
            companyService.Add(addCompany);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(UpdateItemCompany))]
        public void Service_Should_Update_The_Item_To_The_Database(List<Company> companies, Company updateCompany, List<Company> expectCompanies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyRepository(dbContext);
            dbContext.Company.AddRange(companies);
            dbContext.SaveChanges();
            companyService.Updata(updateCompany);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(RemoveRangeCompany))]
        public void Service_Should_Remove_Range_Items_By_ID_To_The_Database(List<Company> companies, List<int> removeID, List<Company> expectCompanies)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyRepository(dbContext);
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
        public void Get_Name_By_ID_From_The_Database(Company company, int id, string expectName)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyRepository(dbContext);
            companyService.Add(company);

            //Act
            var actualName = companyService.CompanyName(id);

            //Assert
            actualName.Equals(expectName);
        }

        [Theory]
        [MemberData(nameof(AddCompanyWithBusyId))]
        public void Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy(List<Company> companies, Company company)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyRepository(dbContext);
            companyService.AddRange(companies);

            //Assert
            Assert.Throws<ArgumentException>(() => { companyService.Add(company); });
        }
    }
}

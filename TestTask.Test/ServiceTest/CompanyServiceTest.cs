using FluentAssertions;
using TestTask.Core.Models.Companies;

namespace TestTask.Test.ServiceTest
{
    public class CompanyServiceTest
    {
        public static IEnumerable<object[]> CompanyItem() => new List<object[]>
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

        [Theory]
        [MemberData(nameof(CompanyItem))]
        public void Load_Data_Company(List<Company> companies, Company addCompany, List<Company> expectCompanies)
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
    }
}

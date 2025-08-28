using FluentAssertions;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Companies;

namespace ProductCatalog.Test.ServiceTest
{
    public class CompanyServiceTest
    {
        public static IEnumerable<object[]> AddItemCompany() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new ("MF", new (2002, 10, 15), "Belarus", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                    new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df")),
                    new ("Bershka", new (2002, 4, 22), "Spain", new Guid("96d76ca7-43d1-430c-b55d-1580126680b6")),
                    new ("Apple", new (1976, 4, 1), "USA", new Guid("26d76ca7-43d1-430c-b55d-1580126680b6")),
                },
                new Company("HP", new DateTime(1939, 1, 1), "USA", new Guid("96eb8d97-0119-4400-aaa0-4561daa3c73f")),
                new List<Company>()
                {
                    new ("MF", new (2002, 10, 15), "Belarus", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                    new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df")),
                    new ("Bershka", new (2002, 4, 22), "Spain", new Guid("96d76ca7-43d1-430c-b55d-1580126680b6")),
                    new ("Apple", new (1976, 4, 1), "USA", new Guid("26d76ca7-43d1-430c-b55d-1580126680b6")),
                    new ("HP", new (1939, 1, 1), "USA", new Guid("96eb8d97-0119-4400-aaa0-4561daa3c73f")),
                },
            },
        };

        public static IEnumerable<object[]> UpdateItemCompany() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new ("MF", new (2002, 10, 15), "Belarus", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                    new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df")),
                    new ("Bershka", new (2002, 4, 22), "Spain", new Guid("da1b7484-964a-4ce0-9416-f8a0ba857f48")),
                    new ("Apple", new (1976, 4, 1), "USA", new Guid("96d76ca7-43d1-430c-b55d-1580126680b6")),
                    new ("HP", new (1939, 1, 1), "USA", new Guid("96eb8d97-0119-4400-aaa0-4561daa3c73f")),
                },
                new Company("MSI", new (1986, 8, 4), "Taiwan", new Guid("96eb8d97-0119-4400-aaa0-4561daa3c73f")),
                new List<Company>()
                {
                    new ("MF", new (2002, 10, 15), "Belarus", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                    new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df")),
                    new ("Bershka", new (2002, 4, 22), "Spain", new Guid("da1b7484-964a-4ce0-9416-f8a0ba857f48")),
                    new ("Apple", new (1976, 4, 1), "USA", new Guid("96d76ca7-43d1-430c-b55d-1580126680b6")),
                    new ("MSI", new (1986, 8, 4), "Taiwan", new Guid("96eb8d97-0119-4400-aaa0-4561daa3c73f")),
                },
            },
        };

        public static IEnumerable<object[]> RemoveRangeCompany() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new ("MF", new (2002, 10, 15), "Belarus", new Guid("fe60981d-26b0-47db-a12b-7a1be760f9fd")),
                    new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("7f9cbdc9-0c73-4f1b-ae65-f8e253091798")),
                    new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("cb4eec20-6767-4a6d-a8ca-da1460fb3b08")),
                    new ("Bershka", new (2002, 4, 22), "Spain", new Guid("9a58a1ee-82fc-4ab8-acd1-3ef1c26081be")),
                    new ("Apple", new (1976, 4, 1), "USA", new Guid("a27fb657-ce39-40b6-ad7c-74a13d96b165")),
                    new ("HP", new (1939, 1, 1), "USA", new Guid("9c356956-635e-4bec-8060-c89aed01713f")),
                },
                new List<Guid>
                {
                    new ("7f9cbdc9-0c73-4f1b-ae65-f8e253091798"),
                    new ("cb4eec20-6767-4a6d-a8ca-da1460fb3b08"),
                    new ("9c356956-635e-4bec-8060-c89aed01713f")
                },
                new List<Company>()
                {
                    new ("MF", new (2002, 10, 15), "Belarus", new Guid("fe60981d-26b0-47db-a12b-7a1be760f9fd")),
                    new ("Bershka", new (2002, 4, 22), "Spain", new Guid("9a58a1ee-82fc-4ab8-acd1-3ef1c26081be")),
                    new ("Apple", new (1976, 4, 1), "USA", new Guid("a27fb657-ce39-40b6-ad7c-74a13d96b165")),
                },
            },
        };

        [Theory]
        [MemberData(nameof(AddItemCompany))]
        public async Task Service_Should_Add_The_Item_To_The_Database(List<Company> companies,
                                                                      Company addCompany,
                                                                      List<Company> expectCompanies)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyService(dbContext);
            dbContext.Company.AddRange(companies);
            await dbContext.SaveChangesAsync();
            await companyRepository.AddAsync(addCompany);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().BeEquivalentTo(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(UpdateItemCompany))]
        public async Task Service_Should_Update_The_Item_To_The_Database(List<Company> companies,
                                                                         Company updateCompany,
                                                                         List<Company> expectCompanies)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyService(dbContext);
            dbContext.Company.AddRange(companies);
            await dbContext.SaveChangesAsync();
            await companyRepository.UpdataAsync(updateCompany);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().BeEquivalentTo(expectCompanies);
        }

        [Theory]
        [MemberData(nameof(RemoveRangeCompany))]
        public async Task Service_Should_Remove_Range_Items_By_ID_To_The_Database(List<Company> companies,
                                                                                  List<Guid> removeID,
                                                                                  List<Company> expectCompanies)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyService(dbContext);
            dbContext.Company.AddRange(companies);
            await dbContext.SaveChangesAsync();
            await companyRepository.RemoveRangeAsync(removeID);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().BeEquivalentTo(expectCompanies);
        }

        [Fact]
        public async Task Service_Should_Add_All_The_Item_Of_Database()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyService(dbContext);

            var companies = new List<Company>()
            {
                new ("MF", new (2002, 10, 15), "Belarus", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df")),
                new ("Bershka", new (2002, 4, 22), "Spain", new Guid("a04dd317-f0af-4eb4-afba-173a6d4ed383")),
                new ("Apple", new (1976, 4, 1), "USA", new Guid("96d76ca7-43d1-430c-b55d-1580126680b6")),
                new ("HP", new (1939, 1, 1), "USA", new Guid("96eb8d97-0119-4400-aaa0-4561daa3c73f")),
            };

            await companyRepository.AddRangeAsync(companies);

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(companies);
        }

        [Fact]
        public async Task Get_Name_By_ID_From_The_Database()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyService(dbContext);

            var company = new Company("MF", new DateTime(2002, 10, 15), "Belarus", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969"));
            var id = new Guid("8422dcb1-91bd-4626-a099-852bbff0c969");
            var expectName = "MF";

            await companyRepository.AddAsync(company);

            //Act
            var actualName = companyRepository.CompanyName(id);

            //Assert
            actualName.Equals(expectName);
        }

        [Fact]
        public async Task Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy()
        {
            //Act
            var companies = new List<Company>()
            {
                new ("MF", new (2002, 10, 15), "Belarus", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ("Colin's", new (1983, 7, 12), "Turkey", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                new ("Belvest", new (2005, 2, 13), "Belarus", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df")),
                new ("Bershka", new (2002, 4, 22), "Spain", new Guid("da1b7484-964a-4ce0-9416-f8a0ba857f48")),
                new ("Apple", new (1976, 4, 1), "USA", new Guid("96d76ca7-43d1-430c-b55d-1580126680b6")),
            };
            var company = new Company("HP", new DateTime(1939, 1, 1), "USA", new Guid("63d582ce-7cd4-4efa-9ac3-5f95f02c69df"));

            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyService(dbContext);
            await companyRepository.AddRangeAsync(companies);

            //Assert
            await Assert.ThrowsAsync<BusinessLogicException>(async () => { await companyRepository.AddAsync(company); });
        }
    }
}

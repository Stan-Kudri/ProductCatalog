using FluentAssertions;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers.Model;
using TestTask.Core.Models.Companies;
using TestTask.Test.Properties;

namespace TestTask.Test.ImportTest
{
    public class CompanyImportTest
    {
        [Fact]
        public async Task Import_Should_Add_All_File_Items()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);

            var memoryStream = new MemoryStream(Resources.DataIsAllFilledInTable);
            var companyImporter = new CompanyImporter();
            var companyRead = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            foreach (var item in companyRead)
            {
                if (item.Success)
                {
                    await companyService.UpsertAsync(item.Value);
                }
            }

            var exceptCompany = new List<Company>()
            {
                new Company("MF", new DateTime(2000, 6, 7), "Belarus", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Company("Apple", new DateTime(1973, 7, 12), "USA",  new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
            };

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(exceptCompany);
            companyRead.Should().AllSatisfy(e => e.Success.Should().BeTrue());
        }

        [Fact]
        public void Reading_File_With_Wrong_Sheet_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NameSheetIsNotCorrect);
            var companyImporter = new CompanyImporter();
            var exceptResult = new List<Result<Company>>()
            {
                Result<Company>.CreateFail("Failed to read sheet.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Wrong_Column_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.ColumnNameIsNotCorrect);
            var companyImporter = new CompanyImporter();
            var exceptResult = new List<Result<Company>>()
            {
                Result<Company>.CreateFail("Failed to load title.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Incorrect_Sheet_Data()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NotCorrectDataIsAllFilledIn);
            var companyImporter = new CompanyImporter();
            var exceptResult = new List<Result<Company>>()
            {
                Result<Company>.CreateFail("Fewer cells than needed", 1),
                Result<Company>.CreateFail("DateCreation should be Date", 2),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }
    }
}

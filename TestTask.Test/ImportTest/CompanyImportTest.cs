using FluentAssertions;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers;
using TestTask.Core.Models.Companies;
using TestTask.Test.Properties;

namespace TestTask.Test.ImportTest
{
    public class CompanyImportTest
    {
        public static IEnumerable<object[]> CompanyItems() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2000, 6, 7), "Belarus", 1),
                    new Company("Apple", new DateTime(1973, 7, 12), "USA", 2),
                },
            }
        };

        public static IEnumerable<object[]> FailReadSheet() => new List<object[]>
        {
            new object[]
            {
                new List<Result<Company>>()
                {
                    Result<Company>.CreateFail("Failed to read sheet.", 0),
                },
            }
        };

        public static IEnumerable<object[]> FailReadColumn() => new List<object[]>
        {
            new object[]
            {
                new List<Result<Company>>()
                {
                    Result<Company>.CreateFail("Failed to load title.", 0),
                },
            }
        };

        public static IEnumerable<object[]> FailReadItems() => new List<object[]>
        {
            new object[]
            {
                new List<Result<Company>>()
                {
                    Result<Company>.CreateFail("Fewer cells than needed", 1),
                    Result<Company>.CreateFail("DateCreation should be Date", 2),
                },
            }
        };

        [Theory]
        [MemberData(nameof(CompanyItems))]
        public void Add_All_Item_From_Excel_File(List<Company> exceptCompany)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            var memoryStream = new MemoryStream(Resources.DataIsAllFilledIn);
            var companyImporter = new CompanyImporter();
            var companyRead = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            foreach (var item in companyRead)
            {
                if (item.Success)
                {
                    companyService.AddImportData(item.Value);
                }
            }

            //Act
            var actualCompanies = dbContext.Company.ToList();

            //Assert
            actualCompanies.Should().Equal(exceptCompany);
        }

        [Theory]
        [MemberData(nameof(FailReadSheet))]
        public void Reading_File_With_Wrong_Sheet_Name(List<Result<Company>>? exceptFail)
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NameSheetIsNotCorrect);

            var companyImporter = new CompanyImporter();

            //Act                                 
            var actualFail = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            //Assert
            actualFail.Should().Equal(exceptFail);
        }

        [Theory]
        [MemberData(nameof(FailReadColumn))]
        public void Reading_File_With_Wrong_Column_Name(List<Result<Company>>? exceptFail)
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.ColumnNameIsNotCorrect);

            var companyImporter = new CompanyImporter();

            //Act                                 
            var actualFail = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            //Assert
            actualFail.Should().Equal(exceptFail);
        }

        [Theory]
        [MemberData(nameof(FailReadItems))]
        public void Reading_File_With_Incorrect_Sheet_Data(List<Result<Company>>? exceptFail)
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NotCorrectDataIsAllFilledIn);

            var companyImporter = new CompanyImporter();

            //Act                                 
            var actualFail = new ExcelImporter<Company>(companyImporter).Import(memoryStream);

            //Assert
            actualFail.Should().Equal(exceptFail);
        }
    }
}

using FluentAssertions;
using ProductCatalog.Core;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Import.Importers.Model;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Test.Properties;

namespace ProductCatalog.Test.ImportTest
{
    public class CategoryImportTest
    {
        [Fact]
        public async Task Import_Should_Add_All_File_Items()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var memoryStream = new MemoryStream(Resources.DataIsAllFilledInTable);
            var categoryImporter = new CategoryImporter();
            var categoryRead = new ExcelImporter<Category>(categoryImporter).Import(memoryStream);

            foreach (var item in categoryRead)
            {
                if (item.Success)
                {
                    await categoryService.UpsertAsync(item.Value);
                }
            }

            var exceptCategory = new List<Category>()
            {
                new Category("Clothe", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new Category("Electronic", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
            };

            //Act
            var actualCompanies = dbContext.Category.ToList();

            //Assert
            actualCompanies.Should().Equal(exceptCategory);
            categoryRead.Should().AllSatisfy(e => e.Success.Should().BeTrue());
        }

        [Fact]
        public void Reading_File_With_Wrong_Sheet_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NameSheetIsNotCorrect);
            var categoryImporter = new CategoryImporter();
            var exceptResult = new List<Result<Category>>()
            {
                Result<Category>.CreateFail("Failed to read sheet.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Category>(categoryImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Wrong_Column_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.ColumnNameIsNotCorrect);
            var categoryImporter = new CategoryImporter();
            var exceptResult = new List<Result<Category>>()
            {
                Result<Category>.CreateFail("Failed to load title.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Category>(categoryImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Incorrect_Sheet_Data()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NotCorrectDataIsAllFilledIn);
            var categoryImporter = new CategoryImporter();
            var exceptResult = new List<Result<Category>>()
            {
                Result<Category>.CreateFail("Fewer cells than needed", 1),
                Result<Category>.CreateFail("Id should be guid", 2),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Category>(categoryImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }
    }
}

using FluentAssertions;
using ProductCatalog.Core;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Import.Importers.Model;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.Test.Properties;

namespace ProductCatalog.Test.ImportTest
{
    public class TypeImportTest
    {
        public static IEnumerable<object[]> TypeItems() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Clothe", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new Category("Electronic", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                },
                new List<ProductType>()
                {
                    new ProductType("Coat", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ProductType("Sweater", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new ProductType("Shirt", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), new Guid("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                    new ProductType("Phone", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07"), new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                    new ProductType("Laptop", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07"), new Guid("ccfd99fe-eb54-431f-9d7b-081e0bbc1ec3")),
                },
            }
        };

        [Theory]
        [MemberData(nameof(TypeItems))]
        public async Task Add_All_Item_From_Excel_File(List<Category> categories, List<ProductType> exceptType)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);

            var memoryStream = new MemoryStream(Resources.DataIsAllFilledInTable);
            var typeImporter = new TypeProductImporter();
            var typeRead = new ExcelImporter<ProductType>(typeImporter).Import(memoryStream);

            await categoryService.AddRangeAsync(categories);
            foreach (var item in typeRead)
            {
                if (item.Success)
                {
                    await typeService.UpsertAsync(item.Value);
                }
            }

            //Act
            var actualCompanies = dbContext.Type.ToList();
            typeRead.Should().AllSatisfy(e => e.Success.Should().BeTrue());

            //Assert
            actualCompanies.Should().Equal(exceptType);
        }

        [Fact]
        public void Reading_File_With_Wrong_Sheet_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NameSheetIsNotCorrect);
            var typeImporter = new TypeProductImporter();
            var exceptResult = new List<Result<ProductType>>()
            {
                Result<ProductType>.CreateFail("Failed to read sheet.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<ProductType>(typeImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Wrong_Column_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.ColumnNameIsNotCorrect);
            var typeImporter = new TypeProductImporter();
            var exceptResult = new List<Result<ProductType>>()
            {
                Result<ProductType>.CreateFail("Failed to load title.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<ProductType>(typeImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Incorrect_Sheet_Data()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NotCorrectDataIsAllFilledIn);
            var typeImporter = new TypeProductImporter();
            var exceptResult = new List<Result<ProductType>>()
            {
                Result<ProductType>.CreateFail("Fewer cells than needed", 1),
                Result<ProductType>.CreateFail("Id should be guid", 2),
                Result<ProductType>.CreateFail("Fewer cells than needed", 3),
                Result<ProductType>.CreateFail("Fewer cells than needed", 4),
                Result<ProductType>.CreateFail("Fewer cells than needed", 5),
            };

            //Act                                 
            var actualResult = new ExcelImporter<ProductType>(typeImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }
    }
}

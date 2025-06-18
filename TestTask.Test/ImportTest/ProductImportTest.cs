using FluentAssertions;
using TestTask.Core;
using TestTask.Core.Import;
using TestTask.Core.Import.Importers;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;
using TestTask.Test.Properties;

namespace TestTask.Test.ImportTest
{
    public class ProductImportTest
    {
        public static IEnumerable<object[]> Items() => new List<object[]>
        {
            new object[]
            {
                new List<Company>()
                {
                    new Company("MF", new DateTime(2000, 6, 7), "Belarus", 1),
                    new Company("Apple", new DateTime(1973, 7, 12), "USA", 2),
                },
                new List<Category>()
                {
                    new Category("Clothe", 1),
                    new Category("Electronic", 2),
                },
                new List<ProductType>()
                {
                    new ProductType("Coat", 1, 1),
                    new ProductType("Sweater", 1, 2),
                    new ProductType("Shirt", 1, 3),
                    new ProductType("Phone", 2, 4),
                    new ProductType("Laptop", 2, 5),
                },
                new List<Product>()
                {
                    new Product("Polivuri", 1, 1, 1, "", 235, 4),
                    new Product("Rick&Morty", 1, 1, 2, "", 15, 5),
                    new Product("Iphone 13", 1, 2, 4, "", 400, 6),
                },
            }
        };

        public static IEnumerable<object[]> FailReadSheet() => new List<object[]>
        {
            new object[]
            {
                new List<Result<Product>>()
                {
                    Result<Product>.CreateFail("Failed to read sheet.", 0),
                },
            }
        };

        public static IEnumerable<object[]> FailReadColumn() => new List<object[]>
        {
            new object[]
            {
                new List<Result<Product>>()
                {
                    Result<Product>.CreateFail("Failed to load title.", 0),
                },
            }
        };

        public static IEnumerable<object[]> FailReadItems() => new List<object[]>
        {
            new object[]
            {
                new List<Result<Product>>()
                {
                    Result<Product>.CreateFail("Fewer cells than needed", 1),
                    Result<Product>.CreateFail("Price should be number", 2),
                    Result<Product>.CreateFail("Fewer cells than needed", 3),
                },
            }
        };

        [Theory]
        [MemberData(nameof(Items))]
        public void Add_All_Item_From_Excel_File(List<Company> companies, List<Category> categories, List<ProductType> types, List<Product> exceptProduct)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyRepository = new CompanyRepository(dbContext);
            var categoryRepository = new CategoryRepository(dbContext);
            var typeRepository = new ProductTypeRepository(dbContext);
            var productRepository = new ProductRepository(dbContext);

            companyRepository.AddRange(companies);
            categoryRepository.AddRange(categories);
            typeRepository.AddRange(types);

            var memoryStream = new MemoryStream(Resources.DataIsAllFilledIn);
            var productImporter = new ProductImporter();
            var productRead = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            foreach (var item in productRead)
            {
                if (item.Success)
                {
                    productRepository.Upsert(item.Value);
                }
            }

            //Act
            var actualCompanies = dbContext.Product.ToList();

            //Assert
            actualCompanies.Should().Equal(exceptProduct);
            productRead.Should().AllSatisfy(e => e.Success.Should().BeTrue());
        }

        [Theory]
        [MemberData(nameof(FailReadSheet))]
        public void Reading_File_With_Wrong_Sheet_Name(List<Result<Product>>? exceptResult)
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NameSheetIsNotCorrect);
            var productImporter = new ProductImporter();

            //Act                                 
            var actualResult = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Theory]
        [MemberData(nameof(FailReadColumn))]
        public void Reading_File_With_Wrong_Column_Name(List<Result<Product>>? exceptResult)
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.ColumnNameIsNotCorrect);
            var productImporter = new ProductImporter();

            //Act                                 
            var actualResult = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Theory]
        [MemberData(nameof(FailReadItems))]
        public void Reading_File_With_Incorrect_Sheet_Data(List<Result<Product>>? exceptResult)
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NotCorrectDataIsAllFilledIn);
            var productImporter = new ProductImporter();

            //Act                                 
            var actualResult = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }
    }
}

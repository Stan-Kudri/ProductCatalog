using FluentAssertions;
using ProductCatalog.Core;
using ProductCatalog.Core.Import;
using ProductCatalog.Core.Import.Importers.Model;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Companies;
using ProductCatalog.Core.Models.Products;
using ProductCatalog.Core.Models.Types;
using ProductCatalog.Test.Properties;

namespace ProductCatalog.Test.ImportTest
{
    public class ProductImportTest
    {
        public static IEnumerable<object[]> Items() =>
        [
            [
                new List<Company>()
                {
                    new("MF", new DateTime(2000, 6, 7), "Belarus", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new("Apple", new DateTime(1973, 7, 12), "USA", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new List<Category>()
                {
                    new("Clothe", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new("Electronic", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                },
                new List<ProductType>()
                {
                    new("Coat", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new("Sweater", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new("Shirt", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), new Guid("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                    new("Phone", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07"), new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                    new("Laptop", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07"), new Guid("ccfd99fe-eb54-431f-9d7b-081e0bbc1ec3")),
                },
                new List<Product>()
                {
                    new(name:"Polivuri",
                        companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                        categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                        typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                        destination: "",
                        price: 235,
                        id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new(name:"Rick&Morty",
                        companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                        categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                        typeId: new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1"),
                        destination: "",
                        price: 15,
                        id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                    new(name:"Iphone 13",
                        companyId: new Guid("8422dcb1-91bd-4626-a099-852bbff0c969"),
                        categoryId: new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07"),
                        typeId: new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e"),
                        destination: "",
                        price: 400,
                        id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
            ]
        ];

        [Theory]
        [MemberData(nameof(Items))]
        public async Task Add_All_Item_From_Excel_File(List<Company> companies, List<Category> categories, List<ProductType> types, List<Product> exceptProduct)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddRangeAsync(companies);
            await categoryService.AddRangeAsync(categories);
            await typeService.AddRangeAsync(types);

            var memoryStream = new MemoryStream(Resources.DataIsAllFilledInTable);
            var productImporter = new ProductImporter();
            var productRead = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            foreach (var item in productRead)
            {
                if (item.Success)
                {
                    await productService.UpsertAsync(item.Value);
                }
            }

            //Act
            var actualProduct = dbContext.Product.ToList();

            //Assert
            actualProduct.Should().Equal(exceptProduct);
            productRead.Should().AllSatisfy(e => e.Success.Should().BeTrue());
        }

        [Fact]
        public void Reading_File_With_Wrong_Sheet_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NameSheetIsNotCorrect);
            var productImporter = new ProductImporter();
            var exceptResult = new List<Result<Product>>()
            {
                Result<Product>.CreateFail("Failed to read sheet.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Wrong_Column_Name()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.ColumnNameIsNotCorrect);
            var productImporter = new ProductImporter();
            var exceptResult = new List<Result<Product>>()
            {
                Result<Product>.CreateFail("Failed to load title.", 0),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }

        [Fact]
        public void Reading_File_With_Incorrect_Sheet_Data()
        {
            //Arrange
            var memoryStream = new MemoryStream(Resources.NotCorrectDataIsAllFilledIn);
            var productImporter = new ProductImporter();
            var exceptResult = new List<Result<Product>>()
            {
                Result<Product>.CreateFail("CategoryId should be guid", 1),
                Result<Product>.CreateFail("Price should be number", 2),
                Result<Product>.CreateFail("Name should not be empty", 3),
            };

            //Act                                 
            var actualResult = new ExcelImporter<Product>(productImporter).Import(memoryStream);

            //Assert
            actualResult.Should().Equal(exceptResult);
            actualResult.Should().AllSatisfy(e => e.Success.Should().BeFalse());
        }
    }
}

using FluentAssertions;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Types;

namespace ProductCatalog.Test.ServiceTest
{
    public class TypeProductServiceTest
    {

        public static IEnumerable<object[]> TypeProductItems() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new ("Food", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                    new ("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                },
            }
        };

        public static IEnumerable<object[]> AddItemTypeProduct() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new ("Food", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                },
                new ProductType("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new ("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                },
            },
        };

        public static IEnumerable<object[]> UpdateItemTypeProduct() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new ("Food", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new ("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                },
                new ProductType("Shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new ("Shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                },
            },
        };

        public static IEnumerable<object[]> RemoveTypeProduct() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new ("Food", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new ("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                },
                new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1"),
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                },
            },
        };

        public static IEnumerable<object[]> AddTypeProductWithBusyId() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new ("Food", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Cloth", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new List<ProductType>()
                {
                    new ("Meat", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"), new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("T-shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new ("Sweater", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                },
                new ProductType("Shirt", new ("8422dcb1-91bd-4626-a099-852bbff0c969"), new ("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
            },
        };

        public static IEnumerable<object[]> AddTypeProductWithCategoryMissing() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new ("Food", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                },
                new ProductType("Shirt", new ("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"), new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
            },
        };

        [Theory]
        [MemberData(nameof(TypeProductItems))]
        public async Task Service_Should_Add_All_The_Item_Of_Database(List<Category> categories,
                                                                      List<ProductType> types)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            await categoryService.AddRangeAsync(categories);
            await typeProductService.AddRangeAsync(types);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(types);
        }

        [Theory]
        [MemberData(nameof(AddItemTypeProduct))]
        public async Task Service_Should_Add_The_Item_To_The_Database(List<Category> categories,
                                                                      List<ProductType> types,
                                                                      ProductType addType,
                                                                      List<ProductType> expectTypes)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            await categoryService.AddRangeAsync(categories);
            await typeProductService.AddRangeAsync(types);
            await typeProductService.AddAsync(addType);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(expectTypes);
        }

        [Theory]
        [MemberData(nameof(UpdateItemTypeProduct))]
        public async Task Service_Should_Update_The_Item_To_The_Database(List<Category> categories,
                                                                         List<ProductType> types,
                                                                         ProductType updateType,
                                                                         List<ProductType> expectTypes)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            await categoryService.AddRangeAsync(categories);
            await typeProductService.AddRangeAsync(types);
            await typeProductService.UpdataAsync(updateType);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(expectTypes);
        }

        [Theory]
        [MemberData(nameof(RemoveTypeProduct))]
        public async Task Service_Should_Remove_Item_By_ID_To_The_Database(List<Category> categories,
                                                                           List<ProductType> types,
                                                                           Guid removeID,
                                                                           List<ProductType> expectTypes)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            await categoryService.AddRangeAsync(categories);
            await typeProductService.AddRangeAsync(types);
            await typeProductService.RemoveAsync(removeID);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(expectTypes);
        }

        [Theory]
        [MemberData(nameof(AddTypeProductWithBusyId))]
        public async Task Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy(List<Category> categories,
                                                                           List<ProductType> types,
                                                                           ProductType addType)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            await categoryService.AddRangeAsync(categories);
            await typeProductService.AddRangeAsync(types);

            //Act & Assert
            await Assert.ThrowsAsync<BusinessLogicException>(async () => { await typeProductService.AddAsync(addType); });
        }

        [Fact]
        public async Task Did_Not_Happen_Add_Items_Because_The_Missing_Child_Id()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);

            var categories = new List<Category>()
            {
                new ("Food", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
            };
            var addType = new ProductType("Shirt", new("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"), new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1"));

            await categoryService.AddRangeAsync(categories);

            //Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(async () => { await typeProductService.AddAsync(addType); });
        }
    }
}

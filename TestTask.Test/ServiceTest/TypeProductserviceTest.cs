using FluentAssertions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Types;

namespace TestTask.Test.ServiceTest
{
    public class TypeProductServiceTest
    {

        public static IEnumerable<object[]> TypeProductItems() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Food", 1),
                    new Category("Cloth", 2),
                },
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                    new ProductType("Sweater", 2, 3),
                },
            }
        };

        public static IEnumerable<object[]> AddItemTypeProduct() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Food", 1),
                    new Category("Cloth", 2),
                },
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                },
                new ProductType("Sweater", 2, 3),
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                    new ProductType("Sweater", 2, 3),
                },
            },
        };

        public static IEnumerable<object[]> UppdataItemTypeProduct() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Food", 1),
                    new Category("Cloth", 2),
                },
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                    new ProductType("Sweater", 2, 3),
                },
                new ProductType("Shirt", 2, 3),
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                    new ProductType("Shirt", 2, 3),
                },
            },
        };

        public static IEnumerable<object[]> RemoveTypeProduct() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Food", 1),
                    new Category("Cloth", 2),
                },
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                    new ProductType("Sweater", 2, 3),
                },
                2,
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("Sweater", 2, 3),
                },
            },
        };

        public static IEnumerable<object[]> AddTypeProductWithBusyId() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Food", 1),
                    new Category("Cloth", 2),
                },
                new List<ProductType>()
                {
                    new ProductType("Meat", 1, 1),
                    new ProductType("T-shirt", 2, 2),
                    new ProductType("Sweater", 2, 3),
                },
                new ProductType("Shirt", 2, 2),
            },
        };

        public static IEnumerable<object[]> AddTypeProductWithCategoryMissing() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Food", 1),
                    new Category("Cloth", 2),
                },
                new ProductType("Shirt", 3, 1),
            },
        };

        [Theory]
        [MemberData(nameof(TypeProductItems))]
        public void Load_Data_Category(List<Category> categories, List<ProductType> types)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            categoryService.AddRange(categories);
            typeProductService.AddRange(types);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(types);
        }

        [Theory]
        [MemberData(nameof(AddItemTypeProduct))]
        public void Equals_Collection_At_Add_Type_Product_In_Service(List<Category> categories, List<ProductType> types, ProductType addType, List<ProductType> expectTypes)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            categoryService.AddRange(categories);
            typeProductService.AddRange(types);
            typeProductService.Add(addType);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(expectTypes);
        }

        [Theory]
        [MemberData(nameof(UppdataItemTypeProduct))]
        public void Equals_Collection_At_Updata_Item_Type_Product(List<Category> categories, List<ProductType> types, ProductType uppdateType, List<ProductType> expectTypes)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            categoryService.AddRange(categories);
            typeProductService.AddRange(types);
            typeProductService.Update(uppdateType);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(expectTypes);
        }

        [Theory]
        [MemberData(nameof(RemoveTypeProduct))]
        public void Equals_Collection_At_Remove_Item_Type_Product(List<Category> categories, List<ProductType> types, int removeID, List<ProductType> expectTypes)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            categoryService.AddRange(categories);
            typeProductService.AddRange(types);
            typeProductService.Remove(removeID);

            //Act
            var actualType = dbContext.Type.ToList();

            //Assert
            actualType.Should().Equal(expectTypes);
        }

        [Theory]
        [MemberData(nameof(AddTypeProductWithBusyId))]
        public void Expect_Id_Is_Busy(List<Category> categories, List<ProductType> types, ProductType addType)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            categoryService.AddRange(categories);
            typeProductService.AddRange(types);

            //Assert
            Assert.Throws<ArgumentException>(() => { typeProductService.Add(addType); });
        }

        [Theory]
        [MemberData(nameof(AddTypeProductWithCategoryMissing))]
        public void Error_Add_Type_With_Category_Missing(List<Category> categories, ProductType addType)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            var typeProductService = new ProductTypeService(dbContext);
            categoryService.AddRange(categories);

            //Assert
            Assert.Throws<Exception>(() => { typeProductService.Add(addType); });
        }
    }
}

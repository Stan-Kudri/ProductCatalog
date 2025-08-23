using FluentAssertions;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;
using TestTask.Core.Models.Products;
using TestTask.Core.Models.Types;

namespace TestTask.Test.ServiceTest
{
    public class ProductServiceTest
    {
        public static IEnumerable<object[]> ProductItems() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null, 5,
                                id: new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                    new Product("Red Dragon",
                                companyId:new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null, 6,
                                id: new Guid("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                    new Product("NIBIUS",
                                companyId : new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId : new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId : new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null, 3,
                                id: new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                },
            }
        };

        public static IEnumerable<object[]> AddItemProduct() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("Red Dragon",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                6,
                                id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                },
                new Product("NIBIUS",
                            companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                            typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            null,
                            3,
                            id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("Red Dragon",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                6,
                                id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                    new Product("NIBIUS",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                3,
                                id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
            },
        };

        public static IEnumerable<object[]> UpdateItemProduct() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("Red Dragon",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                6,
                                id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                    new Product("NIBIUS",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                3,
                                id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
                new Product("The Weekend",
                            companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                            typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            null,
                            4,
                            id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("Red Dragon",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                6,
                                id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                    new Product("The Weekend",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                4,
                                id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
            },
        };

        public static IEnumerable<object[]> RemoveProduct() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("Red Dragon",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                6,
                                id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                    new Product("The Weekend",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                4,
                                id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
                new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb"),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("The Weekend",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                4,
                                id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
            },
        };

        public static IEnumerable<object[]> AddProductWithBusyId() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new List<Product>()
                {
                    new Product("Rick",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                5,
                                id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
                    new Product("Red Dragon",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                6,
                                id: new Guid("c0606848-ba9a-41fd-bdf2-d355188803eb")),
                    new Product("The Weekend",
                                companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                                typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                                null,
                                4,
                                id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
                },
                new Product("Harry Potter",
                            companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                            typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            null,
                            2,
                            id: new Guid("a00ad315-a4a9-406c-9cb4-b15487b016a9")),
            },
        };

        public static IEnumerable<object[]> AddProductWithCompanyMissing() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Product("Harry Potter",
                            companyId: new Guid("11d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                            typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            null,
                            2,
                            id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
            },
        };

        public static IEnumerable<object[]> AddProductWithCategoryMissing() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Product("Harry Potter",
                            companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            categoryId: new Guid("33f33f61-8fe2-461b-8eae-cc8344feebe8"),
                            typeId: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            null,
                            2,
                            id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
            },
        };

        public static IEnumerable<object[]> AddProductWithTypeMissing() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", id: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", id: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                new ProductType("T-shirt", categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"), id: new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Product("Harry Potter",
                            companyId: new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                            categoryId: new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8"),
                            typeId: new Guid("33f33f61-8fe2-461b-8eae-cc8344feebe8"),
                            null,
                            2,
                            id: new Guid("053d41f9-fb73-4074-91af-c9755a146dd3")),
            },
        };

        [Theory]
        [MemberData(nameof(ProductItems))]
        public async Task Service_Should_Add_All_The_Item_Of_Database(Company company, Category category, ProductType type, List<Product> products)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddAsync(company);
            await categoryService.AddAsync(category);
            await typeService.AddAsync(type);
            await productService.AddRangeAsync(products);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(products);
        }

        [Theory]
        [MemberData(nameof(AddItemProduct))]
        public async Task Service_Should_Add_The_Item_To_The_Database
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Product addProduct,
            List<Product> expectProducts)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddAsync(company);
            await categoryService.AddAsync(category);
            await typeService.AddAsync(type);
            await productService.AddRangeAsync(products);
            await productService.AddAsync(addProduct);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(expectProducts);
        }

        [Theory]
        [MemberData(nameof(UpdateItemProduct))]
        public async Task Service_Shouldt_Update_The_Item_To_The_Database
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Product updateProduct,
            List<Product> expectProducts)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddAsync(company);
            await categoryService.AddAsync(category);
            await typeService.AddAsync(type);
            await productService.AddRangeAsync(products);
            await productService.UpdataAsync(updateProduct);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(expectProducts);
        }

        [Theory]
        [MemberData(nameof(RemoveProduct))]
        public async Task Service_Should_Remove_Item_By_ID_To_The_Database
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Guid removeId,
            List<Product> expectProducts)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddAsync(company);
            await categoryService.AddAsync(category);
            await typeService.AddAsync(type);
            await productService.AddRangeAsync(products);
            await productService.RemoveAsync(removeId);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(expectProducts);
        }

        [Theory]
        [MemberData(nameof(AddProductWithBusyId))]
        public async Task Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Product product)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddAsync(company);
            await categoryService.AddAsync(category);
            await typeService.AddAsync(type);
            await productService.AddRangeAsync(products);

            //Assert
            await Assert.ThrowsAsync<BusinessLogicException>(async () => { await productService.AddAsync(product); });
        }

        [Theory]
        [MemberData(nameof(AddProductWithCompanyMissing))]
        [MemberData(nameof(AddProductWithCategoryMissing))]
        [MemberData(nameof(AddProductWithTypeMissing))]
        public async Task Did_Not_Happen_Add_Items_Because_The_Missing_Child_Id
            (Company company,
            Category category,
            ProductType type,
            Product product)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            await companyService.AddAsync(company);
            await categoryService.AddAsync(category);
            await typeService.AddAsync(type);

            //Assert
            await Assert.ThrowsAsync<NotFoundException>(async () => { await productService.AddAsync(product); });
        }
    }
}

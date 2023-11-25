﻿using FluentAssertions;
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
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                    new Product("NIBIUS", 1, 1, 1, null, 3, 3),
                },
            }
        };

        public static IEnumerable<object[]> AddItemProduct() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                },
                new Product("NIBIUS", 1, 1, 1, null, 3, 3),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                    new Product("NIBIUS", 1, 1, 1, null, 3, 3),
                },
            },
        };

        public static IEnumerable<object[]> UpdateItemProduct() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                    new Product("NIBIUS", 1, 1, 1, null, 3, 3),
                },
                new Product("The Weekend", 1, 1, 1, null, 4, 3),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                    new Product("The Weekend", 1, 1, 1, null, 4, 3),
                },
            },
        };

        public static IEnumerable<object[]> RemoveProduct() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                    new Product("The Weekend", 1, 1, 1, null, 4, 3),
                },
                2,
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("The Weekend", 1, 1, 1, null, 4, 3),
                },
            },
        };

        public static IEnumerable<object[]> AddProductWithBusyId() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new List<Product>()
                {
                    new Product("Rick", 1, 1, 1, null, 5, 1),
                    new Product("Red Dragon", 1, 1, 1, null, 6, 2),
                    new Product("The Weekend", 1, 1, 1, null, 4, 3),
                },
                new Product("Harry Potter", 1, 1, 1, null, 2, 3),
            },
        };

        public static IEnumerable<object[]> AddProductWithCompanyMissing() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new Product("Harry Potter", 2, 1, 1, null, 2, 1),
            },
        };

        public static IEnumerable<object[]> AddProductWithCategoryMissing() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new Product("Harry Potter", 1, 2, 1, null, 2, 1),
            },
        };

        public static IEnumerable<object[]> AddProductWithTypeMissing() => new List<object[]>
        {
            new object[]
            {
                new Company("MF", new DateTime(2002, 10, 15), "Belarus", 1),
                new Category("Cloth", 1),
                new ProductType("T-shirt", 1, 1),
                new Product("Harry Potter", 1, 1, 2, null, 2, 1),
            },
        };

        [Theory]
        [MemberData(nameof(ProductItems))]
        public void Service_Should_Add_All_The_Item_Of_Database(Company company, Category category, ProductType type, List<Product> products)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            companyService.Add(company);
            categoryService.Add(category);
            typeService.Add(type);
            productService.AddRange(products);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(products);
        }

        [Theory]
        [MemberData(nameof(AddItemProduct))]
        public void Service_Should_Add_The_Item_To_The_Database
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Product addProduct,
            List<Product> expectProducts)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            companyService.Add(company);
            categoryService.Add(category);
            typeService.Add(type);
            productService.AddRange(products);
            productService.Add(addProduct);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(expectProducts);
        }

        [Theory]
        [MemberData(nameof(UpdateItemProduct))]
        public void Service_Shouldt_Update_The_Item_To_The_Database
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Product updateProduct,
            List<Product> expectProducts)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            companyService.Add(company);
            categoryService.Add(category);
            typeService.Add(type);
            productService.AddRange(products);
            productService.Update(updateProduct);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(expectProducts);
        }

        [Theory]
        [MemberData(nameof(RemoveProduct))]
        public void Service_Should_Remove_Item_By_ID_To_The_Database
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            int removeId,
            List<Product> expectProducts)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            companyService.Add(company);
            categoryService.Add(category);
            typeService.Add(type);
            productService.AddRange(products);
            productService.Remove(removeId);

            //Act
            var actualProducts = dbContext.Product.ToList();

            //Assert
            actualProducts.Should().Equal(expectProducts);
        }

        [Theory]
        [MemberData(nameof(AddProductWithBusyId))]
        public void Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy
            (Company company,
            Category category,
            ProductType type,
            List<Product> products,
            Product product)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            companyService.Add(company);
            categoryService.Add(category);
            typeService.Add(type);
            productService.AddRange(products);

            //Assert
            Assert.Throws<ArgumentException>(() => { productService.Add(product); });
        }

        [Theory]
        [MemberData(nameof(AddProductWithCompanyMissing))]
        [MemberData(nameof(AddProductWithCategoryMissing))]
        [MemberData(nameof(AddProductWithTypeMissing))]
        public void Did_Not_Happen_Add_Items_Because_The_Missing_Child_Id
            (Company company,
            Category category,
            ProductType type,
            Product product)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();

            var companyService = new CompanyService(dbContext);
            var categoryService = new CategoryService(dbContext);
            var typeService = new ProductTypeService(dbContext);
            var productService = new ProductService(dbContext);

            companyService.Add(company);
            categoryService.Add(category);
            typeService.Add(type);

            //Assert
            Assert.Throws<Exception>(() => { productService.Add(product); });
        }
    }
}

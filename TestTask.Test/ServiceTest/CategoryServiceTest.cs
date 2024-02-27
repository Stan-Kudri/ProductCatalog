﻿using FluentAssertions;
using TestTask.Core.Models.Categories;

namespace TestTask.Test.ServiceTest
{
    public class CategoryServiceTest
    {
        public static IEnumerable<object[]> CategoryItems() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                    new Category("Food", 4),
                },
            }
        };

        public static IEnumerable<object[]> AddItemCategory() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                },
                new Category("Food", 4),
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                    new Category("Food", 4),
                },
            },
        };

        public static IEnumerable<object[]> UpdateItemCategory() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                    new Category("Food", 4),
                },
                new Category("Auto", 1),
                new List<Category>()
                {
                    new Category("Auto", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                    new Category("Food", 4),
                },
            },
        };

        public static IEnumerable<object[]> RemoveRangeCategory() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                    new Category("Food", 4),
                },
                new List<int> { 1, 4 },
                new List<Category>()
                {
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                },
            },
        };

        public static IEnumerable<object[]> AddCategoryWithBusyId() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                },
                new Category("Food", 2),
            },
        };

        public static IEnumerable<object[]> NameCategoryById() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", 1),
                    new Category("Cloth", 2),
                    new Category("Electronic", 3),
                },
                2,
                "Cloth",
            },
        };


        [Theory]
        [MemberData(nameof(CategoryItems))]
        public void Service_Should_Add_All_The_Item_Of_Database(List<Category> category)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryRepository = new CategoryRepository(dbContext);
            categoryRepository.AddRange(category);

            //Act
            var actualCompanies = dbContext.Category.ToList();

            //Assert
            actualCompanies.Should().Equal(category);
        }

        [Theory]
        [MemberData(nameof(AddItemCategory))]
        public void Service_Should_Add_The_Item_To_The_Database(List<Category> categories, Category addCategory, List<Category> expectCategories)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryRepository(dbContext);
            dbContext.Category.AddRange(categories);
            dbContext.SaveChanges();
            service.Add(addCategory);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().Equal(expectCategories);
        }

        [Theory]
        [MemberData(nameof(UpdateItemCategory))]
        public void Service_Should_Update_The_Item_To_The_Database(List<Category> categories, Category updateCategory, List<Category> expectCategories)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryRepository(dbContext);
            dbContext.Category.AddRange(categories);
            dbContext.SaveChanges();
            service.Updata(updateCategory);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().Equal(expectCategories);
        }

        [Theory]
        [MemberData(nameof(RemoveRangeCategory))]
        public void Service_Should_Remove_Range_Items_By_ID_To_The_Database(List<Category> categories, List<int> removeID, List<Category> expectCategories)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryRepository(dbContext);
            dbContext.Category.AddRange(categories);
            dbContext.SaveChanges();
            service.RemoveRange(removeID);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().Equal(expectCategories);
        }

        [Theory]
        [MemberData(nameof(NameCategoryById))]
        public void Get_Name_By_ID_From_The_Database(List<Category> categories, int id, string expectName)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryRepository(dbContext);
            service.AddRange(categories);

            //Act
            var actualName = service.GetName(id);

            //Assert
            actualName.Equals(expectName);
        }

        [Theory]
        [MemberData(nameof(AddCategoryWithBusyId))]
        public void Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy(List<Category> categories, Category category)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryRepository(dbContext);
            service.AddRange(categories);

            //Assert
            Assert.Throws<ArgumentException>(() => { service.Add(category); });
        }
    }
}

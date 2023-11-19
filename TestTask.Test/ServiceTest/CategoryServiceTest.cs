using FluentAssertions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Companies;

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

        public static IEnumerable<object[]> UppdataItemCategory() => new List<object[]>
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
        public void Load_Data_Category(List<Category> category)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);
            categoryService.AddRange(category);

            //Act
            var actualCompanies = dbContext.Category.ToList();

            //Assert
            actualCompanies.Should().Equal(category);
        }

        [Theory]
        [MemberData(nameof(AddItemCategory))]
        public void Equals_Collection_At_Add_Category_In_Service(List<Category> categories, Category addCategory, List<Category> expectCategories)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
            dbContext.Category.AddRange(categories);
            dbContext.SaveChanges();
            service.Add(addCategory);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().Equal(expectCategories);
        }

        [Theory]
        [MemberData(nameof(UppdataItemCategory))]
        public void Equals_Collection_At_Updata_Item_Category(List<Category> categories, Category uppdataCategory, List<Category> expectCategories)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
            dbContext.Category.AddRange(categories);
            dbContext.SaveChanges();
            service.Update(uppdataCategory);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().Equal(expectCategories);
        }

        [Theory]
        [MemberData(nameof(RemoveRangeCategory))]
        public void Equals_Collection_At_Remove_Range_Items_Category(List<Category> categories, List<int> removeID, List<Category> expectCategories)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
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
        public void Equals_Name_At_Add_Item_Category(List<Category> categories, int id, string expectName)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
            service.AddRange(categories);

            //Act
            var actualName = service.GetName(id);

            //Assert
            actualName.Equals(expectName);
        }

        [Theory]
        [MemberData(nameof(AddCategoryWithBusyId))]
        public void Expect_Id_Is_Busy(List<Category> categories, Category category)
        {
            //Arrange
            var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
            service.AddRange(categories);

            //Assert
            Assert.Throws<ArgumentException>(() => { service.Add(category); });
        }
    }
}

using FluentAssertions;
using TestTask.Core.Exeption;
using TestTask.Core.Models.Categories;

namespace TestTask.Test.ServiceTest
{
    public class CategoryServiceTest
    {
        public static IEnumerable<object[]> AddItemCategory() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music",new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new Category("Cloth", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                    new Category("Electronic",  new Guid("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
                },
                new Category("Food", new Guid("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")),
                new List<Category>()
                {
                    new Category("Music", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new Category("Cloth", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                    new Category("Electronic", new Guid("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
                    new Category("Food", new Guid("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")),
                },
            },
        };

        public static IEnumerable<object[]> UpdateItemCategory() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                    new Category("Music", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new Category("Cloth", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                    new Category("Electronic",  new Guid("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
                    new Category("Food",  new Guid("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")),
                },
                new Category("Auto", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new List<Category>()
                {
                    new Category("Auto",  new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                    new Category("Cloth", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                    new Category("Electronic", new Guid("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
                    new Category("Food",  new Guid("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")),
                },
            },
        };

        [Theory]
        [MemberData(nameof(AddItemCategory))]
        public async Task Service_Should_Add_The_Item_To_The_Database(List<Category> categories,
                                                                      Category addCategory,
                                                                      List<Category> expectCategories)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
            dbContext.Category.AddRange(categories);
            await dbContext.SaveChangesAsync();
            await service.AddAsync(addCategory);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().BeEquivalentTo(expectCategories);
        }

        [Theory]
        [MemberData(nameof(UpdateItemCategory))]
        public async Task Service_Should_Update_The_Item_To_The_Database(List<Category> categories,
                                                                         Category updateCategory,
                                                                         List<Category> expectCategories)
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);
            dbContext.Category.AddRange(categories);
            await dbContext.SaveChangesAsync();
            await service.UpdataAsync(updateCategory);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().BeEquivalentTo(expectCategories);
        }

        [Fact]
        public async Task Service_Should_Add_All_The_Item_Of_Database()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var categoryService = new CategoryService(dbContext);

            var category = new List<Category>()
            {
                new Category("Music", new Guid("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new Category("Cloth", new Guid("8422dcb1-91bd-4626-a099-852bbff0c969")),
                new Category("Electronic", new Guid("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
                new Category("Food", new Guid("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")),
            };

            await categoryService.AddRangeAsync(category);

            //Act
            var actualCompanies = dbContext.Category.ToList();

            //Assert
            actualCompanies.Should().Equal(category);
        }

        [Fact]
        public async Task Service_Should_Remove_Range_Items_By_ID_To_The_Database()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);

            var categories = new List<Category>()
            {
                new ("Music", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                new ("Electronic",  new ("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
                new ("Food",  new ("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")),
            };
            var removeID = new List<Guid>
            {
                new("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220"),
                new("4caa9d9e-3d1d-492f-baf0-fe1e5d8e6531")
            };
            var expectCategories = new List<Category>()
            {
                new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                new ("Electronic",  new ("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
            };

            dbContext.Category.AddRange(categories);
            await dbContext.SaveChangesAsync();
            await service.RemoveRangeAsync(removeID);

            //Act
            var actualCategories = dbContext.Category.ToList();

            //Assert
            actualCategories.Should().BeEquivalentTo(expectCategories);
        }

        [Fact]
        public async Task Get_Name_By_ID_From_The_Database()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);

            var categories = new List<Category>()
            {
                new ("Music", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                new ("Electronic", new ("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
            };
            var id = new Guid("8422dcb1-91bd-4626-a099-852bbff0c969");
            var expectName = "Cloth";

            await service.AddRangeAsync(categories);

            //Act
            var actualName = service.GetName(id);

            //Assert
            actualName.Equals(expectName);
        }

        [Fact]
        public async Task Add_Items_Did_Not_Happen_Because_The_ID_Are_Busy()
        {
            //Arrange
            using var dbContext = new TestDbContextFactory().Create();
            var service = new CategoryService(dbContext);

            var categories = new List<Category>()
            {
                new ("Music", new ("54d32ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                new ("Cloth", new ("8422dcb1-91bd-4626-a099-852bbff0c969")),
                new ("Electronic",  new ("32e14b18-fcdc-4e74-8a97-abeb2f511d47")),
            };
            var category = new Category("Food", new("8422dcb1-91bd-4626-a099-852bbff0c969"));

            await service.AddRangeAsync(categories);

            //Assert
            await Assert.ThrowsAsync<BusinessLogicException>(async () => { await service.AddAsync(category); });
        }
    }
}

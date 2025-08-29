using FluentAssertions;
using ProductCatalog.Core.Exeption;
using ProductCatalog.Core.Models.Categories;
using ProductCatalog.Core.Models.Page;

namespace ProductCatalog.Test
{
    public class PagedListTest
    {
        private const int StartPageSize = 3;
        private const int NumberStartPage = 1;

        public static IEnumerable<object[]> SeconPageItems() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                      new Category("Electronics", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                      new Category("Cloth", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                      new Category("Appliances", new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                      new Category("Furniture", new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                      new Category("Office", new Guid("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                      new Category("Products", new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                      new Category("Chemistry", new Guid("ccfd99fe-eb54-431f-9d7b-081e0bbc1ec3")),
                },
                new Page(2, 3),
                new List<Category>()
                {
                      new Category("Furniture", new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                      new Category("Office", new Guid("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                      new Category("Products", new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                },
            },
        };

        public static IEnumerable<object[]> ListItem() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                      new Category("Electronics", new Guid("4af33f61-8fe2-461b-8eae-cc8344feebe8")),
                      new Category("Cloth", new Guid("ff1c323c-123b-4eb4-b3cd-1884bd053b07")),
                      new Category("Appliances", new Guid("54d22ad6-5748-4ea7-b7e9-c7a4e0b52220")),
                      new Category("Furniture", new Guid("6ae9a401-0a41-4384-8f36-4b67df9846d1")),
                      new Category("Office", new Guid("eab5da2d-ed01-4ec7-8c2c-798048f7de9d")),
                      new Category("Products", new Guid("36e632d2-98b2-4a1b-8c8f-268aac79271e")),
                      new Category("Chemistry", new Guid("ccfd99fe-eb54-431f-9d7b-081e0bbc1ec3")),
                },
            },
        };

        [Theory]
        [MemberData(nameof(SeconPageItems))]
        public void Get_Second_Page_Items(List<Category> items, Page page, List<Category> expectItems)
        {
            // Arrange
            var pagedList = new PagedList<Category>(items.AsQueryable(), page.Number, page.Size);
            var actualItems = pagedList.Items;

            // Assert
            actualItems.Should().Equal(expectItems);
        }

        [Theory]
        [MemberData(nameof(ListItem))]
        public void Invalid_Page_Number_Exception(List<Category> items)
        {
            // Arrange
            var pageNumber = -2;
            var pageSize = StartPageSize;
            var totalItem = items.Count;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                new PagedList<Category>(items, pageNumber, pageSize, totalItem);
            });
        }

        [Theory]
        [MemberData(nameof(ListItem))]
        public void Invalid_Size_Page_Exception(List<Category> items)
        {
            // Arrange
            var pageNumber = NumberStartPage;
            var pageSize = 0;
            var totalItem = items.Count;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                new PagedList<Category>(items, pageNumber, pageSize, totalItem);
            });
        }

        [Theory]
        [MemberData(nameof(ListItem))]
        public void Invalid_Total_Item_Exception(List<Category> items)
        {
            // Arrange
            var pageNumber = NumberStartPage;
            var pageSize = StartPageSize;
            var totalItem = -2;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                new PagedList<Category>(items, pageNumber, pageSize, totalItem);
            });
        }

        [Theory]
        [InlineData(null, 3, 1, 0)]
        public void Exception_By_Null_List(List<Category>? items, int pageSize, int numberPage, int totalItem)
        {
            // Assert
            Assert.Throws<BusinessLogicException>(() =>
            {
                new PagedList<Category>(items, numberPage, pageSize, totalItem);
            });
        }
    }
}

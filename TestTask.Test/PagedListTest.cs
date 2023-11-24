using FluentAssertions;
using TestTask.Core.Models.Categories;
using TestTask.Core.Models.Page;

namespace TestTask.Test
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
                      new Category("Electronics", 1),
                      new Category("Cloth", 2),
                      new Category("Appliances", 3),
                      new Category("Furniture", 4),
                      new Category("Office", 5),
                      new Category("Products", 6),
                      new Category("Chemistry", 7),
                },
                new Page(2, 3),
                new List<Category>()
                {
                      new Category("Furniture", 4),
                      new Category("Office", 5),
                      new Category("Products", 6),
                },
            },
        };

        public static IEnumerable<object[]> ListItem() => new List<object[]>
        {
            new object[]
            {
                new List<Category>()
                {
                      new Category("Electronics", 1),
                      new Category("Cloth", 2),
                      new Category("Appliances", 3),
                      new Category("Furniture", 4),
                      new Category("Office", 5),
                      new Category("Products", 6),
                      new Category("Chemistry", 7),
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
            Assert.Throws<ArgumentException>(()
                =>
            { new PagedList<Category>(items, pageNumber, pageSize, totalItem); });
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
            Assert.Throws<ArgumentException>(()
                =>
            { new PagedList<Category>(items, pageNumber, pageSize, totalItem); });
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
            Assert.Throws<ArgumentException>(()
                =>
            { new PagedList<Category>(items, pageNumber, pageSize, totalItem); });
        }

        [Theory]
        [InlineData(null, 3, 1, 0)]
        public void Exception_By_Null_List(List<Category> items, int pageSize, int numberPage, int totalItem)
        {
            // Assert
            Assert.Throws<ArgumentNullException>(()
                =>
            { new PagedList<Category>(items, numberPage, pageSize, totalItem); });
        }
    }
}

using TestTask.Core.Models.Page;

namespace TestTask.MudBlazors.Model
{
    public class PageModel : Page
    {
        private const int FirstSizePage = 15;

        public PageModel()
            : base(StartNumberPage, FirstSizePage)
        {
        }

        public PageModel(int pageNumber, int pageSize)
            : base(pageNumber, pageSize)
        {
        }

        public int[] Items { get; set; } = new int[] { FirstSizePage, 30, 60 };

        public Page GetPage() => new Page(_number, _size);

        public bool ChangedPage(int pageSize) => pageSize != _size;
    }
}

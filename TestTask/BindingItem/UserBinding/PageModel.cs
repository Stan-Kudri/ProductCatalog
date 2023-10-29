using System.Collections.ObjectModel;
using TestTask.Core.Models.Page;

namespace TestTask.BindingItem.UserBinding
{
    public class PageModel : ModelBase
    {
        private int _size;

        private int _number;

        public PageModel(int pageNumber = Page.StartNumberPage, int pageSize = Page.StartSizePage)
        {
            Number = pageNumber;
            Size = pageSize;
        }

        public ObservableCollection<int> Items { get; set; } = new ObservableCollection<int> { 15, 30, 60 };

        public int Number
        {
            get => _number;
            set => SetField(ref _number, value);
        }

        public int Size
        {
            get => _size;
            set => SetField(ref _size, value);
        }

        public Page GetPage() => new Page(_number, _size);

        public bool ChangedPage(int pageSize) => pageSize != _size;
    }
}

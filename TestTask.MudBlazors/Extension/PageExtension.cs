using TestTask.Core.Models.Page;

namespace TestTask.MudBlazors.Extension
{
    public static class PageExtension
    {
        public static PagedList<T> GetPagedList<T>(this IQueryable<T> self, Page page)
            => new PagedList<T>(self, page.Number, page.Size);
    }
}

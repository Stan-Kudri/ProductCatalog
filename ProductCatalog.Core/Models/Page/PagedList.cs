using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProductCatalog.Core.Exeption;

namespace ProductCatalog.Core.Models.Page
{
    public class PagedList<T> : IReadOnlyCollection<T>
    {
        public PagedList(IQueryable<T> items, int pageNumber = Page.StartNumberPage, int pageSize = Page.StartSizePage)
            : this(GetPage(items, pageSize, pageNumber), pageNumber, pageSize, items.Count())
        {
        }

        public PagedList(IEnumerable<T> items, int pageNumber, int pageSize, int totalItems)
        {
            BusinessLogicException.ThrowIfNull(items);

            if (pageNumber < 0)
            {
                throw new ArgumentException("Page number can not be less than zero.", nameof(pageNumber));
            }

            if (pageSize <= 0)
            {
                throw new ArgumentException("Page size can not be less than one.", nameof(pageSize));
            }

            if (totalItems < 0)
            {
                throw new ArgumentException("Total items can not be less than zero.", nameof(totalItems));
            }

            Items = [.. items.Take(pageSize)];
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItems = totalItems;
        }

        public int PageNumber { get; private set; } = Page.StartNumberPage;

        public int PageSize { get; private set; } = Page.StartSizePage;

        public int TotalItems { get; private set; } = 0;

        public List<T> Items { get; private set; }

        public int PageCount
            => PageSize != 0
                ? (int)Math.Ceiling((double)TotalItems / PageSize)
                : 0;

        public bool HasPrevious => PageNumber > 1;

        public bool HasNext => PageNumber < PageCount;

        public int Count => Items.Count;

        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static List<T> GetPage(IQueryable<T> items, int sizePage, int numberPage)
            => items.Skip((numberPage - 1) * sizePage).Take(sizePage).ToList();
    }
}

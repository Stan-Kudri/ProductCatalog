using System.Linq;

namespace ProductCatalog.Core.Models.SortModel
{
    public interface ISortableField<T>
    {
        IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc);
        IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc);
    }
}

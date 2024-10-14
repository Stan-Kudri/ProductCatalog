using System.Linq;

namespace TestTask.Core.Models
{
    public interface ISortableField<T>
    {
        IOrderedQueryable<T> OrderBy(IQueryable<T> query, bool asc);
        IOrderedQueryable<T> ThenBy(IOrderedQueryable<T> query, bool asc);
    }
}

using System.Collections.Generic;
using System.Linq;

namespace TestTask.Core.Models
{
    public interface IRepository<T>
    {
        void Add(T item);

        void Updata(T item);

        void Remove(int id);

        void Upsert(T item);

        void AddRange(List<T> items);

        void RemoveRange(List<int> listId);

        IQueryable<T> GetQueryableAll();
    }
}

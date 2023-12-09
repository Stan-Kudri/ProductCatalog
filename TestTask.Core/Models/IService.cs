namespace TestTask.Core.Models
{
    public interface IService<T>
    {
        void Add(T item);

        void Updata(T item);

        void Remove(int id);
    }
}

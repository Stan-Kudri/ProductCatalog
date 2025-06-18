namespace TestTask.MudBlazors.Pages.Table.Model
{
    public interface ITableDetailProvider<T>
    {
        IReadOnlyList<ListTableColumn> Columns { get; }

        void Remove(int id);

        void Upsert(T entity);

        IQueryable<T> GetSearchName(IQueryable<T> items, string? searchString);

        IQueryable<T> GetQueryableAll();
    }
}

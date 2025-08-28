namespace ProductCatalog.MudBlazors.Pages.Table.Model
{
    public interface ITableDetailProvider<T>
    {
        IReadOnlyList<ListTableColumn> Columns { get; }

        Task Remove(Guid id);

        Task Upsert(T entity);

        IQueryable<T> GetSearchName(IQueryable<T> items, string? searchString);

        IQueryable<T> GetQueryableAll();
    }
}

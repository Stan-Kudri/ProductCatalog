using System.Collections.Generic;

namespace ProductCatalog.Core.Models.SortModel
{
    public interface ISortableSmartEnumOperation<T>
    {
        static abstract ISortableField<T> DefaultValue { get; }
        static abstract IReadOnlyCollection<ISortableField<T>> List { get; }
    }
}

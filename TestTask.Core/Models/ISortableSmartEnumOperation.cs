using System.Collections.Generic;

namespace TestTask.Core.Models
{
    public interface ISortableSmartEnumOperation<T>
    {
        static abstract ISortableField<T> DefaultValue { get; }
        static abstract IReadOnlyCollection<ISortableField<T>> List { get; }
    }
}

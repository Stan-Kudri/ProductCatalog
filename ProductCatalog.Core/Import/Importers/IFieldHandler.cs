using System;
using NPOI.SS.UserModel;

namespace ProductCatalog.Core.Import.Importers
{
    public interface IFieldHandler<TModel>
    {
        string ColumnName { get; }

        Func<TModel, IRow, int, Result<TModel>> HandlerCell { get; }
    }
}

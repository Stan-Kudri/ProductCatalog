using Ardalis.SmartEnum;
using NPOI.SS.UserModel;
using ProductCatalog.Core.Models;

namespace ProductCatalog.Core.Export.SheetFillers
{
    public abstract class SheetField<T, TField>(string name, int value)
        : SmartEnum<TField>(name, value)
        where TField : SmartEnum<TField>
        where T : Entity
    {
        public abstract void FillCell(ICell cell, T item);
    }
}

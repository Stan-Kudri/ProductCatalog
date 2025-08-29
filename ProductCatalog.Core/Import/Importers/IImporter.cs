using NPOI.SS.UserModel;

namespace ProductCatalog.Core.Import.Importers
{
    public interface IImporter<TRes>
    {
        bool ReadHeader(ISheet sheet);

        Result<TRes> ReadRow(IRow row);

        bool IsModelSheet(string sheetName);
    }
}

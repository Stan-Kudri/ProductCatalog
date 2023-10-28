using NPOI.SS.UserModel;

namespace TestTask.Core.ExportDB.SheetFillers
{
    public interface ISheetFiller
    {
        string Name { get; }

        void Fill(ISheet sheet);
    }
}

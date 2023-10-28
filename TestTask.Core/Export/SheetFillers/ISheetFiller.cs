using NPOI.SS.UserModel;

namespace TestTask.Core.Export.SheetFillers
{
    public interface ISheetFiller
    {
        string Name { get; }

        void Fill(ISheet sheet);
    }
}

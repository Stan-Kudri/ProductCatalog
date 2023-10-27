using NPOI.SS.UserModel;

namespace TestTask.Core.Extension.WriteExtension
{
    public static class CreateSheetExtension
    {
        public static ISheet CreateSheet<T>(this IWorkbook workBook) where T : System.Enum
            => workBook.CreateSheet(nameof(T).Replace("Field", "s").ToString());
    }
}

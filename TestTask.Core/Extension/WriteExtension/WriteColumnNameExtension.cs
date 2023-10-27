using NPOI.SS.UserModel;

namespace TestTask.Core.Extension.WriteExtension
{
    public static class WriteColumnNameExtension
    {
        public static void WriteColumnName<T>(this IWorkbook workBook) where T : System.Enum
        {
        }
    }
}

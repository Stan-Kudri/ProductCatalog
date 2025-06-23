using System.Windows.Forms;
using TestTask.Core.Exeption;

namespace TestTask.Extension
{
    public static class ListViewExtension
    {
        //Index column from all tables
        public const int IndexId = 0;

        public static string GetNonNullableString(this ListViewItem rowItem, int indexColumn)
            => rowItem.GetString(indexColumn) ?? throw new BusinessLogicException("String cannot be null.");

        public static string GetString(this ListViewItem item, int indexColumn)
            => item.SubItems[indexColumn].Text.ToString();
    }
}

using System;
using System.Windows.Forms;

namespace TestTask.Extension
{
    public static class ListViewExtension
    {
        //Index column from all tables
        public const int IndexId = 0;

        public static string GetNonNullableString(this ListViewItem rowItem, int indexColumn)
            => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        public static string GetString(this ListViewItem item, int indexColumn)
            => item.SubItems[indexColumn].Text.ToString();
    }
}

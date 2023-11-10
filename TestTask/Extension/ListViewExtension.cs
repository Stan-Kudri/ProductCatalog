using System;
using System.Windows.Forms;
using TestTask.Core.Models;

namespace TestTask.Extension
{
    public static class ListViewExtension
    {
        //Index column from all tables
        public const int IndexId = 0;

        public static string GetNonNullableString(this ListViewItem rowItem, int indexColumn) => rowItem.GetString(indexColumn) ?? throw new Exception("String cannot be null.");

        public static string GetString(this ListViewItem item, int indexColumn)
        {
            return item.SubItems[indexColumn].Text.ToString();
        }

        public static void Remove<T>(this ListView listView, IService<T> service)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                var rowItem = listView.Items[i];

                if (rowItem.Selected)
                {
                    var id = GetString(rowItem, IndexId).ParseInt();
                    service.Remove(id);
                }
            }
        }
    }
}

using System.Windows.Forms;

namespace TestTask.Extension
{
    public static class RemoveItemDGVExtension
    {
        //Index column from all tables
        public const int IndexId = 0;

        public static void RemoveItemRowGrid(this DataGridView dgv, int id)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var idItem = row.Get<int>(IndexId);
                if (idItem != null && idItem == id)
                {
                    dgv.Rows.RemoveAt(row.Index);
                    break;
                }
            }
        }
    }
}

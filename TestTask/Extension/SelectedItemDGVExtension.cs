using System.Collections.Generic;
using System.Windows.Forms;

namespace TestTask.Extension
{
    public static class SelectedItemDGVExtension
    {
        public static HashSet<int> GetSelectedRowIndexesGrid(this DataGridView dgv)
        {
            var result = new HashSet<int>();

            foreach (DataGridViewRow dgvStepSelectedRow in dgv.SelectedRows)
            {
                result.Add(dgvStepSelectedRow.Index);
            }

            foreach (DataGridViewCell dgvStepSelectedCell in dgv.SelectedCells)
            {
                result.Add(dgvStepSelectedCell.RowIndex);
            }

            return result;
        }
    }
}

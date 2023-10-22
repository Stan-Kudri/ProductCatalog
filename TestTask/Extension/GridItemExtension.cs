using System.Windows.Forms;

namespace TestTask.Extension
{
    public static class GridItemExtension
    {
        public static string GetString(this DataGridViewRow dateRow, int indexColumn) => dateRow.Cells[indexColumn].Value?.ToString();
    }
}

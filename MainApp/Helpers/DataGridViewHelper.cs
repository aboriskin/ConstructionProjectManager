using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.Helpers
{
    static class DataGridViewHelper
    {
        public static List<int> GetSelectedRowIndexes(DataGridView gridView)
        {
            var selectedRows = new HashSet<int>();
            for (int i = 0; i < gridView.SelectedCells.Count; i++)
            {
                selectedRows.Add(gridView.SelectedCells[i].RowIndex);
            }
            return selectedRows.ToList();
        }
    }
}

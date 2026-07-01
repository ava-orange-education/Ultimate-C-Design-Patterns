using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_16._03_Practical_examples_Antipatterns.WinForm_Example
{
    internal class ExportForm
    {
        private DataGridView dataGridView;
        private ExportService _exportService;

        public ExportForm()
        {
            _exportService = new ExportService();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var data = new List<string>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                data.Add(row.Cells[0].Value.ToString());
            }

            File.WriteAllLines("export.txt", data);
            MessageBox.Show("Export complete!");
        }

        private void btnExport_Click1(object sender, EventArgs e)
        {
            var data = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Select(r => r.Cells[0].Value.ToString());

            _exportService.Export(data, "export.txt");
            MessageBox.Show("Export complete!");
        }


    }
}

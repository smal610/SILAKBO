using SILAKBO.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SILAKBO.Forms
{
    public partial class AdminReportViewer : Form
    {
        public AdminReportViewer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ReportService service = new ReportService();

            dataGridView1.DataSource = service.GetAllReports();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            ReportService service = new ReportService();
            service.UpdateStatus(id, cmbStatus.Text);

            MessageBox.Show("Status updated!");

            btnLoad.PerformClick(); // refresh
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO.BLL;

namespace SILAKBO.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                label3.Text = open.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbIncident.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            ReportService service = new ReportService();

            service.Submit(
                1,
                cmbIncident.Text,
                txtDescription.Text,
                txtEvidence.Text
            );

            MessageBox.Show("Report submitted successfully!");

            txtDescription.Clear();
            txtEvidence.Clear();
        }

        private void txtEvidence_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

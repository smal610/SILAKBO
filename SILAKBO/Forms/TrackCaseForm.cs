using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO.DAL;
using MySql.Data.MySqlClient;
using SILAKBO.BLL;
using SILAKBO.Models;

namespace SILAKBO.Forms
{
    public partial class TrackCaseForm : Form
    {
        private User currentUser;

        public TrackCaseForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void TrackCaseForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            ReportService service = new ReportService();
            DataTable dt = service.GetReportsByUser(currentUser.ID);

            dgvReports.DataSource = dt;
        }
    }
}

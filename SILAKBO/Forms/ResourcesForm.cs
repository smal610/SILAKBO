using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SILAKBO.DAL;
using MySql.Data.MySqlClient;

namespace SILAKBO.Forms
{
    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();
        }

        void LoadResources()
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT Name, Type, Contact, Address FROM Resources";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvResources.DataSource = table;

            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadResources();
        }

        private void ResourcesForm_Load(object sender, EventArgs e)
        {
            LoadResources();
        }
    }
}

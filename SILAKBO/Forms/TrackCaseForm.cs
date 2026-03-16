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
    public partial class TrackCaseForm : Form
    {
        public TrackCaseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrackCaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT Status FROM Reports WHERE ID=@id";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txtReference.Text);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblStatus.Text = reader["Status"].ToString();
            }
            else
            {
                lblStatus.Text = "Report not found.";
            }

            conn.Close();
        }

        //private void txtReference_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}

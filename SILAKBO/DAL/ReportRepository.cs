using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SILAKBO.Models;

namespace SILAKBO.DAL
{
    public class ReportRepository
    {
        public void SubmitReport(Report report)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Reports
                            (UserID, IncidentType, Description, EvidencePath, Status)
                            VALUES
                            (@UserID, @IncidentType, @Description, @EvidencePath, @Status)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", report.UserID);
            cmd.Parameters.AddWithValue("@IncidentType", report.IncidentType);
            cmd.Parameters.AddWithValue("@Description", report.Description);
            cmd.Parameters.AddWithValue("@EvidencePath", report.EvidencePath);
            cmd.Parameters.AddWithValue("@Status", report.Status);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
using MySql.Data.MySqlClient;
using SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace SILAKBO.DAL
{
    public class ReportRepository
    {
        // Submit a new report
        public void SubmitReport(Report report)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Reports
                            (UserID, VictimName, IncidentType, Description, EvidencePath, Status, CaseReference, CreatedAt)
                            VALUES
                            (@UserID, @VictimName, @IncidentType, @Description, @EvidencePath, @Status, @CaseReference, @CreatedAt)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", report.UserID);
            cmd.Parameters.AddWithValue("@VictimName", report.VictimName);
            cmd.Parameters.AddWithValue("@IncidentType", report.IncidentType);
            cmd.Parameters.AddWithValue("@Description", report.Description);
            cmd.Parameters.AddWithValue("@EvidencePath", report.EvidencePath);
            cmd.Parameters.AddWithValue("@Status", report.Status);
            cmd.Parameters.AddWithValue("@CaseReference", report.CaseReference);
            cmd.Parameters.AddWithValue("@CreatedAt", report.CreatedAt);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Generate Case Reference like SIL-2026-0001
        public string GenerateCaseReference()
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Reports";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            conn.Close();
            return $"SIL-2026-{count:0000}";
        }

        // Get all reports for admin view
        public DataTable GetAllReports()
        {
            DataTable table = new DataTable();
            var conn = Database.GetConnection();
            conn.Open();

            string query = @"
                SELECT ID, CaseReference, VictimName, IncidentType, Description, Status, CreatedAt
                FROM Reports";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        // Optional: return List<Report> if you prefer objects
        internal List<Report> GetReports()
        {
            List<Report> reports = new List<Report>();
            DataTable dt = GetAllReports();

            foreach (DataRow row in dt.Rows)
            {
                reports.Add(new Report
                {
                    ID = Convert.ToInt32(row["ID"]),
                    VictimName = row["VictimName"].ToString(),
                    IncidentType = row["IncidentType"].ToString(),
                    Description = row["Description"].ToString(),
                    Status = row["Status"].ToString(),
                    CaseReference = row["CaseReference"].ToString(),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"])
                });
            }
            return reports;
        }

        public void UpdateStatus(int reportId, string status)
        {
            var conn = Database.GetConnection();
            conn.Open();

            string query = "UPDATE Reports SET Status=@Status WHERE ID=@ID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@ID", reportId);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
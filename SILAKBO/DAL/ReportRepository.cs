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
        //public void SubmitReport(Report report)
        //{
        //    var conn = Database.GetConnection();
        //    conn.Open();

        //    string query = @"INSERT INTO Reports
        //                    (UserID, IncidentType, Description, EvidencePath, Status)
        //                    VALUES
        //                    (@UserID, @IncidentType, @Description, @EvidencePath, @Status)";

        //    MySqlCommand cmd = new MySqlCommand(query, conn);

        //    cmd.Parameters.AddWithValue("@UserID", report.UserID);
        //    cmd.Parameters.AddWithValue("@IncidentType", report.IncidentType);
        //    cmd.Parameters.AddWithValue("@Description", report.Description);
        //    cmd.Parameters.AddWithValue("@EvidencePath", report.EvidencePath);
        //    cmd.Parameters.AddWithValue("@Status", report.Status);

        //    cmd.ExecuteNonQuery();

        //    conn.Close();
        //}

        public void SubmitReport(Report report)
        {
            var conn = Database.GetConnection();
            conn.Open();

            // Generate Case Reference
            report.CaseReference = GenerateCaseReference(conn);

            string query = @"INSERT INTO Reports
                    (UserID, IncidentType, Description, EvidencePath, Status, CaseReference)
                    VALUES
                    (@UserID, @IncidentType, @Description, @EvidencePath, @Status, @CaseReference)";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", report.UserID);
            cmd.Parameters.AddWithValue("@IncidentType", report.IncidentType);
            cmd.Parameters.AddWithValue("@Description", report.Description);
            cmd.Parameters.AddWithValue("@EvidencePath", report.EvidencePath);
            cmd.Parameters.AddWithValue("@Status", report.Status);
            cmd.Parameters.AddWithValue("@CaseReference", report.CaseReference);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private string GenerateCaseReference(MySqlConnection conn)
        {
            string query = "SELECT CaseReference FROM Reports ORDER BY ID DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var lastRef = cmd.ExecuteScalar()?.ToString();

            int nextNumber = 1;

            if (!string.IsNullOrEmpty(lastRef))
            {
                // lastRef format: "SIL-2026-0001"
                string[] parts = lastRef.Split('-');
                if (parts.Length == 3)
                {
                    int.TryParse(parts[2], out nextNumber);
                    nextNumber += 1;
                }
            }

            string year = DateTime.Now.Year.ToString();
            string newRef = $"SIL-{year}-{nextNumber.ToString("D4")}";
            return newRef;
        }

        // NEW METHOD: Get all reports
        //public List<Report> GetReports()
        //{
        //    List<Report> reports = new List<Report>();
        //    var conn = Database.GetConnection();
        //    conn.Open();

        //    string query = @"SELECT ReportID, UserID, IncidentType, Description, EvidencePath, Status, DateSubmitted
        //                     FROM Reports"; // adjust if your column names are different

        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    MySqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Report report = new Report()
        //        {
        //            ReportID = reader.GetInt32("ReportID"),
        //            UserID = reader.GetInt32("UserID"),
        //            IncidentType = reader.GetString("IncidentType"),
        //            Description = reader.GetString("Description"),
        //            EvidencePath = reader.GetString("EvidencePath"),
        //            Status = reader.GetString("Status"),
        //            DateSubmitted = reader.GetDateTime("DateSubmitted")
        //        };

        //        reports.Add(report);
        //    }

        //    conn.Close();
        //    return reports;
        //}

        public DataTable GetAllReports()
        {
            DataTable table = new DataTable();

            var conn = Database.GetConnection();
            conn.Open();

            string query = @"
                SELECT 
                    r.ID,
                    r.CaseReference,
                    r.VictimName,
                    r.IncidentType,
                    r.Description,
                    r.Status,
                    r.CreatedAt
                FROM Reports r
                JOIN Users u ON r.UserID = u.ID
            ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);

            conn.Close();

            return table;
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

        internal List<Report> GetReports()
        {
            throw new NotImplementedException();
        }
    }
}
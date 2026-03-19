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

        // NEW METHOD: Get all reports
        public List<Report> GetReports()
        {
            List<Report> reports = new List<Report>();
            var conn = Database.GetConnection();
            conn.Open();

            string query = @"SELECT ReportID, UserID, IncidentType, Description, EvidencePath, Status, DateSubmitted
                             FROM Reports"; // adjust if your column names are different

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Report report = new Report()
                {
                    ReportID = reader.GetInt32("ReportID"),
                    UserID = reader.GetInt32("UserID"),
                    IncidentType = reader.GetString("IncidentType"),
                    Description = reader.GetString("Description"),
                    EvidencePath = reader.GetString("EvidencePath"),
                    Status = reader.GetString("Status"),
                    DateSubmitted = reader.GetDateTime("DateSubmitted")
                };

                reports.Add(report);
            }

            conn.Close();
            return reports;
        }

        //Method that gets reports by user ID
        public DataTable GetReportsByUserID(int userID)
        {
            DataTable table = new DataTable();

            var conn = Database.GetConnection();
            conn.Open();

            string query = @"
        SELECT 
            CaseReference,
            IncidentType,
            Description,
            Status,
            CreatedAt
        FROM Reports
        WHERE UserID = @UserID
        ORDER BY CreatedAt DESC
    ";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            conn.Close();
            return table;
        }
    }
}
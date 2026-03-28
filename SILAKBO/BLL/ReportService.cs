using SILAKBO.DAL;
using SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SILAKBO.BLL
{
    public class ReportService
    {
        ReportRepository repo = new ReportRepository();

        public void Submit(int userID, string incidentType, string description, string evidence)
        {
            Report report = new Report();

            report.UserID = userID;
            report.IncidentType = incidentType;
            report.Description = description;
            report.EvidencePath = evidence;
            report.Status = "Received";

            repo.SubmitReport(report);
        }

        public DataTable GetReportsByUser(int userID)
        {
            return repo.GetReportsByUserID(userID);
        }

        //internal object? GetAllReports()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void UpdateStatus(int id, string text)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
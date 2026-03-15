using System;
using System.Collections.Generic;
using System.Text;
using SILAKBO.Models;
using SILAKBO.DAL;

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
    }
}
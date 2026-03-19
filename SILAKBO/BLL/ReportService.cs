using SILAKBO.DAL;
using SILAKBO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace SILAKBO.BLL

//namespace SILAKBO.BLL
//{
//    public class ReportService
//    {
//        ReportRepository repo = new ReportRepository();

//        public void Submit(int userID, string victimName, string incidentType, string description, string evidence)
//        {
//            Report report = new Report();

//            report.UserID = userID;
//            report.VictimName = victimName;
//            report.IncidentType = incidentType;
//            report.Description = description;
//            report.EvidencePath = evidence;
//            report.Status = "Received";

//            repo.SubmitReport(report);
//        }

//        public DataTable GetAllReports()
//        {
//            return repo.GetAllReports();
//        }

//        public void UpdateStatus(int id, string status)
//        {
//            repo.UpdateStatus(id, status);
//        }
//    }
//}


{
    public class ReportService
    {
        private ReportRepository repo = new ReportRepository();

        // Submit a report dynamically
        public void Submit(int userID, string victimName, string incidentType, string description, string evidence)
        {
            Report report = new Report
            {
                UserID = userID,
                VictimName = victimName,
                IncidentType = incidentType,
                Description = description,
                EvidencePath = evidence,
                Status = "Received",
                CaseReference = repo.GenerateCaseReference(),
                CreatedAt = DateTime.Now
            };

            repo.SubmitReport(report);
        }

        public DataTable GetAllReports()
        {
            return repo.GetAllReports();
        }

        public void UpdateStatus(int id, string status)
        {
            repo.UpdateStatus(id, status);
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
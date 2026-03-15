using System;
using System.Collections.Generic;
using System.Text;
using SILAKBO.Models;

namespace SILAKBO.Interfaces
{
    public interface IReportHandler
    {
        void SubmitReport(Report report);
        void UpdateReportStatus(int reportID, string status);
        void DeleteReport(int reportID);
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using SILAKBO.DAL;
using SILAKBO.Models;

namespace SILAKBO.BLL
{
    public class AdminService
    {
        private ReportRepository repo = new ReportRepository();

        public List<Report> GetAllReports()
        {
            return repo.GetReports();
        }
    }
}
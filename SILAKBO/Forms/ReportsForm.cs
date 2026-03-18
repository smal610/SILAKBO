using System;
using System.Collections.Generic;
using System.Text;
using SILAKBO.Models;
using SILAKBO.DAL;
using SILAKBO.BLL;

namespace SILAKBO.Forms
{
    public class ReportsForm
    {
        private AdminService adminService = new AdminService();

        public ReportsForm()
        {
            // Constructor can call LoadReports if you want
        }

        public void DisplayReports()
        {
            List<Report> reports = adminService.GetAllReports();

            Console.WriteLine("ReportID | Username | DateSubmitted | Status");
            Console.WriteLine("--------------------------------------------");

            foreach (var r in reports)
            {
                Console.WriteLine($"{r.ReportID} | {r.Username} | {r.DateSubmitted.ToShortDateString()} | {r.Status}");
            }
        }
    }
}
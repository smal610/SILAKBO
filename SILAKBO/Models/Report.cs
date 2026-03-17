using System;
using System.Collections.Generic;
using System.Text;

namespace SILAKBO.Models
{
    public class Report
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public string IncidentType { get; set; } = "";

        public string Description { get; set; } = "";

        public string EvidencePath { get; set; } = "";

        public string Status { get; set; } = "";

        public DateTime CreatedAt { get; set; }

        // for admin side
        public int ReportID { get; set; }
        public string Username { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string FilePath { get; set; } // optional
    }
}
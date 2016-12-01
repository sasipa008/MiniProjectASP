using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixingSystem.Models
{
    public class FixingStatus
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateTime { get; set; }
        public string Room { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
    }
}
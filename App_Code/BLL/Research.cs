using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Research
    {
        public int ResearchId { get; set; }

        public string ResearchName { get; set; }

        public string ResearchDate { get; set; }
        public string ResearchDesc { get; set; }
        public string ResearchDateReceipt { get; set; }
        public string ResearchConclusion { get; set; }
    }
}
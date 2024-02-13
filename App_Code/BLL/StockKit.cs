using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class StockKit
    {
        public int StockKitId { get; set; }
        public string StockKitDate { get; set; }
        public bool StockKitStatus { get; set; }

        public string StockKitDateEnded { get; set; }
    }
}
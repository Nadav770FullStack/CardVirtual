using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class StockPart
    {
        public int StockPartId { get; set; }
        public string StockPartDateIn { get; set; }
        public string StockPartDateOut { get; set; }
        public bool StockPartStatus { get; set; }

    }
}
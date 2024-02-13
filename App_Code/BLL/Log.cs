using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Log
    {
        public int Logid { get; set; }
        public DateTime LogDate { get; set; }
        public string LogTime { get; set; }
        public string LogDateTime { get; set; }
        public string Remarks { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class SeriesOfAction
    {
        public int SereiesId { get; set; }
        public string SereiesName { get; set; }
        public string ActionDesc { get; set; }
        public int ActionOrder { get; set; }
    }
}
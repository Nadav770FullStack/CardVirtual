using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Part
    {
        public int PartId { get; set; }

        public string PartName { get; set; }

        public string PartImagieName { get; set; }

        public string PartDate { get; set; }
    }
}
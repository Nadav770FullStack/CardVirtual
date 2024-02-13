using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Customer
    {
        public int CustomerId { get; set; }//מזהה של הלקוח
        public string CustomerName { get; set; }//שם לקוח
        public string CustomerAdress { get; set; }//כתובת לקוח
        public string CustomerPhone { get; set; }//טלפון של הלקוח
        public string CustomerMail { get; set; }//מייל של הלקוח
        public string CustomerContactPerson { get; set; }//איש קשר
        public string CustomerContactPersonPhone { get; set; }//טלפון של איש קשר 
        public string CustomerDateStart { get; set; }//תאריך תחילת עבודה
        public int CustomerStatus { get; set; }//סטטוס 
    }
}
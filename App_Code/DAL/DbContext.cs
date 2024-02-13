using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using BLL;

namespace DAL
{
    public class DBcontext
    {
        public string ConnStr { get; set; }
        public SqlConnection Conn { get; set; }
        public SqlCommand Cmd { get; set; }

        public DbContext()
        {
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Conn = new SqlConnection();

            Open();
        }


    }
}
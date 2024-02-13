using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DAL
{
    public class KitDAL
    {

        public static List<Kit> Get()
        {
            return null;
        }
        public static Kit GetById(int Id)
        {
            SqlCommand Db= new SqlCommand();
            SqlCommand Tmp = new SqlCommand();
            string sql = $"select * from Kits were K_Id= {Id}";
            DataTable Dt = Db.ExecuteReader(sql) ;
            if(Dt.Rows.Count>0)
            {
                Tmp = new Kit()
                {
                    KitId = int.Parse(Dt.Rows[0]["K_Id"] + ""),
                    KitDesc = Dt.Rows[0]["K_desc"] + " " ,
                    Cid = int.Parse(Dt.Rows[0]["C_id "] +"",
                    

                }
                    

            }
            return null;


        }
        public static int DeleteById(int Id)
        {
            return 0;
        }
        public static void AddUpdate(Kit Tmp)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CityBO
{
    public static class DB
    {

        public static string DBCountConnect(string reqtable)
        {
            string SendCommand = "SELECT count(*) FROM " + reqtable;
            string res;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\AMD\source\repos\CityBO\CityBO\CTBODB.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(SendCommand, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            res = dt.Rows[0][0].ToString();
            return res;
        }


        public static string DBCountConnect(string reqtable, string reqwhere)
        {
            string SendCommand = "SELECT count(*) FROM " + reqtable + " WHERE " + reqwhere;
            string res;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\AMD\source\repos\CityBO\CityBO\CTBODB.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(SendCommand, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            res = dt.Rows[0][0].ToString();
            return res;
        }

        public static DataTable DBConnect2(string reqtable, string reqwhere)
        {
            string SendCommand = "SELECT * FROM " + reqtable + " where " + reqwhere;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\AMD\source\repos\CityBO\CityBO\CTBODB.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(SendCommand, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            return dt;
        }

        public static void DBSentReq(string reqtable, string valreq, string reqdatas)
        {
            string SendCommand = "insert into " + reqtable + "(" + valreq + ") values (" + reqdatas + ")";

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\AMD\source\repos\CityBO\CityBO\CTBODB.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(SendCommand, con);
        }

        public static DataTable DBCountConnect(string datas, string reqtable, string reqwhere)
        {
            string SendCommand = "SELECT " + datas + " FROM " + reqtable + " WHERE " + reqwhere;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\AMD\source\repos\CityBO\CityBO\CTBODB.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(SendCommand, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            return dt;
        }
    }

    
}

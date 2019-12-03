using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QliNhaTro
{
    class myDatabase
    {
        public String con = @"Data Source=DESKTOP-HNU7DMU\SQLEXPRESS;Initial Catalog=QUANLYPHONGTRO;Integrated Security=True";
        SqlConnection myconnect;

        public myDatabase()
        {
            myconnect = new SqlConnection(con);
        }

        public DataTable getData(String sql)
        {
           // myconnect = new SqlConnection(con);
            SqlDataAdapter myDa = new SqlDataAdapter(sql, myconnect);
            DataTable myDt = new DataTable();
            myDa.Fill(myDt);
            return myDt;

        }
    }
}

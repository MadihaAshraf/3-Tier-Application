using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbCon
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCA5OE5;Initial Catalog=crud;Integrated Security=True");
        public bool UDI(String qry)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            bool check = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return check;

        }

        public DataTable Search(String qry)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
    }

}


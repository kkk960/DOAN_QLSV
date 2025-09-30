using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
namespace DAL
{
    public class KETNOI
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HQKLEEVH\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;Encrypt=False");
        public KETNOI()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public DataTable laydulieu(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable laydulieu_treeview(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int thuchien(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i],values[i]);
            }
            return cmd.ExecuteNonQuery();
        }
    }
}

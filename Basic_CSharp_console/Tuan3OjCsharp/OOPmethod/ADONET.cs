using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace OOPmethod
{
    internal class ADONET
    {
        SqlConnection conn;
        public ADONET()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-EI8PGEP4;Initial Catalog=QLBH_2320;Integrated Security=True";
        }
        public void MoKetNoi()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        public void DongKetNoi()
        {
            if(conn.State != ConnectionState.Closed)
                conn.Close();
        }
        public DataTable Bang (string SQL)
        {
            try
            {
                this.MoKetNoi();
                DataTable tb = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, conn);
                return tb;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int ThucThiSQL (string SQL)
        {
            try
            {
                this.MoKetNoi();
                
            }
        }
    }
    
}

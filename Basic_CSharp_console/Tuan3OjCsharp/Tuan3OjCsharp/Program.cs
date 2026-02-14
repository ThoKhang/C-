using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan3OjCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-EI8PGEP4;Initial Catalog=QLBH_2320;Integrated Security=True";
            conn.Open();
            string Sql = "select * from SanPham";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Sql,conn);
            sqlDataAdapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[0]);
            }
            Sql = "INSERT INTO SanPham (maSP, tenSP, donGiaBan, soLuongHienCon, soLuongCanDuoi, ID) " +
             "VALUES (@maSP, @tenSP, @donGiaBan, @soLuongHienCon, @soLuongCanDuoi, @ID)";

            SqlCommand cmd = new SqlCommand(Sql, conn);

            cmd.Parameters.AddWithValue("@maSP", "SP01");
            cmd.Parameters.AddWithValue("@tenSP", "Bút bi");
            cmd.Parameters.AddWithValue("@donGiaBan", 5000);
            cmd.Parameters.AddWithValue("@soLuongHienCon", 100);
            cmd.Parameters.AddWithValue("@soLuongCanDuoi", 10);
            cmd.Parameters.AddWithValue("@ID", 12);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}

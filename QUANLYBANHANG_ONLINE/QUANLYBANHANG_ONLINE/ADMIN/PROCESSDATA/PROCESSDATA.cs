using QUANLYBANHANG_ONLINE; // dùng namespace của XULYDULIEU
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace QUANLYBANHANG_ONLINE.ADMIN.PROCESSDATA
{
    public class QUANLYSANPHAM_PROCESSDATA
    {
        private XULYDULIEU xulydulieu;

        public QUANLYSANPHAM_PROCESSDATA()
        {
            xulydulieu = new XULYDULIEU(); // KHÔNG dùng App_Code
        }

        public DataTable getTableDanhmuc()
        {
            SqlParameter[] pr = { new SqlParameter("@MADANHMUC", DBNull.Value) };
            return xulydulieu.getTable("psGetTableDANHMUC", pr);
        }

        public DataTable getTableSanPham(int? maSanPham = null)
        {
            // Nếu maSanPham = null → truyền DBNull.Value
            SqlParameter[] pr =
            {
        new SqlParameter("@MASANPHAM", (object)maSanPham ?? DBNull.Value)
    };
            return xulydulieu.getTable("psGetTableSANPHAM", pr);
        }


        public int InsertRecord(Dictionary<string, object> list)
        {
            var pr = CreateSqlParameters(list);
            return xulydulieu.ExeCute("psInsertRecordSANPHAM", pr);
        }

        public int UpdateRecord(Dictionary<string, object> list)
        {
            var pr = CreateSqlParameters(list);
            return xulydulieu.ExeCute("psUpdateRecordSANPHAM", pr);
        }

        public int DeleteRecord(Dictionary<string, object> list)
        {
            var pr = CreateSqlParameters(list);
            return xulydulieu.ExeCute("psDeleteRecordSANPHAM", pr);
        }

        // Hàm helper tạo SqlParameter từ Dictionary
        private SqlParameter[] CreateSqlParameters(Dictionary<string, object> list)
        {
            return list.Select(kv => new SqlParameter(kv.Key, kv.Value ?? DBNull.Value)).ToArray();
        }
    }
}

    using QUANLYBANHANG_ONLINE;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data;
    using System.Data.SqlClient;
    using System.Collections;

    namespace QUANLYBANHANG_ONLINE.ADMIN.PROCESSDATA
    {
        public class QUANLYSANPHAM_PROCESSDATA
        {
            XULYDULIEU xulydulieu;

            public QUANLYSANPHAM_PROCESSDATA()
            {
                xulydulieu = new XULYDULIEU();
            }

            public DataTable getTableDanhmuc()
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@MADANHMUC", DBNull.Value);
                return xulydulieu.getTable("psGetTableDANHMUC", pr);
            }

            public DataTable getTableSanPham()
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@MASANPHAM", DBNull.Value);
                return xulydulieu.getTable("psGetTableSANPHAM", pr);
            }

            public int InsertRecord(Dictionary<String, Object> List)
            {
                SqlParameter[] pr = new SqlParameter[List.Count];
                for (int i = 0; i < List.Count; i++)
                {
                    SqlParameter param;
                    if (List.ElementAt(i).Value != null)
                        param = new SqlParameter(List.ElementAt(i).Key, List.ElementAt(i).Value);
                    else
                        param = new SqlParameter(List.ElementAt(i).Key, DBNull.Value);

                    pr[i] = param;
                }

                int k = xulydulieu.ExeCute("psInsertRecordSANPHAM", pr);
                return k;
            }

            public int UpdateRecord(Dictionary<String, Object> List)
            {
                SqlParameter[] pr = new SqlParameter[List.Count];
                for (int i = 0; i < List.Count; i++)
                {
                    SqlParameter param;
                    if (List.ElementAt(i).Value != null)
                        param = new SqlParameter(List.ElementAt(i).Key, List.ElementAt(i).Value);
                    else
                        param = new SqlParameter(List.ElementAt(i).Key, DBNull.Value);

                    pr[i] = param;
                }

                int k = xulydulieu.ExeCute("psUpdateRecordSANPHAM", pr);
                return k;
            }

            public int DeleteRecord(Dictionary<String, Object> List)
            {
                SqlParameter[] pr = new SqlParameter[List.Count];
                for (int i = 0; i < List.Count; i++)
                {
                    SqlParameter param;
                    if (List.ElementAt(i).Value != null)
                        param = new SqlParameter(List.ElementAt(i).Key, List.ElementAt(i).Value);
                    else
                        param = new SqlParameter(List.ElementAt(i).Key, DBNull.Value);

                    pr[i] = param;
                }

                int k = xulydulieu.ExeCute("psDeleteRecordSANPHAM", pr);
                return k;
            }
        }
    }

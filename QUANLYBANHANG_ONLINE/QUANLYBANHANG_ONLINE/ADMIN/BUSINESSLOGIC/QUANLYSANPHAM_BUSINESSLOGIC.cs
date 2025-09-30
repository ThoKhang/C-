using QUANLYBANHANG_ONLINE.ADMIN;
using QUANLYBANHANG_ONLINE.ADMIN.PROCESSDATA;
using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_ONLINE.ADMIN.BUSINESSLOGIC
{
    public class QUANLYSANPHAM_BUSINESSLOGIC
    {
        private QUANLYSANPHAM_PROCESSDATA processdata;
        private Page pageSANPHAM;

        public QUANLYSANPHAM_BUSINESSLOGIC(Page page)
        {
            pageSANPHAM = page;
            processdata = new QUANLYSANPHAM_PROCESSDATA();
        }

        // Bind DropDownList danh mục
        public void SetValueDropdownlistDanhMuc()
        {
            DropDownList drp = (DropDownList)pageSANPHAM.FindControl("drpDANHMUC");
            drp.DataSource = processdata.getTableDanhmuc();
            drp.DataTextField = "TENDANHMUC";
            drp.DataValueField = "MADANHMUC";
            drp.DataBind();
        }

        // Bind GridView sản phẩm
        public void SetValueGridViewSanPham()
        {
            GridView grv = (GridView)pageSANPHAM.FindControl("grvSANPHAM");
            grv.DataSource = processdata.getTableSanPham();
            grv.DataBind();
        }

        // Upload ảnh và trả về tên file
        public string UploadAnh()
        {
            FileUpload fileupload = (FileUpload)pageSANPHAM.FindControl("FileANHSANPHAM");
            string fileName = null;
            if (fileupload.HasFile)
            {
                fileName = fileupload.FileName;
                string path = pageSANPHAM.Server.MapPath("~/images/");
                fileupload.PostedFile.SaveAs(path + fileName);
            }
            return fileName;
        }

        // Thêm sản phẩm mới
        public int InsertRecordSanPham()
        {
            string file = UploadAnh();
            DropDownList drp = (DropDownList)pageSANPHAM.FindControl("drpDANHMUC");
            TextBox txtTen = (TextBox)pageSANPHAM.FindControl("txtTENSANPHAM");
            TextBox txtMoTa = (TextBox)pageSANPHAM.FindControl("txtMOTA");
            TextBox txtSoLuong = (TextBox)pageSANPHAM.FindControl("txtSOLUONG");
            TextBox txtDonGia = (TextBox)pageSANPHAM.FindControl("txtDONGIA");

            var list = new System.Collections.Generic.Dictionary<string, object>
            {
                { "@TENSANPHAM", txtTen.Text.Trim() },
                { "@DONGIA", decimal.Parse(txtDonGia.Text.Trim()) },
                { "@SOLUONG", int.Parse(txtSoLuong.Text.Trim()) },
                { "@HINHANH", file },
                { "@MOTA", txtMoTa.Text.Trim() },
                { "@MADANHMUC", int.Parse(drp.SelectedValue) }
            };

            return processdata.InsertRecord(list);
        }

        // Sửa thông tin sản phẩm
        public int UpdateRecordSanPham(int maSanPham, string tenSanPham, decimal donGia, int soLuong, string hinhAnh, string moTa, int maDanhMuc)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[]
                                {
                    new SqlParameter("@MASANPHAM", maSanPham),
                    new SqlParameter("@TENSANPHAM", tenSanPham),
                    new SqlParameter("@DONGIA", donGia),
                    new SqlParameter("@SOLUONG", soLuong),
                    new SqlParameter("@HINHANH", hinhAnh),
                    new SqlParameter("@MOTA", moTa),
                    new SqlParameter("@MADANHMUC", maDanhMuc)
                                };
                XULYDULIEU xldl = new XULYDULIEU();
                return xldl.ExeCute("psUpdateRecordSANPHAM", pr);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public int DeleteRecordSanPham(int maSanPham)
        {
            SqlParameter[] pr = new SqlParameter[]
            {
                new SqlParameter("@MASANPHAM", maSanPham)
            };

            XULYDULIEU xldl = new XULYDULIEU();
            return xldl.ExeCute("psDeleteRecordSANPHAM", pr);
        }

    }
}

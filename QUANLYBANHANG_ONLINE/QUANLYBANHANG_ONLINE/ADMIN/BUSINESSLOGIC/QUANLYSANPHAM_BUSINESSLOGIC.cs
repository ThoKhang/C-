using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QUANLYBANHANG_ONLINE.ADMIN;
using System.Web.UI.WebControls;
using System.Web.UI;
using QUANLYBANHANG_ONLINE.ADMIN.PROCESSDATA;

namespace QUANLYBANHANG_ONLINE.ADMIN.BUSINESSLOGIC
{
    public class QUANLYSANPHAM_BUSINESSLOGIC
    {
        QUANLYSANPHAM_PROCESSDATA processdata;
        Page pageSANPHAM;

        public QUANLYSANPHAM_BUSINESSLOGIC(Page page)
        {
            pageSANPHAM = page;
            processdata = new QUANLYSANPHAM_PROCESSDATA();
        }

        public void SetValueDropdownlistDanhMuc()
        {
            ((DropDownList)pageSANPHAM.FindControl("drpDANHMUC")).DataSource =
                processdata.getTableDanhmuc();
            ((DropDownList)pageSANPHAM.FindControl("drpDANHMUC")).DataTextField = "TENDANHMUC";
            ((DropDownList)pageSANPHAM.FindControl("drpDANHMUC")).DataValueField = "MADANHMUC";
            ((DropDownList)pageSANPHAM.FindControl("drpDANHMUC")).DataBind();
        }

        public void SetValueGridViewSanPham()
        {
            ((GridView)pageSANPHAM.FindControl("grvSANPHAM")).DataSource =
                processdata.getTableSanPham();
            ((GridView)pageSANPHAM.FindControl("grvSANPHAM")).DataBind();
        }

        public String UploadAnh()
        {
            FileUpload fileupload = ((FileUpload)pageSANPHAM.FindControl("FileANHSANPHAM"));
            String fileName = null;

            if (fileupload.HasFile)
            {
                fileName = fileupload.FileName;
                String path = this.pageSANPHAM.Server.MapPath("\\IMAGES\\");
                fileupload.PostedFile.SaveAs(path + fileName);
            }
            return fileName;
        }

        public int InsertRecordSanPham()
        {
            String file = UploadAnh();
            object madanhmuc =
                ((DropDownList)pageSANPHAM.FindControl("drpDANHMUC")).SelectedValue;
            object tensanpham = ((TextBox)pageSANPHAM.FindControl("txtTENSANPHAM")).Text;
            object mota = ((TextBox)pageSANPHAM.FindControl("txtMOTA")).Text;
            object soluong = ((TextBox)pageSANPHAM.FindControl("txtSOLUONG")).Text;
            object dongia = ((TextBox)pageSANPHAM.FindControl("txtDONGIA")).Text;

            Dictionary<String, Object> list = new Dictionary<string, object>();
            list.Add("@TENSANPHAM", tensanpham);
            list.Add("@DONGIA", dongia);
            list.Add("@SOLUONG", soluong);
            list.Add("@HINHANH", file);
            list.Add("@MOTA", mota);
            list.Add("@MADANHMUC", madanhmuc);

            int k = processdata.InsertRecord(list);
            return k;
        }
    }
}

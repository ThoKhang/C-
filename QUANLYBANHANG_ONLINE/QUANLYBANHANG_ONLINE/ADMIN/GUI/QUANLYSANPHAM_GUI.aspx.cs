using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUANLYBANHANG_ONLINE.ADMIN.BUSINESSLOGIC;
namespace QUANLYBANHANG_ONLINE.ADMIN.GUI
{
    public partial class QUANLYSANPHAM_GUI : System.Web.UI.Page
    {
        QUANLYSANPHAM_BUSINESSLOGIC businesslogic;
        protected void Page_Load(object sender, EventArgs e)
        {
            businesslogic = new QUANLYSANPHAM_BUSINESSLOGIC(this); businesslogic.SetValueDropdownlistDanhMuc(); businesslogic.SetValueGridViewSanPham();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int k = businesslogic.InsertRecordSanPham();
            businesslogic.SetValueGridViewSanPham();
        }
        protected void txtMOTA_TextChanged(object sender, EventArgs e)
        {
            // Ví dụ: đọc giá trị mô tả
            string mota = ((TextBox)sender).Text;

            // Bạn có thể lưu tạm, hiển thị log, hoặc xử lý business logic ở đây
            // Response.Write("Mô tả vừa nhập: " + mota);
        }

    }
}

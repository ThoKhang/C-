using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_ONLINE
{
    public partial class CHITIETSANPHAM : System.Web.UI.Page
    {
        DataTable tbSANPHAM;
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xuly = new XULYDULIEU();
            string masanpham = Request.QueryString.Get("MASANPHAM");
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MASANPHAM", masanpham);
            tbSANPHAM = xuly.getTable("psGetTableSANPHAM", pr);
            this.Repeater1.DataSource = tbSANPHAM;
            this.Repeater1.DataBind();
        }
        protected void Imagecart_Click(object sender, ImageClickEventArgs e)
        {
            Session.Timeout = 2; // giỏ hàng hết hạn sau 2 phút không hoạt động

            App_Code.CART cart = new App_Code.CART();

            if (tbSANPHAM != null && tbSANPHAM.Rows.Count > 0)
            {
                string masanpham = tbSANPHAM.Rows[0]["MASANPHAM"].ToString();
                string tensanpham = tbSANPHAM.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Convert.ToDouble(tbSANPHAM.Rows[0]["DONGIA"].ToString());
                string hinhanh = tbSANPHAM.Rows[0]["HINHANH"].ToString();

                if (Session["CART"] != null)
                {
                    cart = (App_Code.CART)Session["CART"];
                }

                // thêm vào giỏ hàng (mặc định số lượng = 1)
                cart.AddCart(masanpham, tensanpham, hinhanh, 1, dongia);

                // lưu lại vào Session
                Session["CART"] = cart;

                // quay lại trang giỏ hàng
                Response.Redirect("pageGIOHANG.aspx");
            }
        }
    }
}
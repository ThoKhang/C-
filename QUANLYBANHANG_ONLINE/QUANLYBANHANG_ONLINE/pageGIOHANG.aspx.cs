using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
namespace QUANLYBANHANG_ONLINE
{
    public partial class pageGIOHANG : System.Web.UI.Page
    {
        private void LoadCart()
        {
            if (Session["CART"] != null)
            {
                App_Code.CART cart = (App_Code.CART)Session["CART"];

                // bind dữ liệu giỏ hàng
                this.grvCART.DataSource = cart.LISTCARTS.Values.ToList();
                this.grvCART.DataBind();
                this.grvCART.FooterRow.Cells[0].Text = "Tổng tiền =";
                this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString(); // format số
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LOGIN"] != null)
            {
                DataTable tbLogin = (DataTable)Session["LOGIN"];
                if (!IsPostBack && tbLogin.Rows.Count > 0)
                {
                    LoadCart();
                }
            }
            else
            {
                Response.Redirect("DANHSACHSANPHAM.aspx");
            }
        }
        protected void btnDELETE_Click(object sender, EventArgs e)
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];

            foreach (GridViewRow row in grvCART.Rows)
            {
                // tìm checkbox
                CheckBox ckb = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (ckb.Checked)
                {
                    // lấy mã sản phẩm từ cột đầu tiên
                    string masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
            }

            // cập nhật lại Session
            Session["CART"] = cart;

            // load lại giỏ hàng
            LoadCart();
        }
    }
}
using QUANLYBANHANG_ONLINE.ADMIN.BUSINESSLOGIC;
using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_ONLINE.ADMIN.GUI
{
    public partial class QUANLYSANPHAM_GUI : System.Web.UI.Page
    {
        private QUANLYSANPHAM_BUSINESSLOGIC businessLogic;

        protected void Page_Init(object sender, EventArgs e)
        {
            businessLogic = new QUANLYSANPHAM_BUSINESSLOGIC(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                businessLogic.SetValueDropdownlistDanhMuc();
                businessLogic.SetValueGridViewSanPham();
            }
        }

        protected void grvSANPHAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = grvSANPHAM.SelectedRow;

            if (row != null)
            {
                // Lấy DataKeyNames đã khai báo trong GridView
                int maSanPham = (int)grvSANPHAM.DataKeys[row.RowIndex]["MASANPHAM"];
                string hinhAnhCu = grvSANPHAM.DataKeys[row.RowIndex]["HINHANH"].ToString();
                int maDanhMuc = (int)grvSANPHAM.DataKeys[row.RowIndex]["MADANHMUC"];

                // Set giá trị cho dropdown nếu có item tương ứng
                ListItem item = drpDANHMUC.Items.FindByValue(maDanhMuc.ToString());
                if (item != null)
                {
                    drpDANHMUC.SelectedValue = maDanhMuc.ToString();
                }
                else
                {
                    // Nếu không tìm thấy, chọn item đầu tiên
                    drpDANHMUC.SelectedIndex = 0;
                }

                // Set giá trị cho các textbox
                txtMASANPHAM.Text = maSanPham.ToString();
                txtTENSANPHAM.Text = Server.HtmlDecode(row.Cells[2].Text); // TENSANPHAM
                txtDONGIA.Text = Server.HtmlDecode(row.Cells[3].Text);     // DONGIA
                txtSOLUONG.Text = Server.HtmlDecode(row.Cells[4].Text);    // SOLUONG
                txtMOTA.Text = Server.HtmlDecode(row.Cells[5].Text);       // MOTA

                // Lưu ảnh cũ vào ViewState để dùng khi update nếu người dùng không upload mới
                ViewState["HINHANH_CU"] = hinhAnhCu;


                // Gọi script mở modal
                ScriptManager.RegisterStartupScript(this, this.GetType(),
                    "ShowModal", "$('#productModal').modal('show');", true);
            }
        }


        protected void btnThem_Click(object sender, EventArgs e)
        {
            int result = businessLogic.InsertRecordSanPham();

            if (result > 0)
            {
                businessLogic.SetValueGridViewSanPham();
                lblMessage.Text = "Thêm sản phẩm thành công!";
            }
            else
            {
                lblMessage.Text = "Thêm sản phẩm thất bại!";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMASANPHAM.Text))
            {
                lblMessage.Text = "Vui lòng chọn sản phẩm cần sửa!";
                return;
            }

            int maSanPham;
            decimal donGia;
            int soLuong;
            int maDanhMuc;

            // Kiểm tra parse dữ liệu đầu vào
            if (!int.TryParse(txtMASANPHAM.Text.Trim(), out maSanPham) ||
                !decimal.TryParse(txtDONGIA.Text.Trim(), out donGia) ||
                !int.TryParse(txtSOLUONG.Text.Trim(), out soLuong) ||
                !int.TryParse(drpDANHMUC.SelectedValue, out maDanhMuc))
            {
                lblMessage.Text = "Dữ liệu nhập không hợp lệ!";
                return;
            }

            string tenSP = txtTENSANPHAM.Text.Trim();
            string moTa = txtMOTA.Text.Trim();

            // Xử lý ảnh
            string tenAnh = FileANHSANPHAM.HasFile
                ? (FileANHSANPHAM.PostedFile != null ? FileANHSANPHAM.FileName : "")
                : ViewState["HINHANH_CU"]?.ToString();
            try
            {
                // Gọi business logic Update
                businessLogic.UpdateRecordSanPham(maSanPham, tenSP, donGia, soLuong, tenAnh, moTa, maDanhMuc);

                lblMessage.Text = "Cập nhật sản phẩm thành công!";
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                lblMessage.Text = "Cập nhật sản phẩm thất bại! Lỗi: " + ex.Message;
            }

            // Bind lại GridView luôn
            businessLogic.SetValueGridViewSanPham();
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMASANPHAM.Text))
            {
                lblMessage.Text = "Vui lòng chọn sản phẩm cần xóa!";
                return;
            }

            int maSanPham = int.Parse(txtMASANPHAM.Text);

            int kq = businessLogic.DeleteRecordSanPham(maSanPham);

            if (kq > 0)
            {
                lblMessage.Text = "Xóa sản phẩm thành công!";
                businessLogic.SetValueGridViewSanPham();

                // Reset các textbox và dropdown
                txtMASANPHAM.Text = "";
                txtTENSANPHAM.Text = "";
                txtDONGIA.Text = "";
                txtSOLUONG.Text = "";
                txtMOTA.Text = "";
                drpDANHMUC.SelectedIndex = 0;
            }
            else
            {
                lblMessage.Text = "Xóa sản phẩm thất bại!";
            }
        }



    }
}

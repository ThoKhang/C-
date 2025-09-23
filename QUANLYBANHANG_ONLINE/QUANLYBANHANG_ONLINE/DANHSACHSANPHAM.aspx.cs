using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace QUANLYBANHANG_ONLINE
{
    public partial class DANHSACHSANPHAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xyly = new XULYDULIEU();
            String madanhmuc = Request.QueryString.Get("MADANHMUC");
            String SQL = "select * from tbSANPHAM WHERE MADANHMUC=" + madanhmuc;

            this.DataList1.RepeatColumns = 3;
            this.DataList1.DataSource = xyly.getTable(SQL);
            this.DataList1.DataBind();
        }
        
    }
}
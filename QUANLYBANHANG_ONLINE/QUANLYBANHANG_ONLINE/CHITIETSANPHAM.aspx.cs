using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG_ONLINE
{
    public partial class CHITIETSANPHAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xuly = new XULYDULIEU();
            String masanpham = Request.QueryString.Get("MASANPHAM");
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("MASANPHAM", masanpham);
            this.Repeater1.DataSource = xuly.getTable("psGetTableSANPHAM",pr);
            this.Repeater1.DataBind();
        }
    }
}
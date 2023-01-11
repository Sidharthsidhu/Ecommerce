using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ecommerce
{
    public partial class Product : System.Web.UI.Page
    {
        Ecommerce pro = new Ecommerce();
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "select Cid,Cname from Category";
            DataSet ds = pro.Fn_Exedataset(str);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "Cname";
            DropDownList1.DataValueField = "Cid";
            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pa = "~/Product/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));
            string stat = "Available";
            string prins = "insert into Product values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "','" + pa + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + stat + "')";
            int j = pro.Fn_Exenonquery(prins);
            if (j != 0)
            {
                Label1.Text = "added";
            }


        }
    }
}

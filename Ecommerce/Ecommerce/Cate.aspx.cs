using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Cate : System.Web.UI.Page
    {
        Ecommerce obj = new Ecommerce();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string stat = "Available";
            string cins = "insert into Category values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + stat + "')";
            int ins = obj.Fn_Exenonquery(cins);
            if (ins != 0)
            {
                Label1.Text = "added";
            }
            string sel = "select count(Cid) from Category where Cname='" + TextBox1.Text + "'";
            string cid = obj.Fn_Exescalar(sel);
            if (cid == "1")
            {
                string sel1 = "select Cid from Category where Cname='" + TextBox1.Text + "'";
                string id = obj.Fn_Exescalar(sel1);
                Session["uid"] = id;

            }

        }
    }
}
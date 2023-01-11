using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Login : System.Web.UI.Page
    {
        Ecommerce obj = new Ecommerce();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lid = "select count(Logid) from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string ccid = obj.Fn_Exescalar(lid);
            if (ccid == "1")
            {
                string iid = "select Logid from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logid = obj.Fn_Exescalar(iid);
                string sel = "select Usertype from Login where Logid=" + logid + " ";

                //string s= "select Usertype from LoginTab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";

                string r = obj.Fn_Exescalar(sel);
                if (r == "User")
                {
                    Response.Redirect("Main.Master");
                }
                else if (r == "Admin")
                {
                    Response.Redirect("Cate.aspx");
                }

            }
        }

        //protected void LinkButton1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Usertype.aspx");
        //}
    }
}
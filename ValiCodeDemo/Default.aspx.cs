using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;


namespace ValiCodeDemo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "ValiCode.aspx";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ValiCode = valid.Text;
            if (ValiCode == "")
            {
                Response.Write("<script>alert('验证码为空！');</script>");
                valid.Focus();
                return;
            }
            else if (ValiCode != (string)Session["ValiCode"])
            {
                Response.Write("<script>alert('输入的验证码错误');</script>");
                valid.Text = "";
                valid.Focus();
            }
            else
            {
                Response.Write("<script>alert('你输入的验证码正确');</script>");
                valid.Text = "";
                valid.Focus();
            }
        }
    }
}

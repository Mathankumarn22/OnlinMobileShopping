using System;
using OnlineMobileShop.DAL;
using OnlineMobileShop.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineWebApplication.WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            UserRespository userRespository = new UserRespository();
            UserManager userManager = new UserManager(txtName.Text, txtNumber.Text, txtEmail.Text, txtPassword.Text);
            if (userRespository.SignUp(userManager))
            {
                Response.Write("<script>alert('Registration successful');</script>");
            }
            else
            {
                Response.Write("<script>alert('Registration Failed');</script>");
            }
        }
    }
}
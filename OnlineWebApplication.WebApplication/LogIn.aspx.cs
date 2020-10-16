using System;
using OnlineMobileShop.DAL;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineWebApplication.WebApplication
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserRespository userRespository = new UserRespository();
            int userId = Convert.ToInt32(txtUserId.Text);
            string password = Convert.ToString(txtPassword.Text);
            if (userRespository.LogIn(userId, password))
            {
                Response.Write("<script>alert('Login Successful');</script>");
            }
            else
            {
                Response.Write("<script>alert('Login Failed');</script>");
            }

        }
    }
}
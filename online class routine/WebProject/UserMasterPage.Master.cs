using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebProject
{
    public partial class UserMasterPage : System.Web.UI.MasterPage
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                user_label.Text = Session["user"].ToString();

                
            }
        }

        protected void logout_button_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void search_button_Click(object sender, EventArgs e)
        {
            if (search_textbox.Text != null)
            {
                Session["search"] = search_textbox.Text;
                Response.Redirect("Search.aspx");
                
            }

        }
    }
}
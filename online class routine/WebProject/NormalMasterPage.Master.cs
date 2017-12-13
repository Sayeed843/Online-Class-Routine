using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class NormalMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void search_button_Click(object sender, EventArgs e)
        {
            if (search_textbox.Text != null)
            {
                Session["search"] = search_textbox.Text;
                Response.Redirect("NormalSearch.aspx");

            }

        }
    }
}
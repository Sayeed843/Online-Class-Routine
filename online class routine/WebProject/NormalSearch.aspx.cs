using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class NormalSearch : System.Web.UI.Page
    {
        DataOperation db = new DataOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                search();
            }
        }

        private void search()
        {
            string query = @"SELECT `classshedule_all`.`day`,
    `classshedule_all`.`time`,
    `classshedule_all`.`class`,
    `classshedule_all`.`course`,
    `classshedule_all`.`teacher`
FROM `project`.`classshedule_all`
WHERE `classshedule_all`.`day`= '" + Session["search"].ToString() + "';";

            search_gridview.DataSource = db.get_data(query);
            search_gridview.DataBind();
        }
    }
}
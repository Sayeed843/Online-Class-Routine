using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebProject
{
    public partial class ClassShedule1 : System.Web.UI.Page
    {
        DataOperation db = new DataOperation();
        string con_link = @"Data Source=localhost; database = webproject; User ID=root; password='exittimebro'";
        ClassSheduleDynamicTable cs_dynamic_table = new ClassSheduleDynamicTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]!=null && Session["user"].ToString() == "Sayeed")
            {
                edit_button.Visible = true;
            }
            else
            {
                edit_button.Visible = false;
            }
            
            if (!Page.IsPostBack)
            {
                class_shedule_show();
            }
            
        }
        
        public void class_shedule_show()
        {
            string query = @"SELECT `classshedule_all`.`idclassshedule_all`,
    `classshedule_all`.`day`,
    `classshedule_all`.`time`,
    `classshedule_all`.`class`,
    `classshedule_all`.`course`,
    `classshedule_all`.`teacher`
FROM `project`.`classshedule_all`;";

            class_shedule_gridview.DataSource= db.get_data(query);
            class_shedule_gridview.DataBind();
        }

        protected void edit_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateClassShedule.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class AuthorityCrudClassShedule : System.Web.UI.Page
    {
        DataOperation db = new DataOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                class_shedule_show();
            }

        }

        public void class_shedule_show()
        {
            string quary = @"SELECT `class_shedule`.`Shedule_ID`,`day`.`Day_Name`,`room`.`Room_Number`,`course`.`Course_Name`,`teacher`.`Teacher_Initial`
FROM `webproject`.`class_shedule`,`webproject`.`day`,`webproject`.`room`,`webproject`.`course`,`webproject`.`teacher`
where `class_shedule`.`Day_ID` = `day`.`Day_ID` && `class_shedule`.`Room_ID` = `room`.`Room_ID` && `class_shedule`.`Course_ID` = `course`.`Course_ID` && `class_shedule`.`Teacher_ID` = `teacher`.`Teacher_ID`;
";
            crud_class_shedule.DataSource = db.get_data(quary);
            crud_class_shedule.DataBind();
        }

        protected void crud_class_shedule_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            crud_class_shedule.PageIndex = e.NewPageIndex;
            class_shedule_show();
        }

        protected void crud_class_shedule_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            crud_class_shedule.EditIndex = -1;
            class_shedule_show();
        }

        protected void crud_class_shedule_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label label_no = (Label)crud_class_shedule.Rows[e.RowIndex].FindControl("label_no");

            string query = @"Delete from ";

            if (db.execute_data(query) == 1)
            {
                class_shedule_show();
            }
        }

        protected void crud_class_shedule_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void crud_class_shedule_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        
    }
}
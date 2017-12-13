using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class UpdateClassShedule : System.Web.UI.Page
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
            string query = @"SELECT `classshedule_all`.`idclassshedule_all`,
    `classshedule_all`.`day`,
    `classshedule_all`.`time`,
    `classshedule_all`.`class`,
    `classshedule_all`.`course`,
    `classshedule_all`.`teacher`
FROM `project`.`classshedule_all`;";

            edit_class_shedule_gridview.DataSource = db.get_data(query);
            edit_class_shedule_gridview.DataBind();
        }

        protected void back_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void edit_class_shedule_gridview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            edit_class_shedule_gridview.PageIndex = e.NewPageIndex;
            class_shedule_show();
        }

        protected void edit_class_shedule_gridview_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            edit_class_shedule_gridview.EditIndex = -1;
            class_shedule_show();
        }

        /*
        protected void edit_class_shedule_gridview_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            Label LabelID = (Label)edit_class_shedule_gridview.Rows[e.RowIndex].FindControl("LabelID");
            string quary = @"DELETE FROM `workshop`.`student_info`
                                WHERE day='" + LabelID.Text + "';";
        }
        */
        
        protected void edit_class_shedule_gridview_RowEditing(object sender, GridViewEditEventArgs e)
        {
            edit_class_shedule_gridview.EditIndex = e.NewEditIndex;
            class_shedule_show();
        }

        protected void edit_class_shedule_gridview_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label label_day = (Label)edit_class_shedule_gridview.Rows[e.RowIndex].FindControl("day_label");
            Label label_time = (Label)edit_class_shedule_gridview.Rows[e.RowIndex].FindControl("time_label");
            Label label_class = (Label)edit_class_shedule_gridview.Rows[e.RowIndex].FindControl("class_label");
            TextBox textbox_course = (TextBox)edit_class_shedule_gridview.Rows[e.RowIndex].FindControl("course_textbox");
            TextBox textbox_teacher = (TextBox)edit_class_shedule_gridview.Rows[e.RowIndex].FindControl("teacher_textbox");

            string query = @"UPDATE `project`.`classshedule_all`
                            SET `classshedule_all`.`course` = '" + textbox_course.Text + "' ,";
            query +="`classshedule_all`.`teacher` = '" + textbox_teacher.Text + "'";
            query += "WHERE `day` ='" + label_day.Text + "'";
            query += "And `classshedule_all`.`time`='" + label_time.Text + "'";
            query +="And `classshedule_all`.`class`='" + label_class.Text+"';";

            if (db.execute_data(query) == 1)
            {
                edit_class_shedule_gridview.EditIndex = -1;
                class_shedule_show();
            }
        }
    }
}
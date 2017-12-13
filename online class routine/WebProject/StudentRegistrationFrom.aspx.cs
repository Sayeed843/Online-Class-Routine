using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebProject
{
    public partial class StudentRegistrationFrom : System.Web.UI.Page
    {
        Student student = new Student();

        string connection_link = @"Data Source=localhost; database=project;user=root;password='exittimebro'";
        protected void Page_Load(object sender, EventArgs e)
        {
            //CompareValidator();
        }

        public string insert_db_department()
        {

            

            string query = @"INSERT INTO `project`.`department`
                            (`department`,
                             `Batch`,
                             `user_info_id`)"+
                            
                            "(Select '" + student.get_user_department()+ "','" + student.get_batch()
                + "',`user_info`.`iduser_info` From `project`.`user_info` where `user_info`.`email`= '" 
                + student.get_user_email() + "'); ";

            return query;
        }


        public string insert_db_user_info()
        {
            string query = @"INSERT INTO `project`.`user_info`
                            (`name`,`email`,`password`,`id`)";
                   query +="VALUES('" + student.get_user_name()+ "','" + student.get_user_email()
                       + "','" + student.get_user_password()
                       + "','" + student.get_user_id() + "'); ";

            return query;
        }

        public string insert_db_gender()
        {

            string query = @"INSERT INTO `project`.`gender`
                            (`gender`,`department_id`)" +
                            "(Select '" + student.get_user_gender() + "',`department`.`iddepartment`";
            query += "From `project`.`department` , `project`.`user_info`";
            query += "Where `user_info`.`email`='" + student.get_user_email() + "'";
            query += "and `user_info`.`iduser_info`=`department`.`user_info_id` );";

            return query;



        }

      /*  public string insert_db_user()
        {
            string query = @"INSERT INTO `project`.`user`
            (`user_info_id`,`gender_id`,`department_id`)" +

            "(SELECT  SELECET `user_info`.`iduser_info`FROM `project`.`user_info`";
            query += "WHERE `user_info`.`name`='" + student.get_user_name() + "'";
            query += "and`user_info`.`email`='" + student.get_user_email() + "' ,";
            query += "`gender`.`idgender` From `project`.`gender`,`project`.`department`,";
            query += "`project`.`user_info`WHERE `gender`.`iddepartment`=`department`.`iddepartment`";
            query += "and`department`.`iduser_info`=`user_info`.`iduser_info` and`user_info`.`name`='"
                    + student.get_user_name() + "' and`user_info`.`email`='" + student.get_user_email() + "' ,";
            query += "`department`.`iddepartment`FROM `project`.`department`,`project`.`user_info`";
            query += "WHERE `department`.`iduser_info`=`user_info`.`iduser_info` ";
            query += "and`user_info`.`name`='" + student.get_user_name() + "' ";
            query +="and `user_info`.`email`='" + student.get_user_email() + "')";

            return query;

        }*/
        protected void save_button_Click(object sender, EventArgs e)
        {
            student.set_user_name(name_text_box.Text);
            student.set_user_email(email_text_box.Text);
            student.set_user_password(password_text_box.Text);
            student.set_user_id(id_text_box.Text);
            student.set_user_department(department_text_box.Text);
            student.set_batch(batch_text_box.Text);
            student.set_user_id(id_text_box.Text);
            student.set_user_gender(gender_drop_down.Text);

                if (student.db_execute(insert_db_user_info()) == 1 &&
                    student.db_execute(insert_db_department()) ==1 && 
                    student.db_execute(insert_db_gender())==1 )
                {
                    message_label.Text = "Sing up done!!!";

                }
            else
            {
                message_label.Text = "Sing up fail!!!";
            }
                
                

                //Response.Redirect("Login.aspx");
        }

        protected void name_text_box_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_text_box.Text))
            {
                string query = @"SELECT * FROM `project`.`user_info`"; 
                        query +="Where `user_info`.`name`='"+name_text_box.Text+"';";

                MySqlConnection cn = new MySqlConnection(connection_link);

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, cn);

                MySqlDataReader reader;
                //reader = cmd.ExecuteReader();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    user_message_label.Text = "User Name Already Exist";
                    user_message_label.ForeColor = System.Drawing.Color.Red;
                    cn.Close();
                }
                else
                {
                    user_message_label.Text = "User Name is available";
                    user_message_label.ForeColor = System.Drawing.Color.Green;
                    cn.Close();
                }
                

            }
        }

        protected void email_text_box_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email_text_box.Text))
            {
                string query = @"SELECT * FROM `project`.`user_info`";
                query += "Where `user_info`.`email`='" + email_text_box.Text + "';";

                MySqlConnection cn = new MySqlConnection(connection_link);

                if(cn.State==ConnectionState.Closed)
                {
                    cn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(query, cn);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    email_message_label.Text = "Email Already Exist";
                    email_message_label.ForeColor = System.Drawing.Color.Red;
                    cn.Close();
                }
                else
                {
                    email_message_label.Text = "Email is available";
                    email_message_label.ForeColor = System.Drawing.Color.Green;
                    cn.Close();
                }


            }
        }
    }
}
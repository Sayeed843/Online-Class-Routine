using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class Login1 : System.Web.UI.Page
    {
        Student student = new Student();
        //User user;
        //User=Student;

        string connection_link = @"Data Source=localhost; database = project; User ID=root; password='exittimebro'";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_button_click(object sender, EventArgs e)
        {
            student.set_user_email(l_email_text.Text);
            student.set_user_password(l_pass_text.Text);
            //student.set_user_id(l_id_text.Text);

            string query = @"SELECT * FROM `project`.`user_info`";
                   query +="WHERE `user_info`.`email`='" + student.get_user_email() + "'";
                   query += "and `user_info`.`password`='" + student.get_user_password() + "'";
                   //query += "and `user_info`.`id`='"+ student.get_user_id()+"'";

            if(student.db_check(query)>0)
            {
                //user_label.DataSource();
                //user.db_get_data(query);
               // UserMasterPage user_master_page = new UserMasterPage();

                MySqlConnection cn = new MySqlConnection(connection_link);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //cn.Close();

                while (reader.Read())
                {
                    int t_id = reader.GetInt32(0);
                    string user_name = reader.GetString(1);
                    string email = reader.GetString(2);
                    string pass = reader.GetString(3);
                    string id = reader.GetString(4);
                    Session["user"] = user_name;
                    //Session["id"] = id;
                }
                
                //
                cn.Close();
                
                
                Response.Redirect("UserHome.aspx");
            }
            else
            {
                message_label.Text = "Wrong password or email.";
            }
        }

        
    }
}
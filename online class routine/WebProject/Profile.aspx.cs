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
    public partial class Profile : System.Web.UI.Page
    {
        Student student = new Student();
        User user;

        

        string connection_link = @"Data Source=localhost; database = project; User ID=root; password='exittimebro'";
        DataOperation db =new DataOperation();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                check_teacher_initial();
                //get_db_department();
                get_db_user_info();
                get_db_gender();
                get_db_blood_group();
               // get_db_dob();
                get_db_marital_status();
                get_db_nationality();
                get_db_pob();
                get_db_department();
                image_load();


            }
        }

        private void image_load()
        {
            string query = @"SELECT`user_image`.`image_data`
FROM `project`.`user_image`,`project`.`user_info`
WHERE `user_image`.`user_info_id`='" + Session["user_id"].ToString() + "';";

            profile_image.ImageUrl = db.get_data(query).ToString();
            //image_gridview.DataSource= db.get_data(query);
            //image_gridview.DataBind();

        }

        private void check_teacher_initial()
        {
            string query = @"Select *
                             From `project`.`teacher_initial`,`project`.`user_info`
                             Where `user_info`.`iduser_info`=`teacher_initial`.`user_info_id`
                                and `user_info`.`name`='"+ Session["user"].ToString() + "'";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(query,cn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int tea_initial_id = reader.GetInt32(0);
                string tea_initial = reader.GetString(1);
                if (tea_initial != null)
                {
                    Teacher teacher = new Teacher();
                    tea_initial_label.Visible = true;
                    batch_label.Visible = false;
                    tea_initial_label.Text = tea_initial;
                }
                else
                {
                    tea_initial_label.Visible = false;
                }

            }

        }
        private MySqlDataReader get_reader(string query)
        {
            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            return reader;
        }
        private void get_db_user_info()
        {
            var session_user = Session["user"].ToString();
            
            string query = @"SELECT `user_info`.`iduser_info`,
                            `user_info`.`name`,
                            `user_info`.`email`,
                            `user_info`.`password`,
                            `user_info`.`id`,
                            `user_info`.`dob`
                            FROM `project`.`user_info`
                            Where `user_info`.`name`='"+ session_user + "';";

            ///get_reader(query);
            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            
            //return reader;
            while (reader.Read())
            {
                int user_info_id = reader.GetInt32(0);
                string user_name = reader.GetString(1);
                string email = reader.GetString(2);
                string pass = reader.GetString(3);
                string id = reader.GetString(4);
                string dob = reader.GetString(5);



                Session["email"] = email;

                name_label.Text = user_name;
                Session["user_name"] = user_name;
                email_label.Text = email;
                Session["email"] = email;
                id_label.Text = id;
                Session["id"] = id;

                dob_label.Text = dob;
                Session["dob"] = dob;

                Session["user_id"] = user_info_id;
                

            }
        }

        private void get_db_gender()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `gender`.`idgender`,
                            `gender`.`gender`,
                            `gender`.`department_id`
                            FROM `project`.`gender`,`project`.`department`,`project`.`user_info`
                            Where `gender`.`department_id`=`department`.`iddepartment` and
                            `department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`='" + session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            //get_reader(query);
            while (reader.Read())
            {
                int table_id = reader.GetInt32(0);
                string gender = reader.GetString(1);
                int dept_id = reader.GetInt32(2);

                gender_label.Text = gender;
                Session["gender"] = gender;

            }
        }
        /*
        private void get_db_dob()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `dob`.`iddob`,
                            `dob`.`dob`,
                            `dob`.`department_id`
                            FROM `project`.`dob`,`project`.`department`,`project`.`user_info`
                            Where `dob`.`department_id` =`department`.`iddepartment` and
                            `department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`='" + session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();

            //get_reader(query);
            while (reader.Read())
            {
                int t_id = reader.GetInt32(0);
                string dob = reader.GetString(1);
                int dept_id = reader.GetInt32(2);

                dob_label.Text = dob;
                Session["dob"] = dob;
                
                
            }
        }
        */
        private void get_db_marital_status()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `marital_status`.`idmarital_status`,
                            `marital_status`.`marital_status`,
                            `marital_status`.`department_id`
                             FROM `project`.`marital_status`,`project`.`department`,`project`.`user_info`
                             Where`marital_status`.`department_id` =`department`.`iddepartment` and
                            `department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`='" + session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            //get_reader(query);
            while (reader.Read())
            {
                int t_id = reader.GetInt32(0);
                string marital = reader.GetString(1);
                int dept_id = reader.GetInt32(2);

                marital_status_label.Text = marital;
                Session["marital_status"] = marital;

            }
        }

        private void get_db_blood_group()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `blood_group`.`idblood_group`,
                            `blood_group`.`blood_group`,
                            `blood_group`.`department_id`
                             FROM `project`.`blood_group`,`project`.`department`,`project`.`user_info`
                            Where `blood_group`.`department_id`=`department`.`iddepartment` and
                            `department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`='" + session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            // get_reader(query);
            while (reader.Read())
            {
                int t_id = reader.GetInt32(0);
                string blood_group = reader.GetString(1);
                int dept_id = reader.GetInt32(2);

                blood_group_label.Text = blood_group;

                Session["blood_group"] = blood_group;
            }
        }

        private void get_db_pob()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `pob`.`idpob`,
                            `pob`.`pob`,
                            `pob`.`department_id`
                             FROM `project`.`pob`,`project`.`department`,`project`.`user_info`
                            Where `pob`.`department_id`=`department`.`iddepartment` and
                            `department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`='" + session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            //get_reader(query);
            while (reader.Read())
            {
                int t_id = reader.GetInt32(0);
                string pob = reader.GetString(1);
                int dept_id = reader.GetInt32(2);

                pob_label.Text = pob;
                Session["pob"] = pob;
            }
        }

        private void get_db_nationality()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `nationality`.`idnationality`,
                            `nationality`.`nationality`,
                            `nationality`.`department_id`
                            FROM `project`.`nationality`,`project`.`department`,`project`.`user_info`
                            Where `nationality`.`department_id`=`department`.`iddepartment` and
                            `department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`='" + session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            // get_reader(query);
            while (reader.Read())
            {
                int t_id = reader.GetInt32(0);
                string nationality = reader.GetString(1);
                int dept_id = reader.GetInt32(2);

                natiobality_label.Text = nationality;
                Session["nationality"] = nationality;

            }

        }

        private void get_db_department()
        {
            var session_user = Session["user"].ToString();
            string query = @"SELECT `department`.`iddepartment`,
                            `department`.`department`,
                            `department`.`Batch`,
                            `department`.`user_info_id`
                            FROM `project`.`department`,`project`.`user_info`
                            Where`department`.`user_info_id`=`user_info`.`iduser_info` and
                            `user_info`.`name`= '"+ session_user + "';";

            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            // get_reader(query);
            while (reader.Read())
            {
                int depart_id = reader.GetInt32(0);
                string dept = reader.GetString(1);
                string batch = reader.GetString(2);
                int user_id = reader.GetInt32(3);

                department_label.Text = dept;
                Session["department"] = dept;

                batch_label.Text = batch;
                Session["batch"] = batch;

                Session["department_id"] = depart_id;
            }
        }

            /*
         private void get_db_department()
         {
             var session_user = Session["user"].ToString();
             string query = @"SELECT `department`.`iddepartment`,
                             `department`.`department`,
                             `department`.`Batch`,
                             `department`.`user_info_id`
                             FROM `project`.`department`,`project`.`user_info`
                             Where `user_info`.`iduser_info`=`department`.`iduser_info`
                             and `user_info`.`name`='" + session_user + "';";
             MySqlConnection cn = new MySqlConnection(connection_link);
             if (cn.State == ConnectionState.Closed)
             {
                 cn.Open();
             }

             if (cn.State == ConnectionState.Closed)
             {
                 cn.Open();
             }

             MySqlCommand cmd = new MySqlCommand(query, cn);
             MySqlDataReader reader;
             reader = cmd.ExecuteReader();

             while (reader.Read())
             {
                 int depart_id = reader.GetInt32(0);
                 string depart = reader.GetString(1);
                 string batch = reader.GetString(2);
                 int user_id = reader.GetInt32(3);

                 department_label.Text = depart;
                 Session["department"] = depart;

                 batch_label.Text = batch;
                 Session["batch"] = batch;
             }

         }*/
    }
}
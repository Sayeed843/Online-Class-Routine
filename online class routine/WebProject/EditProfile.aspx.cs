using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class EditProfile : System.Web.UI.Page
    {
        Student student = new Student();
        //User user;
        DataOperation db = new DataOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                upload_message_label.Visible = false;
                user_name_label.Text = Session["user_name"].ToString();
                email_label.Text = Session["email"].ToString();
                department_textbox.Text = Session["department"].ToString();
                batch_textbox.Text = Session["batch"].ToString();
                id_textbox.Text = Session["id"].ToString();
                if (Session["dob"] != null)
                {
                    dob_textbox.Text = Session["dob"].ToString();
                }
                
                gender_textbox.Text = Session["gender"].ToString();
                if (Session["marital_status"] != null)
                {
                    marital_textbox.Text = Session["marital_status"].ToString();
                }

                if (Session["blood_group"]!=null)
                {
                    blood_textbox.Text = Session["blood_group"].ToString();
                }

                if (Session["pob"] != null)
                {
                    pob_textbox.Text = Session["pob"].ToString();
                }

                if (Session["nationality"] != null)
                {
                    nationality_textbox.Text = Session["nationality"].ToString();
                }

                image_load();

                /*
                if (Session["image"] != null)
                {
                    image_upload
                }
                */
            }
        }


        private void image_load()
        {
            string query = @"SELECT`user_image`.`image_data`
FROM `project`.`user_image`,`project`.`user_info`
WHERE `user_image`.`user_info_id`=`user_info`.`iduser_info`
and `user_info`.`iduser_info`='"+Session["user_id"].ToString()+"';";

            //age_gridview.DataSource = db.get_data(query);
            //mage_gridview.DataBind();
            //profile_image.ImageUrl= "data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("db.get_data(query)"));
            profile_image.ImageUrl = db.get_data(query).ToString();
        }
        /*
        private void image_upload()
        {
            HttpPostedFile pro_pic = profile_pic_file_upload.PostedFile;
            string pro_pic_name = Path.GetFileName(profile_pic_file_upload.FileName);
            string pro_pic_extension = Path.GetExtension(pro_pic_name);
            int pro_pic_size = pro_pic.ContentLength;

            if(pro_pic_extension.ToLower()==".jpg" || pro_pic_extension.ToLower() == ".bmp" ||
                pro_pic_extension.ToLower() == ".gif" || pro_pic_extension.ToLower() == ".png" )
            {
                Stream stream = pro_pic.InputStream;
                BinaryReader bin_reader = new BinaryReader(stream);
                bin_reader.ReadBytes((int)stream.Length);

                string query = @"INSERT INTO `project`.`user_image`
                            (
                               `user_image`.`image_name`,
                                `user_image`.`image_extension`
                                `user_image`.`image_size`
                                `user_image`.`user_info_id`)" +
                                "(SELECT '"+pro_pic_name+"','"+pro_pic_extension+"','"+pro_pic_size+
                                "',`user_info`.`iduser_info` FROM `project`.`user_info` WHERE `user_info`.`iduser_info`=`user_image`.`iduser_image` );";
                student.db_execute(query);
                

            }
            else
            {
                upload_message_label.Visible = true;
                upload_message_label.Text = "Only images (.jpg, .bmp , .gif, and .png) can be upload";
            }
        }
        */
        private void update_db_image()
        {
            string query = @"SELECT `user_image`.`iduser_image`,
    `user_image`.`image_name`,
    `user_image`.`image_size`,
    `user_image`.`image_data`,
    `user_image`.`user_info_id`
FROM `project`.`user_image`
Where `user_image`.`user_info_id`='"+Session["user_id"].ToString()+"';";

            if (student.db_check(query) > 0)
            {
                HttpPostedFile pro_pic = profile_pic_file_upload.PostedFile;
                string pro_pic_name = Path.GetFileName(profile_pic_file_upload.FileName);
                string pro_pic_extension = Path.GetExtension(pro_pic_name);
                int pro_pic_size = pro_pic.ContentLength;

                if (pro_pic_extension.ToLower() == ".jpg" || pro_pic_extension.ToLower() == ".bmp" ||
                    pro_pic_extension.ToLower() == ".gif" || pro_pic_extension.ToLower() == ".png")
                {
                    Stream stream = pro_pic.InputStream;
                    BinaryReader bin_reader = new BinaryReader(stream);
                    byte[] bytes= bin_reader.ReadBytes((int)stream.Length);



                    string query1 = @"UPDATE `project`.`user_image`,`project`.`user_info`
                                    SET `image_name` = '" + pro_pic_name + "',";
                    query1 += "`image_size` = '" + pro_pic_size + "',";
                    query1 += "`image_data` = '" + bytes + "'";
                    query1 += "WHERE `user_image`.`user_info_id`=`user_info`.`iduser_info`";
                    query1 += "and `user_info`.`iduser_info`= '" + Session["user_id"].ToString() + "';";

                    student.db_execute(query1);
                }
                else
                {
                    upload_message_label.Visible = true;
                    upload_message_label.Text = "Only images (.jpg, .bmp , .gif, and .png) can be upload";
                }
            }
            else
            {
                string query2 = @"INSERT INTO `project`.`user_image`
                                (`user_image`.`user_info_id`)
                                VALUES('" + Session["user_id"].ToString()+"');";

                student.db_execute(query2);

                HttpPostedFile pro_pic = profile_pic_file_upload.PostedFile;
                string pro_pic_name = Path.GetFileName(profile_pic_file_upload.FileName);
                string pro_pic_extension = Path.GetExtension(pro_pic_name);
                int pro_pic_size = pro_pic.ContentLength;

                if (pro_pic_extension.ToLower() == ".jpg" || pro_pic_extension.ToLower() == ".bmp" ||
                    pro_pic_extension.ToLower() == ".gif" || pro_pic_extension.ToLower() == ".png")
                {
                    Stream stream = pro_pic.InputStream;
                    BinaryReader bin_reader = new BinaryReader(stream);
                    bin_reader.ReadBytes((int)stream.Length);

                    string query1 = @"UPDATE `project`.`user_image`,`project`.`user_info`
                                    SET `image_name` = '" + pro_pic_name + "',";
                    query1 += "`image_extension` = '" + pro_pic_extension + "',";
                    query1 += "`image_size` = '" + pro_pic_size + "'";
                    query1 += "WHERE `user_image`.`user_info_id`=`user_info`.`iduser_info`";
                    query1 += "and `user_info`.`iduser_info`= '" + Session["user_id"].ToString() + "';";

                    student.db_execute(query1);
                }
                else
                {
                    upload_message_label.Visible = true;
                    upload_message_label.Text = "Only images (.jpg, .bmp , .gif, and .png) can be upload";
                }
            }
        }

        private string update_db_user_info()
        {
            string query = @"UPDATE `project`.`user_info`
                            SET `id` = '" + id_textbox.Text + "'";
                   query +="WHERE `user_info`.`name` = '"+user_name_label.Text+"';";

            //student.db_execute(query);
            return query;


        }

        private string update_db_department()
        {


            string query = @"UPDATE `project`.`department`,`project`.`user_info`
                            SET
                            `department` = '"+department_textbox.Text
                            +"',`Batch` = '"+batch_textbox.Text
                            +"'WHERE `department`.`user_info_id` = `user_info`.`iduser_info`and `user_info`.`name`='"+user_name_label.Text+"';";

            //student.db_execute(query);
            return query;
        }

        /*
        private string update_db_dob()
        {
            string query = @"SELECT `dob`.`iddob`,
                            `dob`.`dob`,
                            `dob`.`department_id`
                            FROM `project`.`dob`
                            Where `dob`.`department_id`='"+ Session["department_id"].ToString() + "';";
            if (student.db_execute(query) == 1)
            {
                string query2 = @"Update `project`.`user_info`
                            SET `user_info`.`dob` = '" + dob_textbox.Text + "'";
                query += " Where `user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }
            else
            {
                string query1 = @"INSERT INTO `project`.`dob`
                                (`department_id`)
                                VALUES('"+ Session["department_id"].ToString() + "');";
                student.db_execute(query);
                string query2 = @"Update `project`.`user_info`
                            SET `user_info`.`dob` = '" + dob_textbox.Text + "'";
                query += " Where `user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;

            }

            
        }
        */
        private string update_db_gender()
        {


            string query = @"UPDATE `project`.`gender`,`project`.`department`,`project`.`user_info`
                            SET`gender` = '" + gender_textbox.Text + "',`gender`.`department_id`='" + Session["department_id"].ToString() + "'";
            query += "WHERE `gender`.`department_id`= `department`.`iddepartment` and";
            query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
            query +="`user_info`.`name`='" + user_name_label.Text + "';";

            //student.db_execute(query);
            return query;
        }

        private string update_db_marital_status()
        {
            string query = @"SELECT `marital_status`.`idmarital_status`,
    `marital_status`.`marital_status`,
    `marital_status`.`department_id`
FROM `project`.`marital_status`
Where `marital_status`.`department_id`='"+ Session["department_id"].ToString() + "';";

            if (student.db_check(query) > 0)
            {
                string query2 = @"UPDATE `project`.`marital_status`,`project`.`department`,`project`.`user_info`
                            SET `marital_status` = '" + marital_textbox.Text + "',`marital_status`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `marital_status`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }
            else
            {
                string query1 = @"INSERT INTO `project`.`marital_status`
                            (`department_id`)
                            VALUES
                            ('" + Session["department_id"].ToString() + "');";

                student.db_execute(query1);
                string query2 = @"UPDATE `project`.`marital_status`,`project`.`department`,`project`.`user_info`
                            SET `marital_status` = '" + marital_textbox.Text + "',`marital_status`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `marital_status`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }
        }

        private string update_db_blood_group()
        {
            string query = @"SELECT `blood_group`.`idblood_group`,
    `blood_group`.`blood_group`,
    `blood_group`.`department_id`
FROM `project`.`blood_group`
Where `blood_group`.`department_id`= '"+ Session["department_id"].ToString() + "';";

            if (student.db_check(query) > 0)
            {
                string query2 = @"UPDATE `project`.`blood_group`,`project`.`department`,`project`.`user_info`
                            SET `blood_group` = '" + blood_textbox.Text + "',`blood_group`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `blood_group`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }
            else
            {
                string query1 = @"INSERT INTO `project`.`blood_group`
                                (`department_id`)
                                VALUES
                                ('"+ Session["department_id"].ToString() + "');";

                student.db_execute(query1);
                string query2 = @"UPDATE `project`.`blood_group`,`project`.`department`,`project`.`user_info`
                            SET `blood_group` = '" + blood_textbox.Text + "',`blood_group`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `blood_group`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;

            }


        }

        private string update_db_pob()
        {
            string query = @"SELECT `pob`.`idpob`,
    `pob`.`pob`,
    `pob`.`department_id`
FROM `project`.`pob`
Where `pob`.`department_id`='"+ Session["department_id"].ToString() + "';";

            if (student.db_check(query) > 0)
            {

                string query2 = @"UPDATE `project`.`pob`,`project`.`department`,`project`.`user_info`
                            SET `pob` = '" + pob_textbox.Text + "',`pob`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `pob`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }
            else
            {
                string query1 = @"INSERT INTO `project`.`pob`
                                (`department_id`)
                                VALUES
                                ('"+ Session["department_id"].ToString() + "');";

                student.db_execute(query1);

                string query2 = @"UPDATE `project`.`pob`,`project`.`department`,`project`.`user_info`
                            SET `pob` = '" + pob_textbox.Text + "',`pob`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `pob`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and ";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }

        }

        private string update_db_nationality()
        {

            string query = @"SELECT `nationality`.`idnationality`,
    `nationality`.`nationality`,
    `nationality`.`department_id`
FROM `project`.`nationality`
Where `nationality`.`department_id`='"+ Session["department_id"].ToString() + "';";

            if (student.db_check(query) > 0)
            {
                string query2 = @"UPDATE `project`.`nationality`,`project`.`department`,`project`.`user_info`
                            SET `nationality` = '" + nationality_textbox.Text + "',`nationality`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `nationality`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execute(query);
                return query2;
            }
            else
            {
                string query1 = @"INSERT INTO `project`.`nationality`
                                (`department_id`)
                                VALUES
                                ('"+Session["department_id"].ToString()+"');";

                student.db_execute(query1);
                string query2 = @"UPDATE `project`.`nationality`,`project`.`department`,`project`.`user_info`
                            SET `nationality` = '" + nationality_textbox.Text + "',`nationality`.`department_id`='" + Session["department_id"].ToString() + "'";
                query += "WHERE `nationality`.`department_id`= `department`.`iddepartment` and";
                query += "`department`.`user_info_id` = `user_info`.`iduser_info`  and";
                query += "`user_info`.`name`='" + user_name_label.Text + "';";

                //student.db_execut
                return query2;
            }


        }
        protected void Update_button_Click(object sender, EventArgs e)
        {
            //image_upload();

            if (student.db_execute(update_db_user_info()) == 1 &&
               student.db_execute(update_db_department()) == 1 &&

               student.db_execute(update_db_gender()) == 1 &&
               student.db_execute(update_db_marital_status()) == 1 &&
               student.db_execute(update_db_blood_group()) == 1 &&
               student.db_execute(update_db_pob()) == 1 &&
               student.db_execute(update_db_nationality()) == 1)
            {
                update_db_image();
                Response.Redirect("~/Profile.aspx");
            }
            else
            {
                message_label.Text = "Error!!!";
            }

            
        }
    }
}
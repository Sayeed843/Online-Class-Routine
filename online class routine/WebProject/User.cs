using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;


namespace WebProject
{
    abstract public class User
    {
        protected string user_name;
        protected string user_id;
        protected string user_email;
        protected string user_password;
        protected string user_date_of_birth;
        protected string user_place_of_birth;
        protected string user_gender;
        protected string user_marital_status;
        protected string user_blood_group;
        protected string user_nationality;
        protected string user_department;
        protected string user_image;

        DataOperation db = new DataOperation();
        // Open Input Method....................................
        public void input_user_name()
        {
            Console.WriteLine("Name: ");
            user_name = Console.ReadLine();
        }

        public void input_user_id()
        {
            Console.WriteLine("Id: ");
            user_id = Console.ReadLine();
        }

        public void input_user_email()
        {
            Console.WriteLine("Email: ");
            user_email = Console.ReadLine();
        }

        public void input_user_password()
        {
            Console.WriteLine("Password: ");
            user_password = Console.ReadLine();
        }

        public void input_user_date_of_birth()
        {
            Console.WriteLine("Date of birth: ");
            user_date_of_birth = Console.ReadLine();
        }

        public void input_user_place_of_birth()
        {
            Console.WriteLine("Place of Birth: ");
            user_place_of_birth = Console.ReadLine();
        }

        public void input_user_gender()
        {
            Console.WriteLine("Gender: ");
            user_gender = Console.ReadLine();
        }

        public void input_user_marital_status()
        {
            Console.WriteLine("Marital Status: ");
            user_marital_status = Console.ReadLine();
        }

        public void input_user_blood_group()
        {
            Console.WriteLine("Blood Group: ");
            user_blood_group = Console.ReadLine();
        }

        public void input_user_nationality()
        {
            Console.WriteLine("Nationality: ");
            user_nationality = Console.ReadLine();
        }

        public void input_user_department()
        {
            Console.WriteLine("Department");
            user_department = Console.ReadLine();
        }

        // Close input method.................

        // Open set methdo.......................
        public void set_user_name(string name)
        {
            user_name = name;
        }

        public void set_user_id(string id)
        {
            user_id = id;
        }

        public void set_user_email(string email)
        {
            user_email = email;
        }

        public void set_user_password(string password)
        {
            user_password = password;
        }

        public void set_user_date_of_birth(string date_of_birth)
        {
            user_date_of_birth = date_of_birth;
        }

        public void set_user_place_of_birth(string place_of_birth)
        {
            user_place_of_birth = place_of_birth;
        }

        public void set_user_gender(string gender)
        {
            user_gender = gender;
        }

        public void set_marital_status(string marital_status)
        {
            user_marital_status = marital_status;
        }

        public void set_user_blood_group(string blood_group)
        {
            user_blood_group = blood_group;
        }

        public void set_user_nationality(string nationality)
        {
            user_nationality = nationality;
        }

        public void set_user_department(string department)
        {
            user_department = department;
        }

        public void set_user_image(string image)
        {
            user_image =image;
        }

        // Close set method........................................

        //Open get method.................................
        public string get_user_name()
        {
            return user_name;
        }

        public string get_user_id()
        {
            return user_id;
        }

        public string get_user_email()
        {
            return user_email;
        }

        public string get_user_password()
        {
            return user_password;
        }

        public string get_user_date_of_birth()
        {
            return user_date_of_birth;
        }

        public string get_user_place_of_birth()
        {
            return user_place_of_birth;
        }

        public string get_user_gender()
        {
            return user_gender;
        }

        public string get_user_marital_status()
        {
            return user_marital_status;
        }

        public string get_user_blood_group()
        {
            return user_blood_group;
        }

        public string get_user_nationality()
        {
            return user_nationality;
        }

        public string get_user_department()
        {
            return user_department;
        }

        public string get_user_image()
        {
            return user_image;
        }

        //Close get method.................

        //Open print method.................

        public void print_user_name()
        {
            Console.WriteLine("Name: "+ user_name);
        }
  
        public void print_user_id()
        {
            Console.WriteLine("Id: "+ user_id);
        }

        public void print_user_email()
        {
            Console.WriteLine("Email: " + user_email);
        }


        public void print_user_password()
        {
            Console.WriteLine("Password: " + user_password);
        }

        public void print_user_date_of_birth()
        {
            Console.WriteLine("Date of Birth: "+ user_date_of_birth);
        }

        public void print_user_place_if_birth()
        {
            Console.WriteLine("Place of Birth: "+ user_place_of_birth);
        }

        public void print_user_gender()
        {
            Console.WriteLine("Gender: "+ user_gender);
        }

        public void print_user_marital_status()
        {
            Console.WriteLine("Marital Status: "+ user_marital_status);
        }

        public void print_user_blood_group()
        {
            Console.WriteLine("Blood Group: "+ user_blood_group);
        }

        public void print_user_nationality()
        {
            Console.WriteLine("Nationality: " + user_nationality);
        }

        public void print_user_department()
        {
            Console.WriteLine("Department: " + user_department);
        }

        //Close print method..................................


        // other's method.................................
        abstract public void search();

        //DB Operation
        public int db_check(string query)
        {
            return db.db_check(query);
        }

        public DataTable db_get_data(string query)
        {
            return db.get_data(query);
        }

        public MySqlDataReader db_reader(string query)
        {
            return db.get_reader(query);
        }

        public int db_execute(string query)
        {
            return db.execute_data(query);
        }
    }
}
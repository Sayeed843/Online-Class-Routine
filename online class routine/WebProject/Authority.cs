using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebProject
{
    public class Authority
    {
        private string name;
        private string email;
        private string password;

        DataOperation db = new DataOperation(); 

        // Open input method............
        public void input_name()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
        }

        public void input_email()
        {
            Console.WriteLine("Email: ");
            email = Console.ReadLine();
        }

        public void input_password()
        {
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
        }

        //Close input method.............

        // open set method............
        public void set_name(string authority_name)
        {
            name = authority_name;
        }

        public void set_email(string user_email)
        {
            email = user_email;
        }

        public void set_password(string user_password)
        {
            password = user_password;
        }

        //Close set method................
       
        //open get method....................
       
        public string get_name()
        {
            return name;
        }

        public string get_email()
        {
            return email;
        }

        public string get_password()
        {
            return password;
        }

        //Close get method..................


        // open print method................
        public void print_name()
        {
            Console.WriteLine("Name: "+name);
        }

        public void print_email()
        {
            Console.WriteLine("Email: "+email);
        }

        public void print_password()
        {
            Console.WriteLine("Password: "+password);
        }

        // Close print method.............


    }
}
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebProject
{
    public class ClassShedule
    {
        string day;
        string time;
        string room;
        string course;
        DataOperation db = new DataOperation();
        ArrayList day_list = new ArrayList();
        ArrayList class_shedule_list = new ArrayList();
        ArrayList time_list = new ArrayList();

        //private 
        //LinkedList<string> li = new LinkedList<string>();
        //ArrayList li1 = new ArrayList();




        public ClassShedule()
        {
           
            //routine = new LinkedList<string>;
            //DataTable dt = new DataTable();
        }
        public ClassShedule(string day, string time, string room, string course)
        {
            this.day = day;
            this.time = time;
            this.room = room;
            this.course = course;
            
        }

        //Open input method...................
        public void input_day()
        {
            Console.WriteLine("Day: ");
            day = Console.ReadLine();
        }

        public void input_room()
        {
            Console.WriteLine("Room: ");
            room = Console.ReadLine();
        }

        public void input_course()
        {
            Console.WriteLine("Course: ");
            course = Console.ReadLine();
        }

        public void input_time()
        {
            Console.WriteLine("Time: ");
            time = Console.ReadLine();
        }

        //Close input method...................

        //Open set method........................
        public void set_day(string day)
        {
            this.day = day;
        }

        public void set_room(string room)
        {
            this.room = room;
        }

        public void set_course(string course)
        {
            this.course = course;
        }

        public void set_time(string time)
        {
            this.time = time;
        }

        // close set method...................

        // Open get method.....................

        public string get_day()
        {
            return day;
        }

        public string get_room()
        {
            return room;
        }

        public string get_course()
        {
            return course;
        }

        public string get_time()
        {
            return time;
        }
        // Close get method................
        
        //open print method................

        public void print_day()
        {
            Console.WriteLine("Day: "+day);
        }

        public void print_room()
        {
            Console.WriteLine("Room: "+room);
        }

        public void print_course()
        {
            Console.WriteLine("Course: "+course);
        }

        public void print_time()
        {
            Console.WriteLine("Time: " + time);
        }
        // Close print method.............

        //Database method......................

        public DataTable get_data(string query)
        {
            return db.get_data(query);
        }


        
        //Database Method......................

    }
}
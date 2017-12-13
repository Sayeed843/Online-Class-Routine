using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebProject
{
    public class ClassSheduleDynamicTable
    {

        string day;
        string time;
        string room;
        string course;
        string teacher_initial;
        DataTable dt = new DataTable();
        public ClassSheduleDynamicTable()
        {
            
        }

        public DataTable day_column()
        {
            //Day Columns.............
            dt.Columns.Add("",typeof(string));
            //dt.Rows.Add(day);
            return dt;
        }

        public DataTable day_row(string day)
        {
            day = this.day;
            dt.Columns.Add(day);
            return dt;
        }

        public String get_day_column()
        {
            return day;
        }

        public DataTable get_data_table()
        {
            return dt;
        }
        public DataTable time_column(string time)
        {
            //Time Columns..............
            dt.Columns.Add("", typeof(string));
            //dt.Columns.Add(time);
            return dt;
        }

        public DataTable room_course_teacher_column(string room,string course, string teacher)
        {
            dt.Columns.Add("Room", typeof(string));
            dt.Columns.Add("Course", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            return dt;
        }


       
    }
}
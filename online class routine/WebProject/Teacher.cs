using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject
{
    public class Teacher : User
    {
        private string teacher_initial;
        public Teacher(string teacher_initial)
        {
            this.teacher_initial = teacher_initial; 
        }

        public Teacher()
        {

        }
       // private string teacher_initial;
        public override void search()
        {
            throw new NotImplementedException();
        }
        
        public void set_teacher_initial(string teacher_initial)
        {
            this.teacher_initial = teacher_initial;
        }

        public string get_teacher_initial()
        {
            return teacher_initial;
        }
    }
}
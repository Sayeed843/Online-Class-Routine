using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject
{
    public class Student : User
    {

        private string batch;

        DataOperation db = new DataOperation();
        public override void search()
        {
            throw new NotImplementedException();
        }

        public void input_batch()
        {
            Console.WriteLine("Batch");
            batch = Console.ReadLine();
        }

        public void set_batch(string student_batch)
        {
            batch = student_batch;
        }

        public string get_batch()
        {
            return batch; 
        }

        public void print_batch()
        {
            Console.WriteLine("Batch: " + batch);
        }

      

       
    }
}
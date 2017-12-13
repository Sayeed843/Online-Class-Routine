using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;


namespace WebProject
{
    public class DataOperation
    {
        static string connection_link = @"Data Source=localhost; database = project; User ID=root; password='exittimebro'";


        public int execute_data(string query)
        {
            MySqlConnection cn = new MySqlConnection(connection_link);

            if(cn.State== ConnectionState.Closed)
            {
                
                    cn.Open();
                
                //Console.WriteLine("LOL");

            }

            MySqlCommand cmd = new MySqlCommand(query, cn);

            try
            {
                cmd.ExecuteNonQuery();
                cn.Close();
                return 1;
            }
            catch(MySqlException e)
            {
                return 0;
            }
        }

        public DataTable get_data(string query)
        {
            MySqlConnection cn = new MySqlConnection(connection_link);
            if (cn.State == ConnectionState.Closed)
            {
                
                    cn.Open();
                
                
            }

            MySqlDataAdapter da = new MySqlDataAdapter(query, cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int db_check(string query)
        {
            MySqlConnection cn = new MySqlConnection(connection_link);

            if (cn.State == ConnectionState.Closed)
            {

                cn.Open();

            }

            MySqlCommand cmd = new MySqlCommand(query, cn);

            try
            {
                 int output = Convert.ToInt32(cmd.ExecuteScalar());
                
                
                //if(cmd.ExecuteScalar()!=null)
                return output;
            }
            finally
            {
                cn.Close();
            }
            



        }

      public MySqlDataReader get_reader(string query)
        {
            MySqlConnection cn = new MySqlConnection(connection_link);
            if(cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, cn);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                cn.Close();
                return reader;
            }catch(MySqlException e)
            {
                return null;
            }
            
        }
    }

    
}
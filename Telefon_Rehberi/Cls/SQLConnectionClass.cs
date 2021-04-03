using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telefon_Rehberi.Cls
{
    public class SQLConnectionClass
    {
        private static string SQLConnectionString = @"Server = MUSTAFA\SQL2017; Database = Telefon_Rehberi; Trusted_Connection = True;";
        private static SqlConnection con = new SqlConnection();
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand com = new SqlCommand();
        public static SqlException exception = null;

        public static void Baglanti()
        {
            exception = null;
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
                }
            }
        }

        public static object Command(string query)
        {
            exception = null;
            object obj = null;
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand

            try
            {
                obj = com.ExecuteScalar();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }

            return obj;
        }

        public static DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            da.SelectCommand = com; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.GetType().Name + " - " + ex.Message);
            }
            return dt;
        }
    }
}
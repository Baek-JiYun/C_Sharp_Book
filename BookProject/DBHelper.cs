using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    public class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "initial Catalog = {1};" +
                "Integrated Security={2};" +
                "Timeout=3",
                "local", "MYDB1", "SSPI");

            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void selectQuery()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from BookManager";
          
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "BookManager");
            dt = ds.Tables[0];

            conn.Close();
        }

        public static void insertQuery(string isbn, string name, string publisher, int page,int isBorrowed)
        {//도서 추가
            try
            {
                ConnectDB();
               
                string sqlcommand= "Insert into BookManager (Isbn,name,publisher,page,isBorrowed) values(@p1,@p2,@p3,@p4,@p5)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", isbn);
                cmd.Parameters.AddWithValue("@p2", name);
                cmd.Parameters.AddWithValue("@p3", publisher);
                cmd.Parameters.AddWithValue("@p4", page);
                cmd.Parameters.AddWithValue("@p5", isBorrowed);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void updateBookQuery(string isbn, string name, string publisher, int page)
        {
            try
            {
                ConnectDB();

                string sqlcommand = " Update BookManager set Name=@p1,Publisher=@p2,Page=@p3 where Isbn=@p4";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p1", name);
                cmd.Parameters.AddWithValue("@p2", publisher);
                cmd.Parameters.AddWithValue("@p3", page);
                cmd.Parameters.AddWithValue("@p4", isbn);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteQuery(string isbn)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand = "delete from BookManager where Isbn=@p1";

                cmd.Parameters.AddWithValue("@p1",isbn);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

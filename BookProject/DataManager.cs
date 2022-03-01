using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    public class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Books.Clear();
                foreach(DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    Book book = new Book();
                    book.Isbn = item["Isbn"].ToString();
                    book.Name = item["name"].ToString();
                    book.Publisher = item["Publisher"].ToString();
                    book.Page = int.Parse(item["Page"].ToString());
                    book.UserId = item["UserId"].ToString();
                    book.isBorrowed = int.Parse(item["isBorrowed"].ToString());
                    book.BorrowedAt = item["BorrowedAt"].ToString() == "" ? new DateTime() : DateTime.Parse(item["BorrowedAt"].ToString());
                    Books.Add(book);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }

            try
            {
                DBHelper.UserSelectQuery();
                Users.Clear();
                foreach(DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    User user = new User();
                    user.UserId = item["UserId"].ToString();
                    user.Name = item["name"].ToString();
                    Users.Add(user);

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        public static void BookSave(string Isbn,string name,string publisher,int page)
        {
            try
            {
                DBHelper.updateBookQuery(Isbn, name, publisher, page);
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
            }
        }


        public static void BookDelete(string isbn)
        {
            try
            {
                DBHelper.DeleteQuery(isbn);
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
            }
        }

        public static void Save(string isbn, string userId, int isBorrowed)
        {
            try
            {
                DBHelper.updateBorrowQuery(isbn, userId, isBorrowed);
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
            }
        }

        public static void BookSearch(string search_book_Name)
        {
            try
            {
                DBHelper.BookSearch(search_book_Name);
                Books.Clear();
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    Book book = new Book();
                    book.Isbn = item["Isbn"].ToString();
                    book.Name = item["name"].ToString();
                    book.Publisher = item["Publisher"].ToString();
                    book.Page = int.Parse(item["Page"].ToString());
                    book.UserId = item["UserId"].ToString();
                    book.isBorrowed = int.Parse(item["isBorrowed"].ToString());
                    book.BorrowedAt = item["BorrowedAt"].ToString() == "" ? new DateTime() : DateTime.Parse(item["BorrowedAt"].ToString());
                    Books.Add(book);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        public static void UserSearch(string searchUser)
        {
            try
            {
                DBHelper.UserSearch(searchUser);
                Users.Clear();
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    User user = new User();
                    user.UserId = item["UserId"].ToString();
                    user.Name = item["name"].ToString();
                    Users.Add(user);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
    }
}

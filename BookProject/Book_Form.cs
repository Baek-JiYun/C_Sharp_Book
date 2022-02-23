using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject
{
    public partial class Book_Form : Form
    {
        public Book_Form()
        {
            InitializeComponent();
            if (DataManager.Books.Count > 0)
            {
                dataGridView_book.DataSource = DataManager.Books;
            }

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bool existBook = false;

            foreach (var item in DataManager.Books)
            {
                if (item.Isbn == textBox_Isbn.Text)
                {
                    existBook = true;
                    break;
                }
            }
            if (existBook)
            {
                MessageBox.Show("이미 존재하는 도서입니다.");
            }
            else
            {
                Book book = new Book();
                book.Isbn = textBox_Isbn.Text;
                book.Name = textBox_bookName.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);
                book.isBorrowed = 0;

                dataGridView_book.DataSource = null;
                dataGridView_book.DataSource = DataManager.Books;

               DBHelper.insertQuery(textBox_Isbn.Text, textBox_bookName.Text, textBox_publisher.Text, book.Page,book.isBorrowed);
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            Book book = null; // book은 아무데도 가리키지않음.
            for (int i = 0; i < DataManager.Books.Count; i++)
            {
                if (DataManager.Books[i].Isbn == textBox_Isbn.Text)
                {
                    book = DataManager.Books[i];//Books의 i번째를 가리키게 됨 (얕은 복사 = 참조복사)
                    book.Isbn = textBox_Isbn.Text;
                    book.Name = textBox_bookName.Text; //book의 값이 변경되면 books의 i번째꺼가 값이 변경됨
                    book.Publisher = textBox_publisher.Text;
                    book.Page = int.Parse(textBox_page.Text);

                    dataGridView_book.DataSource = null;
                    dataGridView_book.DataSource = DataManager.Books;
                    DataManager.BookSave(book.Isbn,book.Name,book.Publisher,book.Page);
                }
            }
            if (book == null)
                MessageBox.Show("존재하지 않는 도서입니다.");

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Book book = null;
            bool existBook = false;
            for (int i = 0; i < DataManager.Books.Count; i++)
            {
                if (DataManager.Books[i].Isbn == textBox_Isbn.Text)
                {

                    book=DataManager.Books[i];
                    book.Isbn= textBox_Isbn.Text;

                    DataManager.BookDelete(book.Isbn);
                    existBook=true;

                }
            }
            if (existBook == false)
                MessageBox.Show("존재하지 않는 도서입니다.");
            else
            {
                dataGridView_book.DataSource = null;
                if (DataManager.Books.Count > 0)
                    dataGridView_book.DataSource = DataManager.Books;
            }
        }
        private void dataGridView_book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_book.CurrentRow.DataBoundItem as Book;
            textBox_Isbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
            textBox_publisher.Text = book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }   
    }
}

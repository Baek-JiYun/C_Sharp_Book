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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (DataManager.Books.Count > 0)
            {
                dataGridView_bookManager.DataSource = DataManager.Books;
            }
            if(DataManager.Users.Count > 0)
            {
                dataGridView_user.DataSource = DataManager.Users;
            }

        }
        private void ReLoad()
        {
            DataManager.Load();
            dataGridView_bookManager.DataSource = null;
            dataGridView_bookManager.DataSource = DataManager.Books;
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Book_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_bookManager.CurrentRow.DataBoundItem as Book;
            textBox_Isbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
        }

        private void bookManager_Click(object sender, EventArgs e)
        {
            new Book_Form().ShowDialog();

            DataManager.Load();
            dataGridView_bookManager.DataSource = null;
            if (DataManager.Books.Count > 0)
                dataGridView_bookManager.DataSource = DataManager.Books;
        }

        private void userManager_Click(object sender, EventArgs e)
        {
            new User_Form().ShowDialog();

            DataManager.Load();
            dataGridView_user.DataSource = null;
            if (DataManager.Users.Count > 0)
                dataGridView_user.DataSource = DataManager.Users;
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if (textBox_Isbn.Text.Trim() == "")
                MessageBox.Show("Isbn을 입력하세요.");
            else if (textBox_userId.Text.Trim()=="")
                MessageBox.Show("사용자 Id를 입력하세요.");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed == 0) //대여 가능
                    {
                        User user = DataManager.Users.Single((x) => x.UserId.ToString() == textBox_userId.Text);
                        book.Isbn = textBox_Isbn.Text;
                        book.UserId = user.UserId;
                        book.isBorrowed = 1;

                        dataGridView_bookManager.DataSource = null;
                        dataGridView_bookManager.DataSource = DataManager.Books;
                        DataManager.Save(book.Isbn, book.UserId, book.isBorrowed);
                        MessageBox.Show($"{user.Name}님께 정상 대여되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("현재 대여중인 도서입니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 혹은 사용자입니다.");
                }
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if (textBox_Isbn.Text.Trim() == "")
                MessageBox.Show("isbn을 입력하세요.");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed == 1) // 대여된 상태
                    {
                        DateTime date = book.BorrowedAt;
                        book.Isbn = textBox_Isbn.Text;
                        book.isBorrowed=0;

                        DataManager.Save(book.Isbn, "", book.isBorrowed);
                        
                        TimeSpan timeDiff = DateTime.Now - date;
                        if(timeDiff.Days > 7)
                        {
                            MessageBox.Show(timeDiff.Days+"일 연체된 도서입니다.");
                        }
                        else
                        {
                            MessageBox.Show("정상반납 되었습니다.");

                            DataManager.Load();

                            dataGridView_bookManager.DataSource = null;
                            dataGridView_bookManager.DataSource = DataManager.Books;
                        }
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.\n다시 확인해주세요.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Isbn을 다시 확인해주세요.");
                }

            }
        }
    }
}

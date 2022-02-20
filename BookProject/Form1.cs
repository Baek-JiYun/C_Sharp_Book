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
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bookManeger_Click(object sender, EventArgs e)
        {
            new Book_Form().ShowDialog();

            DataManager.Load();
            dataGridView_bookManager.DataSource = null;
            if (DataManager.Books.Count > 0)
                dataGridView_bookManager.DataSource = DataManager.Books;
        }
    }
}

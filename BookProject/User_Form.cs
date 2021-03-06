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
    public partial class User_Form : Form
    {
        public User_Form()
        {
            InitializeComponent();
            if(DataManager.Users.Count > 0)
            {
                dataGridView_user.DataSource = DataManager.Users;
            }
            dataGridView_user.CellClick += user_cellclick;
        }
        private void ReLoad()
        {
            DataManager.Load();           

            dataGridView_user.DataSource = null;
            if (DataManager.Users.Count > 0)
                dataGridView_user.DataSource = DataManager.Users;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bool userchk = false;

            foreach(var item in DataManager.Users)
            {
                if(item.UserId.Equals(textBox_Id))
                {
                    userchk = true;
                    break;
                }
            }
            if (userchk)
            {
                MessageBox.Show("이미 존재하는 ID입니다.");
            }
            else
            {
                User user = new User();
                user.UserId = textBox_Id.Text;
                user.Name = textBox_Name.Text;

                DBHelper.insertUserQuery(textBox_Id.Text, textBox_Name.Text);

                ReLoad();
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            User user = null;
            for(int i = 0;i< DataManager.Users.Count; i++)
            {
                if (DataManager.Users[i].UserId.Equals(textBox_Id.Text))
                {
                    user = DataManager.Users[i];
                    user.UserId=textBox_Id.Text;
                    user.Name=textBox_Name.Text;

                    DBHelper.updateUserQuery(user.UserId, user.Name);

                    ReLoad();
                }
            }
            if(user == null)
            {
                MessageBox.Show("존재하지 않는 ID입니다.");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            User user = null;

            for(int i = 0; i< DataManager.Users.Count; i++)
            {
                if (DataManager.Users[i].UserId.Equals(textBox_Id.Text))
                {
                    user= DataManager.Users[i];
                    user.UserId =textBox_Id.Text;

                    DBHelper.UserDeleteQuery(user.UserId);

                    ReLoad();
                }
            }
            if(user==null)
                MessageBox.Show("존재하지 않는 ID입니다");
        }
        private void user_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            User user = dataGridView_user.CurrentRow.DataBoundItem as User;
            textBox_Id.Text = user.UserId;
            textBox_Name.Text = user.Name;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchUser = textBox_search.Text.Trim();
            bool chkUser = false;
            if(textBox_search.Text.Trim() =="")
                MessageBox.Show("ID를 입력해주세요");
            else
            {
                for(int i = 0; i<DataManager.Users.Count; i++)
                {
                    if(DataManager.Users[i].UserId == textBox_search.Text)
                    {
                        DataManager.UserSearch(searchUser);
                        chkUser = true;
                    }
                }
                if (chkUser == false)
                {
                    MessageBox.Show("조회된 사용자가 없습니다.");
                }
                else
                {
                    dataGridView_user.DataSource = null;
                    if(DataManager.Users.Count > 0)
                        dataGridView_user.DataSource=DataManager.Users;
                }
            }
        }
    }
}

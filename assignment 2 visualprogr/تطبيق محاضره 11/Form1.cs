using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace تطبيق_محاضره_11
{
    public partial class Form1 : Form
    {
        private user user1;
        private user user2;
        private user user3;
        private List<user> users;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user1 = new user();
            user1.userid = 2;
            user1.password = "9876";
            user1.username = "amneh";
            user1.fullname = "amneh alkhaldi";

            user2 = new user();
            user2.userid = 1;
            user2.password = "5432";
            user2.username = "muhammad";
            user2.fullname = "muhammad m";

            user3 = new user();
            user3.userid = 0;
            user3.password = "1111";
            user3.username = "iyad";
            user3.fullname = "iyad ss";

            users = new List<user>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);



        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (user1.username == txtusername.Text)
            {
                if (user1.username == txtusername.Text && user1.password == txtpassword.Text)
                {
                    MessageBox.Show(user1.fullname);
                }
                else if (user1.password != txtpassword.Text)
                {
                    MessageBox.Show("wrong password");
                }
            }
            else if (user2.username == txtusername.Text)
            {
                if (user2.username == txtusername.Text && user2.password == txtpassword.Text)
                {
                    MessageBox.Show(user2.fullname);
                }
                else if (user2.password != txtpassword.Text)
                {
                    MessageBox.Show("wrong password");
                }
            }
            else if (user3.username == txtusername.Text)
            {
                if (user3.username == txtusername.Text && user3.password == txtpassword.Text)
                {
                    MessageBox.Show(user3.fullname);
                }
                else if (user3.password != txtpassword.Text)
                {
                    MessageBox.Show("wrong password");
                }
            }
            else
            {
                MessageBox.Show("user does not exist");

            }

        }
    }
}

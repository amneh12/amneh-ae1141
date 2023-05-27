using project.Admin_Form;
using project.Casher_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmLogin : Form
    {
        string Data = "Data Source=DESKTOP-SV7JT22;Initial Catalog=Project-db;Integrated Security=True";
        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Data);
            SqlDataAdapter sqldt = new SqlDataAdapter("select * from Admin where UserName= '" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'", conn);
            DataTable datat = new DataTable();
            sqldt.Fill(datat);
            if (datat.Rows.Count > 0)
            {
                AHomePage ahomePage = new AHomePage(txtUserName.Text);
                ahomePage.Show();
            }
            else
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Casher where UserName= '" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'", conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    CHomePage chomePage = new CHomePage(txtUserName.Text);
                    chomePage.Show();
                }
                else
                {
                    MessageBox.Show("username or password is worng");
                }
            }
        }
    }
}

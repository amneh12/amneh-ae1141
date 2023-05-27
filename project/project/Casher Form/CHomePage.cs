using project.Admin_Form.ChangeSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Casher_Form
{
    public partial class CHomePage : Form
    {
        string Data = "Data Source=DESKTOP-SV7JT22;Initial Catalog=Project-db;Integrated Security=True";

        private string casher;
        public CHomePage(string _casher)
        {
            InitializeComponent();
            casher = _casher;
            LoadData();
        }
        private void CHomePage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + casher;
        }
        public void LoadData()
        {
            int x = 30;
            int y = 30;
            int counter = 0;

            SqlConnection conn = new SqlConnection(Data);
            conn.Open();
            string query = "SELECT FoodName, Price, DateSale FROM Sales";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                string column1Value = reader.GetString(0);
                int column2Value = reader.GetInt32(1);
                DateTime column3Value = reader.GetDateTime(2);

                Panel paneln = new Panel();
                paneln.Size = new Size(200, 150);
                paneln.BackColor = Color.LightBlue;
                panel3.Controls.Add(paneln);

                counter++;
                paneln.Location = new Point(x, y);
                x += paneln.Width + 5;

                if (counter == 5)
                {
                    y += paneln.Height + 10;
                    x = 30;
                    counter = 0;
                }

                //label Name
                Label labelname = new Label();
                labelname.Location = new Point(19, 20);
                labelname.Text = "FoodName: " + column1Value;
                paneln.Controls.Add(labelname);

                //labe Price
                Label labelprice = new Label();
                labelprice.Location = new Point(19, 45);
                labelprice.Text = "Price: " + Convert.ToString(column2Value);
                paneln.Controls.Add(labelprice);

                // labe Date
                Label labeldate = new Label();
                DateTimePicker date = new DateTimePicker();
                labeldate.Location = new Point(19, 70);
                date.Value = column3Value;
                labeldate.Text = "Date: " + column3Value;
                paneln.Controls.Add(labeldate);

                /////////////////////////////////////////////////
                panel3.Controls.Add(paneln);
            }

            reader.Close();
            conn.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSale addSale = new AddSale();
            addSale.TopLevel = false;
            addSale.Dock = DockStyle.Fill;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(addSale);
            addSale.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSale updateSale = new UpdateSale();
            updateSale.TopLevel = false;
            updateSale.Dock = DockStyle.Fill;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(updateSale);
            updateSale.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSale deleteSale = new DeleteSale();
            deleteSale.TopLevel = false;
            deleteSale.Dock = DockStyle.Fill;
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(deleteSale);
            deleteSale.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btncreatemployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();

            newEmployee.Id = int.Parse(txtid.Text);
            newEmployee.Name = txtname.Text;
            newEmployee.DateOfBirth = DTP.Value;

            MessageBox.Show(newEmployee.EmployeeInfo());
        }

        private void btnCreateTextBox_Click(object sender, EventArgs e)
        {
            TextBox newtextBox = new TextBox();
            newtextBox.Text = "new text box";
            newtextBox.Location = new Point(0, 0);
            newtextBox.Size = new Size(100, 40);
            newtextBox.Name = "newtextbox";
            panel1.Controls.Add(newtextBox);
            
        }
    }
}

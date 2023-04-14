using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCountry.Items.Add("Jordan");
            cmbCountry.Items.Add("Syria");
            cmbCountry.Items.Add("Iraq");
            cmbCountry.Items.Add("Palestine");

        }

        // To write numbers only
        private void txtNationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //To type letters only
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLower(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //to display cities
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = cmbCountry.SelectedItem.ToString();
            if (selectedCountry == "Jordan")
            {
                cmbCity.Items.AddRange(new string[] { "Amman", "Zarqa", "Aqaba" });
            }
            else if (selectedCountry == "Syria")
            {
                cmbCity.Items.AddRange(new string[] { "Damascus", "Homs", "Latakia" });
            }
            else if (selectedCountry == "Iraq")
            {
                cmbCity.Items.AddRange(new string[] { "Baghdad", "Basra", "Erbil" });
            }
            else if (selectedCountry == "Palestine")
            {
                cmbCity.Items.AddRange(new string[] { "Beersheba", "Gaza", "Jerusalem" });
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int nationalnumber;
            string gender;
            string skills = "";
            string name;
            string Country;
            string City;
            //Read A National Number
            nationalnumber = Convert.ToInt32(txtNationalNumber.Text);

            //Read A Name
            name = txtName.Text;

            // Read A Date of Birth
            DateTime dateOfBirth = dateTimePicker1.Value;
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Today.AddYears(-age)) age--;

            if (age >= 22)
            {
                dateOfBirth = dateTimePicker1.Value;
            }
            else
            {
                MessageBox.Show("Your age is not allowed to register");
            }

            // Read A Country of Residence
            Country = cmbCountry.Text;

            string country = cmbCountry.SelectedItem.ToString();

            // Read A City of Residence
            City = cmbCity.Text;

            //Read A Gender
            if (rbtnMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            //Read A Skills
            if (chbxprogramming.Checked == true)
                skills += chbxprogramming.Text + "\n";

            if (chbxwebdesign.Checked == true)
                skills += chbxwebdesign.Text + "\n";

            if (chbxUI_UX.Checked == true)
                skills += chbxUI_UX.Text + "\n";

            // Print a summary message of all the information added.
            MessageBox.Show("\n National Number: " + nationalnumber + "\n Name: " + name + "\n Date of Birth: " + dateOfBirth + "\n Country of residence: " + Country + "\n City: " + City + "\n Gender: " + gender + "\n Skills: " + skills);
        }


    }
}
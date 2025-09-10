using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrganizationProfile : Form
    {
        public OrganizationProfile()
        {
            InitializeComponent();

            // Fill combobox with sample college courses
            cboProgram.Items.AddRange(new string[]
            {
                "BS Computer Science",
                "BS Information Technology",
                "BS Information Systems",
                "BS Software Engineering",
                "BS Data Science",
                "BS Civil Engineering",
                "BS Electrical Engineering",
                "BS Mechanical Engineering",
                "BS Architecture",
                "BS Accountancy",
                "BS Business Administration",
                "BS Marketing Management",
                "BS Psychology",
                "BS Nursing",
                "BS Medical Technology",
                "BS Pharmacy",
                "BS Biology",
                "BS Mathematics",
                "BA Communication",
                "BA Political Science",
                "BA Economics",
                "BA English Language Studies",
                "Bachelor of Elementary Education",
                "Bachelor of Secondary Education"
            });

            // Optional: Select first item by default
            if (cboProgram.Items.Count > 0)
                cboProgram.SelectedIndex = 0;

            cbGender.Items.AddRange(new string[]
            {
                "Male",
                "Female"
            });

            if (cbGender.Items.Count > 0)
                cbGender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign textbox/combobox values to static variables
                StudentInfoClass.Program = cboProgram.Text;
                StudentInfoClass.FirstName = txtFirstName.Text;
                StudentInfoClass.LastName = txtLastName.Text;
                StudentInfoClass.MiddleName = txtMiddleName.Text;
                StudentInfoClass.Birthday = Birthday.Text;
                StudentInfoClass.Gender = cbGender.Text;

                StudentInfoClass.Age = long.TryParse(txtAge.Text, out long age) ? age : 0;
                StudentInfoClass.ContactNo = long.TryParse(txtContactNo.Text, out long contact) ? contact : 0;
                StudentInfoClass.StudentNo = long.TryParse(txtStudentNo.Text, out long studNo) ? studNo : 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Student Number, Age, and Contact Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large. Please enter a smaller value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation dialog
            FrmConfirm frm = new FrmConfirm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration confirmed!", "Success");

                // Clear all textboxes and reset combo boxes
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).Clear();
                    else if (ctrl is ComboBox)
                        ((ComboBox)ctrl).SelectedIndex = -1;
                }

                // Optional: Reset selections
                if (cboProgram.Items.Count > 0)
                    cboProgram.SelectedIndex = 0;
                if (cbGender.Items.Count > 0)
                    cbGender.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please input in the fields mentioned.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event stubs (optional to implement or delete if unused)
        private void txtFirstName_TextChanged(object sender, EventArgs e) { }

        private void txtContactNo_TextChanged(object sender, EventArgs e) { }

        private void Birthday_Click(object sender, EventArgs e) { }

        private void lblGender_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}



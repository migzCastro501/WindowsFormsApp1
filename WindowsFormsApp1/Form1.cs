﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assign textbox/combobox values to static variables
            StudentInfoClass.Program = cboProgram.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Birthday = Birthday.Text;
            StudentInfoClass.Gender = Gender.Text;

            StudentInfoClass.Age = long.TryParse(txtAge.Text, out long age) ? age : 0;
            StudentInfoClass.ContactNo = long.TryParse(txtContactNo.Text, out long contact) ? contact : 0;
            StudentInfoClass.StudentNo = long.TryParse(txtStudentNo.Text, out long studNo) ? studNo : 0;

            // Open FrmConfirm as dialog
            FrmConfirm frm = new FrmConfirm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration confirmed!", "Success");
            }
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Birthday_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _05LabExcer1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
        string[] gender = new string[] { "Male", "Female" };
        for (int x = 0; x < 2; x++) {
                cbGender.Items.Add(gender[x]);
            }
            string[] program = new string[] {"BS Information Technology","BS Hotel Management","BS Civil Engineering"};
            for (int x = 0; x < 3; x++) {
                cbProgram.Items.Add(program[x]);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string StudentNo = "Student NO.: ";
            string FullName = "Full Name: ";
            string Program = "Program: ";
            string Gender = "Gender: ";
            string Age = "Age: ";
            string Birthday = "Birthday: ";
            string Contact = "Contact No.: ";
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter output = new StreamWriter(Path.Combine(filepath, txtStudentNo.Text+".txt")))
            {
                output.WriteLine(StudentNo + txtStudentNo.Text);
                output.WriteLine(FullName +txtLastName.Text+" "+txtFirstName.Text+" "+txtMI.Text+".");
                output.WriteLine(Program + cbProgram.SelectedItem.ToString());
                output.WriteLine(Gender + cbProgram.SelectedItem.ToString());
                output.WriteLine(Age + txtAge.Text);
                output.WriteLine(Birthday + datepickerBirthday.Text);
                output.WriteLine(Contact + txtContactNo.Text);
            }
        }
    }
}

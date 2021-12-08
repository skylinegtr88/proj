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
    public partial class FrmStudentRecord : Form
    {
        public static string path;
        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        //Register
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration fg= new FrmRegistration();
            fg.ShowDialog(); 
        }
        //Upload
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            listView1.Clear();
        }
        //Find
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\alvin\Documents\05LabActivity";
            openFileDialog1.Title = "Student Records";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    listView1.Items.Add(_getText);
                }
            }
        }
    }
}

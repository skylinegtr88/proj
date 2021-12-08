using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05LabExcer1
{
    public partial class FrmFileName : Form
    {
        public static String SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }
        
        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class RegisteredSubjectDetails : Form
    {
        public RegisteredSubjectDetails(string details)
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            label1.Text = details;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

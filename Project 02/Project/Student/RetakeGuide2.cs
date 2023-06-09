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
    public partial class RetakeGuide2 : Form
    {
        

        public RetakeGuide2()
        {
            InitializeComponent();
        }

        private void RetakeGuide2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }
    }
}

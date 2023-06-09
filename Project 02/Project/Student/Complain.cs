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
    public partial class Complain : Form
    {
        public Complain()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataProvider.setComplain(richTextBox1.Text, "Annonymas"))
            {
                MessageBox.Show("Your complain is granted as annonymas.. Thank you !!");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }

            StudentHome.current.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataProvider.setComplain(richTextBox1.Text, StudentHome.sid))
            {
                MessageBox.Show("Your complain is granted.. We will contact with you soon !!");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }

            StudentHome.current.Show();
            this.Hide();
        }

        private void Complain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }
    }
}

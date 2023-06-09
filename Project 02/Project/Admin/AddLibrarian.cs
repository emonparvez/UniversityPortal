using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.Admin
{
    public partial class AddLibrarian : Form
    {
        public AddLibrarian()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            textBox1.Text = DataProvider.generateAdminID().ToString();
            textBox4.Text = DataProvider.generatePassword();

            comboBox2.SelectedIndex = 0;

        }

        private void AddLibrarian_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome.curret.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            if (DataProvider.addLibrarian(i, textBox2.Text, textBox4.Text, comboBox2.SelectedItem.ToString(), textBox9.Text, textBox5.Text))
            {
                MessageBox.Show("Librarian Added...");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }
            Update();
        }
    }
}

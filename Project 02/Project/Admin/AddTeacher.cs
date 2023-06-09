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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            update();
        }

        public void update()
        {
            textBox1.Text = DataProvider.generateTeacherID();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = DataProvider.generatePassword();
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0; 
        }

        private void AddTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataProvider.addTeachers(textBox1.Text, textBox2.Text, textBox3.Text, comboBox3.SelectedItem.ToString(), textBox4.Text, comboBox2.SelectedItem.ToString(), textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, Convert.ToInt32(textBox5.Text)))
            {
                MessageBox.Show("Added Teacher....");

            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }
            update();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome.curret.Show();
            this.Hide();
        }
    }
}

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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            update();

        }

        public void update()
        {
            textBox1.Text = DataProvider.generateStudentID();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = DataProvider.generatePassword();
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            textBox10.Text = "13";
            textBox11.Text = "17";
            textBox12.Text = "20";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

            comboBox1.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int slot = comboBox1.SelectedIndex + 1;
            string newSlot = slot.ToString();

            string str = textBox1.Text;
            str = str.Remove(str.Length - 1, 1) + newSlot;

            textBox1.Text = str;
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome.curret.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataProvider.AddStudents(textBox1.Text, textBox2.Text, textBox3.Text,comboBox3.SelectedItem.ToString(), textBox4.Text, comboBox2.SelectedItem.ToString(), textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text))
            {
                MessageBox.Show("Student added...");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }

            update();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

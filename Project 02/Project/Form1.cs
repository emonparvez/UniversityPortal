using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project.Admin;
using Project.Librarian;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            Type_combo.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Type_combo.SelectedItem.ToString() == "Student")
            {
                if (DataProvider.checkValidity(ID_txt.Text, Password_txt.Text, Type_combo.SelectedItem.ToString()))
                { 
                    StudentHome studentHome = new StudentHome(ID_txt.Text);
                    studentHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username & password...");
                }
            }

            else if (Type_combo.SelectedItem.ToString() == "Teacher")
            {
                //Teacher
            }
            else if (Type_combo.SelectedItem.ToString() == "Admin")
            {
                if (DataProvider.checkValidity(ID_txt.Text, Password_txt.Text, Type_combo.SelectedItem.ToString()))
                {
                    int i = Convert.ToInt32(ID_txt.Text);
                    AdminHome ah = new AdminHome(i);
                    ah.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username & password...");
                }
            }
            else if (Type_combo.SelectedItem.ToString() == "Librarian")
            {
                if (DataProvider.checkValidity(ID_txt.Text, Password_txt.Text, Type_combo.SelectedItem.ToString()))
                {
                    int i = Convert.ToInt32(ID_txt.Text);
                    LibrarianHome l = new LibrarianHome(i);
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username & password...");
                }
            }

            else if(Type_combo.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please select a type....");
            }
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

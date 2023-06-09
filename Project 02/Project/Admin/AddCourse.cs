using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project.Admin
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            textBox1.Text = DataProvider.generateCourseID().ToString();
            fillComboBox();
        }

        private void fillComboBox()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.course;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    comboBox2.Items.Add(myReader.GetString("Name"));
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void AddCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int preReq = comboBox2.SelectedIndex;
            int id = Convert.ToInt32(textBox1.Text);
            int credit = Convert.ToInt32(textBox3.Text);
            if (DataProvider.addCourse(id, textBox2.Text, credit, comboBox1.SelectedItem.ToString(), preReq))
            {
                MessageBox.Show("Course Added...");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome.curret.Show();
            this.Hide();
        }
    }
}

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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();

            comboBox1.SelectedValueChanged += OnSelectedIndexChanged;
            
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity." + comboBox1.SelectedItem.ToString() + ";", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    comboBox2.Items.Add(myReader.GetString(comboBox1.SelectedItem.ToString() + "ID"));
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        

        private void Delete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataProvider.delete(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString()))
            {
                MessageBox.Show("Successfully deleted....");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome.curret.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

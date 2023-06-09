using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class GradesBySemester : Form
    {
        public GradesBySemester()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            setSemesterCombo();
        }

        public void setSemesterCombo()
        {
            string sem = "";
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.semester;", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    sem = myReader.GetString("Name");
                    comboBox1.Items.Add(sem);
                }
                myConn.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }﻿
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }

        private void GradesBySemester_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            label5.Text = DataProvider.getGradeBySemester(comboBox1.SelectedItem.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            updateTable("Start","");
        }

        public void updateTable(string str,string rest)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand cmdDatabase=null;

                if (str == "Start")
                {
                    cmdDatabase = new MySqlCommand("select * from myuniversity.library ;", myConn);
                }
                else if (str == "By Book")
                {
                    cmdDatabase = new MySqlCommand("select * from myuniversity.library where BookName like'%"+rest+"%';", myConn);
                }

                else if (str == "By Author")
                {
                    cmdDatabase = new MySqlCommand("select * from myuniversity.library where Author like'%" + rest + "%';", myConn);
                }

                else if (str == "By Type")
                {
                    cmdDatabase = new MySqlCommand("select * from myuniversity.library where Type='" + rest + "';", myConn);   
                } 

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDatabase;

                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dataSet;
                dataGridView1.DataSource = bSource;

                dataAdapter.Update(dataSet);

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            StudentHome.current.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateTable("By Book", textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedItem = null;
            
            updateTable("Start", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateTable("By Author", textBox2.Text);
        }

        private void Library_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Study")
            {
                updateTable("By Type", "Study");
            }
            else if (comboBox1.SelectedItem.ToString() == "Novel")
            {
                updateTable("By Type", "Novel");
            }
        }
    }
}

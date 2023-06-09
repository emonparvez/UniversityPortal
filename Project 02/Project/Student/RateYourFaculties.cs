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
    public partial class RateYourFaculties : Form
    {
        public RateYourFaculties()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            setTeacherComboBox();
        }

        private void setTeacherComboBox()
        {
            for (int i = 0; i < 8; i++)
            {
                if (StudentHome.student.sTeacherID[i] != "0")
                {
                    string fn = "";
                    string ln = "";
                    try
                    {
                        string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                        MySqlConnection myConn = new MySqlConnection(myConnection);
                        myConn.Open();
                        MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.teacher where TeacherID = '" + StudentHome.student.sTeacherID[i] + "' ;", myConn);

                        MySqlDataReader myReader;

                        myReader = SelectCommand.ExecuteReader();

                        if (myReader.Read())
                        {
                            fn = myReader.GetString("FirstName");
                            ln = myReader.GetString("LastName");

                            ln = fn + " " + ln;

                            ComboTeacher t = new ComboTeacher(StudentHome.student.sTeacherID[i], ln);

                            comboBox1.Items.Add(t);
                        }
                        myConn.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
                ﻿
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string teacher_id = (comboBox1.SelectedItem as ComboTeacher).tID;
            int r = comboBox2.SelectedIndex + 1;

            if (DataProvider.ifRated(StudentHome.sid, teacher_id))
            {
                MessageBox.Show("You already have rated him...");
            }
            else
            {
                if (DataProvider.setTeacherRating(teacher_id, r))
                {
                    MessageBox.Show("Thank for your rating...");
                }
                
            }
        }

        private void RateYourFaculties_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    
}

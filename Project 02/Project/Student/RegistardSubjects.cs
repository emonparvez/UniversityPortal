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
    public partial class RegistardSubjects : Form
    {
        public RegistardSubjects()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
        }

        private void RegistardSubjects_Load(object sender, EventArgs e)
        {
            label1.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[0]);
            label2.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[1]);
            label3.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[2]);
            label4.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[3]);
            label5.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[4]);
            label6.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[5]);
            label7.Text = DataProvider.getCourseNameByClassID(StudentHome.student.sClassID[6]);


            if (label1.Text == "0")
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else if (label2.Text == "0")
            {
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else if (label3.Text == "0")
            {
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else if (label4.Text == "0")
            { 
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else if (label5.Text == "0")
            {
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
            }
            else if (label6.Text == "0")
            {
                button7.Visible = false;
                button8.Visible = false;
            }
            else if (label7.Text == "0")
            {
                button8.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[0]));
            rsd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[1]));
            rsd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[2]));
            rsd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[3]));
            rsd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[4]));
            rsd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[5]));
            rsd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegisteredSubjectDetails rsd = new RegisteredSubjectDetails(DataProvider.getClassDetailsByClassID(StudentHome.student.sClassID[6]));
            rsd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }

        private void RegistardSubjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

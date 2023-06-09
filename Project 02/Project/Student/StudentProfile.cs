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
    public partial class StudentProfile : Form
    {
        public static StudentProfile curret;
        public StudentProfile()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            curret = this;
            pictureBox1.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal)
             + @"\"+StudentHome.sid+".jpg");

            label10.Text = StudentHome.student.sFirstName + " " + StudentHome.student.sLastName;
            label11.Text = StudentHome.student.sAddress;
            label12.Text = StudentHome.student.sGender;
            label13.Text = StudentHome.student.sTelephone;
            label14.Text = StudentHome.student.sEmail;
            label15.Text = StudentHome.student.sID;
            label16.Text = StudentHome.student.sCGPA.ToString();
            label17.Text = "0";
            label18.Text = StudentHome.student.sDepartment;
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudentProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
            
        }
    }
}

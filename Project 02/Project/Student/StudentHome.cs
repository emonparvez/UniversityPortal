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
    public partial class StudentHome : Form
    {
        public static StudentHome current;
        public static string sid;
        int[] classIDs;
        public static Student student;
        
        public StudentHome(string sids)
        {
            InitializeComponent();
            current = this;
            BackColor = Color.DarkGray;
            sid = sids;

            student = new Student(sid, 
                DataProvider.getSFName(),
                DataProvider.getSLName(),
                DataProvider.getSDepartment(),
                DataProvider.getSPassword(),
                DataProvider.getSGender(),
                DataProvider.getSAddress(),
                DataProvider.getSNID(),
                DataProvider.getSCgpa(),
                DataProvider.getSTelephone(),
                DataProvider.getSEmail(),
                DataProvider.getClassIDs(),
                DataProvider.getSCredit()
                );

            student.setTeacherIDs();

            classIDs = student.sClassID;
            
            setRoutine();
            DayOfWeek day = DateTime.Now.DayOfWeek;
            if (day.ToString() == "Sunday")
            {
                Sunday_txt.BackColor = Color.Orange;
            }
            else if (day.ToString() == "Monday")
            {
                Monday_txt.BackColor = Color.Orange;
            }
            else if (day.ToString() == "Tuesday")
            {
                Tuesday_txt.BackColor = Color.Orange;
            }
            else if (day.ToString() == "Wednesday")
            {
                Wednesday_txt.BackColor = Color.Orange;
            }
            else if (day.ToString() == "Thursday")
            {
                Thursday_txt.BackColor = Color.Orange;
            }
        }

        

        private void setRoutine()
        {
            for (int i = 0; i < 8; i++)
            {
                if (DataProvider.checkSunday(classIDs[i]))
                {
                    Sunday_txt.Text = Sunday_txt.Text + DataProvider.getTimeAndCourseName(classIDs[i]) + " \r\n " ;
                }
                

                if (DataProvider.checkMonday(classIDs[i]))
                {
                    Monday_txt.Text = Monday_txt.Text +  DataProvider.getTimeAndCourseName(classIDs[i]) + " \r\n ";
                }
                

                if (DataProvider.checkTuesday(classIDs[i]))
                {
                    Tuesday_txt.Text = Tuesday_txt.Text +  DataProvider.getTimeAndCourseName(classIDs[i]) + " \r\n ";
                }
                

                if (DataProvider.checkWednesday(classIDs[i]))
                {
                    Wednesday_txt.Text = Wednesday_txt.Text +  DataProvider.getTimeAndCourseName(classIDs[i]) + " \r\n ";
                }
                
                if (DataProvider.checkThursday(classIDs[i]))
                {
                    Thursday_txt.Text = Thursday_txt.Text + DataProvider.getTimeAndCourseName(classIDs[i]) + " \r\n ";
                }
                
            }
                
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sid = "";
            this.Hide();
            Form1 f = new Form1();
            f.Show();
            //this.Close();
        }

        private void StudentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            this.Hide();
            c.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NoticeForm n = new NoticeForm();
            n.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            StudentProfile sp = new StudentProfile();

            this.Hide();
            sp.ShowDialog();
            //this.Show();

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Library l = new Library();
            l.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GradesByCourse gbc = new GradesByCourse();
            gbc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GradesBySemester gbs = new GradesBySemester();
            gbs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complain c = new Complain();
            c.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            SendMessage sm = new SendMessage();
            sm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RateYourFaculties r = new RateYourFaculties();
            r.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RetakeGuide rg = new RetakeGuide();
            rg.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistardSubjects rs = new RegistardSubjects();
            rs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GoToRegistration gtr = new GoToRegistration();
            gtr.Show();
            this.Hide();
        }

        
    }
}

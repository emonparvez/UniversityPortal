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
    public partial class RetakeGuide : Form
    {
        string[] reSub;
        string[] reGrade;
        string[] expectedGrade;
        int[] reCredit;
        public RetakeGuide()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            reSub = new string[5]{"","","","",""};
            reGrade = new string[5] { "", "", "", "", "" };
            expectedGrade = new string[5] { "", "", "", "", "" };
            reCredit = new int[5] { 0, 0, 0, 0, 0 };


            reSub = DataProvider.getRetakeSubjects();
            reCredit = DataProvider.getRetakeSubjectCredit();

            textBox1.Text = reSub[0];
            textBox2.Text = reSub[1];
            textBox3.Text = reSub[2];
            textBox4.Text = reSub[3];
            textBox5.Text = reSub[4];

            reGrade = DataProvider.getRetakeSubjectGrades();

            textBox6.Text = reGrade[0];
            textBox7.Text = reGrade[1];
            textBox8.Text = reGrade[2];
            textBox9.Text = reGrade[3];
            textBox10.Text = reGrade[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RetakeGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total_previous_cgpa_credit = (StudentHome.student.sCredit * StudentHome.student.sCGPA);
            double temp = total_previous_cgpa_credit;
            double retake_previous_cgpa_credit;
            double retake_expected_cgpa_credit;
            double temp2;

            double finalCgpa = 0.0;

            if (comboBox1.SelectedItem != null)
            {
                expectedGrade[0] = comboBox1.SelectedItem.ToString();
            }
            if (comboBox2.SelectedItem != null)
            {
                expectedGrade[1] = comboBox2.SelectedItem.ToString();
            }
            if (comboBox3.SelectedItem != null)
            {
                expectedGrade[2] = comboBox3.SelectedItem.ToString();
            }
            if (comboBox4.SelectedItem != null)
            {
                expectedGrade[3] = comboBox4.SelectedItem.ToString();
            }
            if (comboBox5.SelectedItem != null)
            {
                expectedGrade[4] = comboBox5.SelectedItem.ToString();
            }
            
            RetakeGuide2 rg2 = new RetakeGuide2();
            temp2 = total_previous_cgpa_credit;

            for (int i = 0; i < 5; i++)
            {
                
                if (reSub[i] != null)
                {
                    total_previous_cgpa_credit = temp;
                    retake_previous_cgpa_credit = (reCredit[i] * getCGPA(reGrade[i]));
                    retake_expected_cgpa_credit = (reCredit[i] * getCGPA(expectedGrade[i]));

                    total_previous_cgpa_credit = total_previous_cgpa_credit - retake_previous_cgpa_credit + retake_expected_cgpa_credit;
                    temp2 = temp2 - retake_previous_cgpa_credit + retake_expected_cgpa_credit;

                    finalCgpa = total_previous_cgpa_credit / StudentHome.student.sCredit;

                    double diff =finalCgpa - StudentHome.student.sCGPA ;

                    if (i == 0)
                    {
                        rg2.label1.Text = "After retaking " + reSub[i] + ", your cgpa will be increased by " + diff + " ...";
                    }
                    else if (i == 1)
                    {
                        rg2.label2.Text = "After retaking " + reSub[i] + ", your cgpa will be increased by " + diff + " ...";
                    }
                    else if (i == 2)
                    {
                        rg2.label3.Text = "After retaking " + reSub[i] + ", your cgpa will be increased by " + diff + " ...";

                    }
                    else if (i == 3)
                    {
                        rg2.label4.Text = "After retaking " + reSub[i] + ", your cgpa will be increased by " + diff + " ...";
                    }
                    else if (i == 4)
                    {
                        rg2.label5.Text = "After retaking " + reSub[i] + ", your cgpa will be increased by " + diff + " ...";
                    }     

                }
            }
            finalCgpa = temp2 / StudentHome.student.sCredit;
            rg2.label6.Text = "After retaking all this subjects your cgpa will be: " + finalCgpa + " ...";

            
            rg2.Show();
            this.Hide();

        }

        public double getCGPA(string str)
        {
            if (str == "A+")
            {
                return 4.0;
            }
            else if (str == "A")
            {
                return 3.75;
            }
            else if (str == "A-")
            {
                return 3.5;
            }
            else if (str == "B+")
            {
                return 3.25;
            }
            else if (str == "B")
            {
                return 3.00;
            }
            else if (str == "B-")
            {
                return 2.75;
            }
            else if (str == "C+")
            {
                return 2.5;
            }
            else if (str == "C")
            {
                return 2.25;
            }
            else if (str == "C-")
            {
                return 2.00;
            }
            else if (str == "D+")
            {
                return 1.75;
            }
            else if (str == "D")
            {
                return 1.5;
            }
            else if (str == "D-")
            {
                return 1.00;
            }
            else
            {
                return 0.00;
            }
        }
    }
}

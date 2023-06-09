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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == DataProvider.getMailAddress(StudentHome.sid)
                && textBox2.Text == DataProvider.getNID(StudentHome.sid)
                && textBox3.Text == DataProvider.getPassword(StudentHome.sid)
                && textBox4.Text == textBox5.Text

                )
            {
                if (DataProvider.changeStudentPassword(StudentHome.sid, textBox4.Text))
                {
                    MessageBox.Show("Password updated successfully..");
                    StudentHome s = new StudentHome(StudentHome.sid);
                    this.Hide();
                    s.Show();
                }
                else
                {
                     MessageBox.Show("Something went wrong..");
                }

            }
            else
            {
                 MessageBox.Show("Wrong information...");
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}

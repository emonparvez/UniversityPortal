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
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            for (int i = 0; i < 8; i++)
            {
                if (StudentHome.student.sTeacherID[i] != "0")
                {
                    string tname = DataProvider.getTeacherName(StudentHome.student.sTeacherID[i]);
                    ComboTeacher t = new ComboTeacher(StudentHome.student.sTeacherID[i], tname);
                    comboBox1.Items.Add(t);
                }
                
            }

        }

        private void SendMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           if (
           DataProvider.sendMessages(StudentHome.sid, (comboBox1.SelectedItem as ComboTeacher).tID, richTextBox1.Text,0,1,0)
                )
            {
                MessageBox.Show("Successfully sent message ...");
                StudentHome.current.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong..");
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }
    }
    public class ComboTeacher
    {
        public string tID;
        public string tName;

        public ComboTeacher(string ti, string tn)
        {
            tID = ti;
            tName = tn;
        }

        public override string ToString()
        {
            return tName + "";
        }
    }
}

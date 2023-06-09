using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Admin;

namespace Project.Admin
{
    public partial class AdminHome : Form
    {
        int id;
        public static AdminHome curret;
        public AdminHome(int id)
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            this.id = id;
            curret = this;
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudent asa = new AddStudent();
            asa.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditDB ed = new EditDB();
            ed.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddLibrarian al = new AddLibrarian();
            al.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddCourse acc = new AddCourse();
            acc.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
            this.Hide();
        }
    }
}

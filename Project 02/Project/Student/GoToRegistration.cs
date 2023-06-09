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
    public partial class GoToRegistration : Form
    {
        public GoToRegistration()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            
            int[] completedCourseIDs = new int[10];
            completedCourseIDs = DataProvider.getCompletedCourseIDs();



            dataGridView1.DataSource = DataProvider.getNextSemesterClassInfos(completedCourseIDs);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Buttons";
            btn.Name = "button";
            btn.Text = "Add";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GoToRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentHome.current.Show();
            this.Hide();
        }
    }
}

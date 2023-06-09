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
    public partial class GradesByCourse : Form
    {
        public GradesByCourse()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            label4.Text = DataProvider.getGradeByCourse();
        }

        private void GradesByCourse_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            StudentHome.current.Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

    }
}

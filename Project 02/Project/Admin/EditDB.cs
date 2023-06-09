using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.Admin
{
    public partial class EditDB : Form
    {
        public EditDB()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;

            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = DataProvider.editTable(comboBox1.SelectedItem.ToString());
            comboBox1.SelectedIndexChanged += OnSelectedIndexChanged;
        }
        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataProvider.editTable(comboBox1.SelectedItem.ToString());
        }

        private void EditDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome.curret.Show();
            this.Hide();
        }
    }
}

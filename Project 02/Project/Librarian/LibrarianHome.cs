using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.Librarian
{
    public partial class LibrarianHome : Form
    {
        public static LibrarianHome current;
        public LibrarianHome(int id)
        {
            InitializeComponent();
            current = this;

            label4.Text = label4.Text + DataProvider.getLibrarianName(id);
            textBox1.Text = DataProvider.getTodaysLibraryIncome().ToString();
        }

        private void LibrarianHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LendBook lb = new LendBook();
            lb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceiveBook rb = new ReceiveBook();
            rb.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ReceiveBook : Form
    {
        public ReceiveBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lendID = Convert.ToInt32(textBox1.Text);
            textBox2.Text = DataProvider.checkForFine(lendID).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fine = Convert.ToInt32(textBox2.Text);
            DataProvider.addLibraryIncome(fine);

            MessageBox.Show("Done..");

            LibrarianHome.current.Show();
            this.Hide();
        }

        private void ReceiveBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LibrarianHome.current.Show();
            this.Hide();
        }
    }
}

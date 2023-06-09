using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project.Librarian
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();

            updatee1();

            comboBox2.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand("select * from myuniversity.library where type ='" + comboBox2.SelectedItem.ToString() + "';", myConn);

                MySqlDataReader myReader;

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {
                    comboBox3.Items.Add(myReader.GetString("BookName"));
                }
            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void updatee1()
        {
            textBox1.Text = DataProvider.generateBookID().ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianHome.current.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            int quantity =Convert.ToInt32(textBox4.Text);

            if (DataProvider.addNewBook(id, textBox2.Text, textBox3.Text, quantity, comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Added book...");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }
            updatee1();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(textBox5.Text);
            if (DataProvider.addExistingBook(comboBox3.SelectedItem.ToString(), quantity))
            {
                MessageBox.Show("Quantity updated...");
            }
            else
            {
                MessageBox.Show("Something went wrong...");
            }
            updatee2();
        }

        private void updatee2()
        {
            comboBox2.SelectedIndex = 0;
            comboBox3.Items.Clear();
            textBox5.Text = "";
        }
    }
}

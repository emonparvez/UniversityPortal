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
    public partial class NoticeForm : Form
    {
        public NoticeForm()
        {
            InitializeComponent();
            BackColor = Color.DarkGray;
            webBrowser1.Navigate("http://www.aiub.edu/category/notices");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

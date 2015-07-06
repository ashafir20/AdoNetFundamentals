using System;
using System.Windows.Forms;
using DataLayer;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = DB.ConnectionString;
        }
    }
}

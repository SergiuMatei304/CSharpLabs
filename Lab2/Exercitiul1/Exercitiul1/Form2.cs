using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercitiul1
{
    public partial class Form2 : Form
    {
        StreamReader read = new StreamReader("login.txt");
        string fileUsername;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fileUsername = read.ReadLine();
            label1.Text = "Hello  " + fileUsername;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

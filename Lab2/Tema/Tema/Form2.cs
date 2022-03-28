using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema
{
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                string time = DateTime.Now.ToString("h:mm:ss tt");
                MessageBox.Show("The current time is " + time);
            }
            if(radioButton2.Checked)
            {
                form3.Show();
                this.Close();
            }
            if(radioButton3.Checked)
            {
                groupBox2.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            bool flag = true;
            try
            {
                a = float.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti numere reale pozitive!");
                textBox1.Text = "";
                textBox2.Text = "";
                flag = false;
            }
            if (flag)
            {
                try
                {
                    b = float.Parse(textBox2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduceti numere reale pozitive!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    flag = false;
                }
            }
            if(a<0 || b<0)
            {
                MessageBox.Show("Introduceti numere reale pozitive!");
                textBox1.Text = "";
                textBox2.Text = "";
                flag = false;
            }
            if(flag == true)
            {
                textBox3.Text = Convert.ToString(2 * a + 2 * b);
                textBox4.Text = Convert.ToString(a * b);
            }
        }
    }
}

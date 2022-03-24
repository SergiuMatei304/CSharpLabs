namespace Exercitiul4
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[10];
        string[] items = System.IO.File.ReadAllLines("D:/Faculta AN3/Sem2/II/Lab2/Exercitiul4/Exercitiul4/bin/Debug/net6.0-windows/list.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/Faculta AN3/Sem2/II/Lab2/Exercitiul4/Exercitiul4/bin/Debug/net6.0-windows/" + listBox1.SelectedItem.ToString() + ".jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            foreach (string item in items)
            {
                listBox1.Items.Add(item);
            }
            images[1] = Image.FromFile("audi.jpg");
            images[2] = Image.FromFile("bmw.jpg");
            images[3] = Image.FromFile("porsche.jpg");
            images[4] = Image.FromFile("ford.jpg");
            images[5] = Image.FromFile("mercedes.jpg");
            images[6] = Image.FromFile("vw.jpg");
            images[7] = Image.FromFile("seat.jpg");
            images[8] = Image.FromFile("ferrari.jpg");
            images[9] = Image.FromFile("lamborghini.jpg");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBox1.Controls)
            {
                if (r.Checked)
                {
                    MessageBox.Show(r.Text + " " + radioButton4.Text);
                }
            }
        }

        private void groupBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBox1.Controls)
            {
                if (r.Checked)
                {
                    MessageBox.Show(r.Text + " " + radioButton5.Text);
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBox1.Controls)
            {
                if (r.Checked)
                {
                    MessageBox.Show(r.Text + " " + radioButton6.Text);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBox2.Controls)
            {
                if (r.Checked)
                {
                    MessageBox.Show(radioButton1.Text+ " "+ r.Text);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBox2.Controls)
            {
                if (r.Checked)
                {
                    MessageBox.Show(radioButton2.Text + " " + r.Text);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in groupBox2.Controls)
            {
                if (r.Checked)
                {
                    MessageBox.Show(radioButton3.Text + " " + r.Text);
                }
            }
        }
    }
}
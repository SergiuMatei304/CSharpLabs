namespace Exercitiul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int a = 0 ;
            int b = 0 ;
            try
            {
                a = int.Parse(textBox1.Text);                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Introduceti numere naturale!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            try
            {
                b = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti numere naturale!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            float result = a & b;
            textBox3.Text = Convert.ToString(result);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti numere naturale!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            try
            {
                b = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti numere naturale!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            float result = a | b;
            textBox3.Text = Convert.ToString(result);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti numere naturale!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            try
            {
                b = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti numere naturale!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            float result = a ^ b;
            textBox3.Text = Convert.ToString(result);
        }
    }
}
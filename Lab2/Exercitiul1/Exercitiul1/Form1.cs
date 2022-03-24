using System.IO;
namespace Exercitiul1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        StreamReader read = new StreamReader("login.txt");
        string fileUsername;
        string filePassword;
        string username;
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileUsername = read.ReadLine();
            filePassword = read.ReadLine();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;

            if(username == fileUsername && password == filePassword)
            {
                this.Hide();
                form2.Show();   
            }
            else
            {
                MessageBox.Show("Utilizator invalid!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
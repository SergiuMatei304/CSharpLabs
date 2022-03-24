namespace Exercitiul2
{
    public partial class Form1 : Form
    {
        string[] items = System.IO.File.ReadAllLines("D:/Faculta AN3/Sem2/II/Lab2/Exercitiul2/Exercitiul2/bin/Debug/net6.0-windows/list.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string item in listBox1.SelectedItems)
            {
                if(!( listBox2.Items.Contains(item)))
                    listBox2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
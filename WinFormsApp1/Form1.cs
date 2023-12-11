namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox_fiestName.Text + " " + textBox_lastName.Text;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouese click : " + e.Location.ToString());
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("\nmouese click : " + e.Location.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_changeLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
        }
    }
}

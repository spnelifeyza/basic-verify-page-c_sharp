namespace giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Enabled = true;
            textBox1.Clear();

            string[] symbol1 = { "a", "b", "c", "d", "e", "F", "G", "H", "I", "j", "K" };
            string[] symbol2 = { "+", "-", "*", "/", ".", ",", "-" };

            Random rnd = new Random();
            int s1, s2, s3;

            s1 = rnd.Next(0, symbol1.Length);
            s2 = rnd.Next(0, 100);
            s3 = rnd.Next(0, symbol2.Length);

            label1.Text = symbol1[s1].ToString() + s2.ToString() + symbol2[s3].ToString();
            label1.BackColor = Color.DarkGray;

            timer1.Start();
            progressBar1.Visible = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;

            if (label1.Text == textBox1.Text)
            {
                MessageBox.Show("Successful login!");
                timer1.Stop();
                
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Failed login! Try again later.");
                textBox1.Clear();
                textBox1.Enabled = true;
                button1.Text = "NEW CAPTCHA";
                progressBar1.Value = 0;
                button2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 5;

            
        }
    }
}

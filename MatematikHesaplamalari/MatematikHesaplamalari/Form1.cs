namespace MatematikHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;

            birkenar = Convert.ToInt32(textBox1.Text);
            
            alan = birkenar * birkenar;
            cevre = 4 * birkenar; 

            label4.Text= alan.ToString();
            label5.Text = cevre.ToString();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible= false;
            label1.Text = "KARE";
            button3.Visible = false;
            button4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            label1.Text = "DÝKDÖRTGEN";
            label2.Text = "Kýsa Kenar";
            panel1.Visible = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dikalan, dikcevre;
            int uzun, kisa;

            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            dikalan = kisa * uzun;
            dikcevre = (2 * kisa) + (2 * uzun);

            label4.Text = dikalan.ToString();
            label5.Text = dikcevre.ToString();

        }
    }
}
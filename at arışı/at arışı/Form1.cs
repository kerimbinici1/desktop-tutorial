namespace at_arışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bau, iau, üau;
        Random rastgele = new Random();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bau = pictureBox1.Left;
            iau = pictureBox2.Left;
            üau = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(label8.Text);
            s++;
            label8.Text = s.ToString();
            int bag = pictureBox1.Width;
            int iag = pictureBox2.Width;
            int üag = pictureBox3.Width;
            int bu = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 13);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 13);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 13);
            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label7.Text = "1 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜOR";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "2 NUMARALI AT GÜZEL BİR ATAKLA ÖNE GEÇİYOR";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label7.Text = "3 NUMARALI AT LİDERLİĞİ ELİNE ALDI";
            }


            if (bag + pictureBox1.Left >= bu)
            {
                timer1.Enabled = false;
                label7.Text = "1 NUMARALI AT YARIŞI KAZANDI";
            }
            if (iag + pictureBox2.Left >= bu)
            {
                timer1.Enabled = false;
                label7.Text = "2 NUMARALI AT YARIŞI KAZANDI";
            }
            if (üag + pictureBox3.Left >= bu)
            {
                timer1.Enabled = false;
                label7.Text = "3 NUMARALI AT YARIŞI KAZANDI";
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label8.Text = "0";
            label7.Text = "";
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }
    }
}

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int scorePlayer = 0;
        int scorePc = 0;

        void Reset()
        {
            button3.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.BorderSize = 5;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
        }

        void Control()
        {
            if (scorePlayer == 3)
            {
                scorePlayer = 0;
                scorePc = 0;
                label1.Text = "";
                MessageBox.Show("Tebrikler Kazandýnýz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                label2.Text = scorePlayer.ToString();
                label3.Text = scorePc.ToString();
            }
            else if (scorePc == 3)
            {
                scorePlayer = 0;
                scorePc = 0;
                label1.Text = "";
                MessageBox.Show("Bilgisayar Kazandý :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                label2.Text = scorePlayer.ToString();
                label3.Text = scorePc.ToString();
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            Reset();

            button1.FlatAppearance.BorderSize = 8;

            int x = random.Next(1, 4); // 1 dahil 4 deðil

            if (x == 1)
            {
                button4.ForeColor = Color.Red;
                label1.Text = "Berabere !";
            }
            else if (x == 3)
            {
                button6.ForeColor = Color.Red;
                label1.Text = "Kazandýnýz !";
                scorePlayer++;
                label2.Text = scorePlayer.ToString();
            }
            else if (x == 2)
            {
                button5.ForeColor = Color.Red;
                label1.Text = "Kaybettiniz !";
                scorePc++;
                label3.Text = scorePc.ToString();
            }

            Control();
        }

        void button2_Click(object sender, EventArgs e)
        {
            Reset();

            button2.FlatAppearance.BorderSize = 8;

            int x = random.Next(1, 4); // 1 dahil 4 deðil

            if (x == 2)
            {
                button5.ForeColor = Color.Red;
                label1.Text = "Berabere !";
            }
            else if (x == 1)
            {
                button4.ForeColor = Color.Red;
                label1.Text = "Kazandýnýz !";
                scorePlayer++;
                label2.Text = scorePlayer.ToString();
            }
            else if (x == 3)
            {
                button6.ForeColor = Color.Red;
                label1.Text = "Kaybettiniz !";
                scorePc++;
                label3.Text = scorePc.ToString();
            }

            Control();
        }

        void button3_Click(object sender, EventArgs e)
        {
            Reset();

            button3.FlatAppearance.BorderSize = 8;

            int x = random.Next(1, 4); // 1 dahil 4 deðil

            if (x == 3)
            {
                button6.ForeColor = Color.Red;
                label1.Text = "Berabere !";
            }
            else if (x == 2)
            {
                button5.ForeColor = Color.Red;
                label1.Text = "Kazandýnýz !";
                scorePlayer++;
                label2.Text = scorePlayer.ToString();
            }
            else if (x == 1)
            {
                button4.ForeColor = Color.Red;
                label1.Text = "Kaybettiniz !";
                scorePc++;
                label3.Text = scorePc.ToString();
            }

            Control();
        }
    }
}
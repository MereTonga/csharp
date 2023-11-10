namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;

        void Select(Button button)
        {
            if (x % 2 == 0)
            {
                pictureBox1.Focus();
                x++;
                button.BackgroundImage = Image.FromFile("C:\\Users\\Mert\\Desktop\\deneme\\görseller\\Circle.png");
                button.Enabled = false;
                button.AccessibleName = "Circle";
            }
            else
            {
                pictureBox1.Focus();
                x++;
                button.BackgroundImage = Image.FromFile("C:\\Users\\Mert\\Desktop\\deneme\\görseller\\x.png");
                button.Enabled = false;
                button.AccessibleName = "X";
            }

            Controller();
        }

        void Controller()
        {
            if (x != 9 &&
                button1.AccessibleName == button2.AccessibleName && button2.AccessibleName == button3.AccessibleName && !(button1.AccessibleName == "" && button2.AccessibleName == "" && button3.AccessibleName == "") ||
                button4.AccessibleName == button5.AccessibleName && button5.AccessibleName == button6.AccessibleName && !(button4.AccessibleName == "" && button5.AccessibleName == "" && button6.AccessibleName == "") ||
                button7.AccessibleName == button8.AccessibleName && button8.AccessibleName == button9.AccessibleName && !(button7.AccessibleName == "" && button8.AccessibleName == "" && button9.AccessibleName == "") ||
                button1.AccessibleName == button4.AccessibleName && button4.AccessibleName == button7.AccessibleName && !(button1.AccessibleName == "" && button4.AccessibleName == "" && button7.AccessibleName == "") ||
                button2.AccessibleName == button5.AccessibleName && button5.AccessibleName == button8.AccessibleName && !(button2.AccessibleName == "" && button5.AccessibleName == "" && button8.AccessibleName == "") ||
                button3.AccessibleName == button6.AccessibleName && button6.AccessibleName == button9.AccessibleName && !(button3.AccessibleName == "" && button6.AccessibleName == "" && button9.AccessibleName == "") ||
                button1.AccessibleName == button5.AccessibleName && button5.AccessibleName == button9.AccessibleName && !(button1.AccessibleName == "" && button5.AccessibleName == "" && button9.AccessibleName == "") ||
                button3.AccessibleName == button5.AccessibleName && button7.AccessibleName == button3.AccessibleName && !(button3.AccessibleName == "" && button5.AccessibleName == "" && button7.AccessibleName == ""))
            {
                if (x % 2 == 0)
                {
                    MessageBox.Show("Oyuncu 2 Kazandý !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Oyuncu 1 Kazandý !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
            else if (x == 9)
            {
                MessageBox.Show("Berabere !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        void Reset()
        {
            x = 0;

            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;

            button1.AccessibleName = "";
            button2.AccessibleName = "";
            button3.AccessibleName = "";
            button4.AccessibleName = "";
            button5.AccessibleName = "";
            button6.AccessibleName = "";
            button7.AccessibleName = "";
            button8.AccessibleName = "";
            button9.AccessibleName = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        void button1_Click(object sender, EventArgs e)
        {
            Select(button1);
        }

        void button2_Click(object sender, EventArgs e)
        {
            Select(button2);
        }

        void button3_Click(object sender, EventArgs e)
        {
            Select(button3);
        }

        void button4_Click(object sender, EventArgs e)
        {
            Select(button4);
        }

        void button5_Click(object sender, EventArgs e)
        {
            Select(button5);
        }

        void button6_Click(object sender, EventArgs e)
        {
            Select(button6);
        }

        void button7_Click(object sender, EventArgs e)
        {
            Select(button7);
        }

        void button8_Click(object sender, EventArgs e)
        {
            Select(button8);
        }

        void button9_Click(object sender, EventArgs e)
        {
            Select(button9);
        }
    }
}
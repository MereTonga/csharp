using System.Windows.Forms;

namespace LCD_Ekran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[,] panel = new PictureBox[7, 49];
        Numerals numbers = new Numerals();
        int z = 0;

        void Form1_Load(object sender, EventArgs e)
        {
            int xPos = 0, yPos = 0, height = 20, width = 20;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 49; j++)
                {
                    panel[i, j] = new PictureBox();
                    panel[i, j].Image = Image.FromFile(@"C:\Users\Mert\Desktop\denemeler\LCD Ekran\LCD Ekran\Resources\pixel.png");
                    panel[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    panel[i, j].SetBounds(xPos, yPos, width, height);
                    this.Controls.Add(panel[i, j]);
                    xPos += width;
                }

                xPos = 0;
                yPos += height;
            }
        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece sayý girilmesini saðlýyor
        }

        void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            Reset();
            z = 0;
            char[] x = textBox1.Text.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                Character(x[i]);
                z += 5;
            }
        }

        void Reset()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 49; j++)
                    panel[i, j].Image = Image.FromFile(@"C:\Users\Mert\Desktop\denemeler\LCD Ekran\LCD Ekran\Resources\pixel.png");
        }

        void Character(char a)
        {
            switch (a)
            {
                case '0': Print(numbers.Zero()); break;
                case '1': Print(numbers.One()); break;
                case '2': Print(numbers.Two()); break;
                case '3': Print(numbers.Three()); break;
                case '4': Print(numbers.Four()); break;
                case '5': Print(numbers.Five()); break;
                case '6': Print(numbers.Six()); break;
                case '7': Print(numbers.Seven()); break;
                case '8': Print(numbers.Eight()); break;
                case '9': Print(numbers.Nine()); break;

                default:
                    break;
            }
        }

        void Print(int[,] a)
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 4; j++)
                    if (a[i, j] == 1)
                        panel[i, j + z].Image = Image.FromFile(@"C:\Users\Mert\Desktop\denemeler\LCD Ekran\LCD Ekran\Resources\pixel2.png");
        }

    }
}

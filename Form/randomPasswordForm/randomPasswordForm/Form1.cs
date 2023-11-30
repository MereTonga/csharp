namespace randomPasswordForm
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Kopyalandý !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            char[] characters = new char[62];
            string password = "";
            int a = 0;

            if (checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
            {
                a = 62;

                for (int i = 48, j = 48; i <= 122; i++)
                {
                    if (!(i >= 58 && i <= 64) && !(i >= 91 && i <= 96))
                    {
                        characters[j - 48] = Convert.ToChar(i);
                        j++;
                    }
                }
            }
            else if (checkBox3.Checked && checkBox2.Checked)
            {
                a = 36;

                for (int i = 48, j = 48; i <= 122; i++)
                {
                    if (!(i >= 58 && i <= 96))
                    {
                        characters[j - 48] = Convert.ToChar(i);
                        j++;
                    }
                }
            }
            else if (checkBox3.Checked && checkBox1.Checked)
            {
                a = 36;

                for (int i = 48, j = 48; i <= 90; i++)
                {
                    if (!(i >= 58 && i <= 64))
                    {
                        characters[j - 48] = Convert.ToChar(i);
                        j++;
                    }
                }
            }
            else if (checkBox2.Checked && checkBox1.Checked)
            {
                a = 52;

                for (int i = 65, j = 65; i <= 122; i++)
                {
                    if (!(i >= 91 && i <= 96))
                    {
                        characters[j - 65] = Convert.ToChar(i);
                        j++;
                    }
                }
            }
            else if (checkBox1.Checked)
            {
                a = 26;

                for (int i = 65; i <= 90; i++)
                {
                    characters[i - 65] = Convert.ToChar(i);
                }
            }
            else if (checkBox2.Checked)
            {
                a = 26;

                for (int i = 97; i <= 122; i++)
                {
                    characters[i - 97] = Convert.ToChar(i);
                }
            }
            else if (checkBox3.Checked)
            {
                a = 10;

                for (int i = 48; i <= 57; i++)
                {
                    characters[i - 48] = Convert.ToChar(i);
                }
            }
            else if(!(checkBox3.Checked && checkBox2.Checked && checkBox1.Checked))
            {
                password = "Lütfen Seçim Yapýnýz !";
            }

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                password += characters[random.Next(0, a)].ToString();
            }

            textBox1.Text = password;

        }

    }
}

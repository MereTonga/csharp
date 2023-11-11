namespace FormDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ogrenciAd = new string[5];
        int[] ogrenciNot = new int[5];
        int ogrenciSayi = 0;

        void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && ogrenciSayi < 5)
            {
                ogrenciAd[ogrenciSayi] = textBox1.Text;
                ogrenciNot[ogrenciSayi] = Convert.ToInt16(textBox2.Text);
                ogrenciSayi++;
                textBox1.Text = "";
                textBox2.Text = "";
                button2.PerformClick();
            }
            else if (ogrenciSayi >= 5)
                button1.Enabled = false;
            else
                MessageBox.Show("Eksik Bilgi", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // sadece sayý girilmesini saðlýyor
        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar); // sadece karakter girilmesi
        }

        void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < ogrenciSayi; i++)
                listBox1.Items.Add(ogrenciAd[i] + "  " + ogrenciNot[i]);
        }

        void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < ogrenciSayi; i++)
                if (ogrenciNot[i] < 50)
                    listBox1.Items.Add(ogrenciAd[i] + "  " + ogrenciNot[i]);
        }

        void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < ogrenciSayi; i++)
                if (ogrenciNot[i] >= 50)
                    listBox1.Items.Add(ogrenciAd[i] + "  " + ogrenciNot[i]);
        }

        void button5_Click(object sender, EventArgs e)
        {
            if(ogrenciSayi > 0 && listBox1.SelectedIndex >= 0)
            {
                string name;
                int not;
                name = ogrenciAd[ogrenciSayi - 1];
                not = ogrenciNot[ogrenciSayi - 1];

                ogrenciAd[ogrenciSayi - 1] = "";
                ogrenciNot[ogrenciSayi - 1] = 0;

                ogrenciAd[listBox1.SelectedIndex] = name;
                ogrenciNot[listBox1.SelectedIndex] = not;

                ogrenciSayi--;

                button2.PerformClick();
            }
        }
    }
}
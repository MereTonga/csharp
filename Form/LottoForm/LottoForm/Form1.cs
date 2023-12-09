namespace LottoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                listBox1.Items.Add(textBox1.Text);
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != "")
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0 && listBox1.Items.Count >= numericUpDown1.Value)
            {
                string[] x = new string[listBox1.Items.Count];
                string y = "Sonuç :";
                int a = random.Next(0, listBox1.Items.Count);

                for (int i = 0; i < listBox1.Items.Count; i++)
                    x[i] = listBox1.Items[i].ToString();

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    y += (" " + listBox1.Items[a]);
                    listBox1.Items.RemoveAt(a);
                    a = random.Next(0, listBox1.Items.Count);
                }

                listBox1.Items.Clear();
                for (int i = 0; i < x.Length; i++)
                    listBox1.Items.Add(x[i]);

                MessageBox.Show(y, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sayýlarý veya girilen deðerleri kontrol ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

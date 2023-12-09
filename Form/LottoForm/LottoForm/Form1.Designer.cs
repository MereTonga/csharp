namespace LottoForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(370, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 389);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(51, 264);
            button1.Name = "button1";
            button1.Size = new Size(97, 55);
            button1.TabIndex = 1;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(176, 264);
            button2.Name = "button2";
            button2.Size = new Size(97, 55);
            button2.TabIndex = 2;
            button2.Text = "Çıkar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(370, 442);
            button3.Name = "button3";
            button3.Size = new Size(121, 72);
            button3.TabIndex = 3;
            button3.Text = "Çek";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(31, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 52);
            textBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 28F);
            numericUpDown1.Location = new Point(513, 442);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(91, 70);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(633, 544);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Kura Uygulaması";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
    }
}

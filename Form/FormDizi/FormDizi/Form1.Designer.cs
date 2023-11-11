namespace FormDizi
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
            dataInput = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataInput.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataInput
            // 
            dataInput.BackColor = SystemColors.ActiveCaption;
            dataInput.Controls.Add(button1);
            dataInput.Controls.Add(textBox2);
            dataInput.Controls.Add(textBox1);
            dataInput.Controls.Add(label2);
            dataInput.Controls.Add(label1);
            dataInput.Location = new Point(8, 21);
            dataInput.Name = "dataInput";
            dataInput.Size = new Size(453, 288);
            dataInput.TabIndex = 0;
            dataInput.TabStop = false;
            dataInput.Text = "Veri Girişi";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(250, 199);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(191, 137);
            textBox2.MaxLength = 3;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 43);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(191, 69);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 43);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 137);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 1;
            label2.Text = "Ortalama :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 69);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci İsim :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(488, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(616, 333);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgi";
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.System;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(6, 240);
            button5.Name = "button5";
            button5.Size = new Size(197, 50);
            button5.TabIndex = 6;
            button5.Text = "Sil";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Location = new Point(231, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 274);
            listBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.System;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(6, 180);
            button4.Name = "button4";
            button4.Size = new Size(197, 50);
            button4.TabIndex = 4;
            button4.Text = "Geçenler";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.System;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(6, 120);
            button3.Name = "button3";
            button3.Size = new Size(197, 50);
            button3.TabIndex = 4;
            button3.Text = "Kalanlar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.System;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(6, 60);
            button2.Name = "button2";
            button2.Size = new Size(197, 50);
            button2.TabIndex = 4;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1116, 372);
            Controls.Add(groupBox1);
            Controls.Add(dataInput);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Öğrenci Durum";
            dataInput.ResumeLayout(false);
            dataInput.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dataInput;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private ListBox listBox1;
        private Button button5;
    }
}
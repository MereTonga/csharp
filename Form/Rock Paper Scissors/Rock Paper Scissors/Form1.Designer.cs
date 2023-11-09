namespace Rock_Paper_Scissors
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.BackgroundImage = Properties.Resources.noun_hand_477922;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(493, 86);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.noun_fist_477918;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(293, 86);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.noun_wave_477912;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(93, 86);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 205);
            label1.Name = "label1";
            label1.Size = new Size(375, 100);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.BackgroundImage = Properties.Resources.noun_hand_477922;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Enabled = false;
            button4.FlatAppearance.BorderSize = 5;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(493, 336);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.CadetBlue;
            button5.BackgroundImage = Properties.Resources.noun_fist_477918;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Enabled = false;
            button5.FlatAppearance.BorderSize = 5;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(293, 336);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.CadetBlue;
            button6.BackgroundImage = Properties.Resources.noun_wave_477912;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Enabled = false;
            button6.FlatAppearance.BorderSize = 5;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(93, 336);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 60);
            label2.TabIndex = 4;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(321, 457);
            label3.Name = "label3";
            label3.Size = new Size(50, 60);
            label3.TabIndex = 4;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(668, 549);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock Paper Scissors";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Label label3;
    }
}
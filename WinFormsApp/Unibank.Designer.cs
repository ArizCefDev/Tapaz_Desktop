namespace WinFormsApp
{
    partial class Unibank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 62);
            label1.TabIndex = 0;
            label1.Text = "U";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 22);
            label2.Name = "label2";
            label2.Size = new Size(127, 38);
            label2.TabIndex = 1;
            label2.Text = "Unibank";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 60);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 2;
            label3.Text = "Sənin bankın";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uniph;
            pictureBox1.Location = new Point(282, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(365, 22);
            label4.Name = "label4";
            label4.Size = new Size(108, 62);
            label4.TabIndex = 4;
            label4.Text = "117";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(778, 41);
            label5.Name = "label5";
            label5.Size = new Size(89, 38);
            label5.TabIndex = 5;
            label5.Text = "00:00";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.unicl;
            pictureBox2.Location = new Point(704, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.unidt;
            pictureBox3.Location = new Point(883, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(957, 41);
            label6.Name = "label6";
            label6.Size = new Size(161, 38);
            label6.TabIndex = 7;
            label6.Text = "00.00.0000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 174);
            label7.Name = "label7";
            label7.Size = new Size(372, 114);
            label7.TabIndex = 9;
            label7.Text = "PİN - kodu daxil et\r\nvə klaviaturada enter-ə bas\r\n'Ввод'/'Enter'";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 477);
            label8.Name = "label8";
            label8.Size = new Size(325, 38);
            label8.TabIndex = 10;
            label8.Text = "PIN - kodunuz yalnışdır";
            label8.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 42);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(270, 43);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(91, 590);
            button1.Name = "button1";
            button1.Size = new Size(255, 68);
            button1.TabIndex = 12;
            button1.Text = "Kartı qaytar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-6, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 125);
            panel1.TabIndex = 13;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Location = new Point(410, 38);
            button4.Name = "button4";
            button4.Size = new Size(161, 51);
            button4.TabIndex = 29;
            button4.Text = "Təstiq et";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Unibank
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1207, 719);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(6);
            Name = "Unibank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unibank Login";
            Load += Unibank_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button button4;
    }
}
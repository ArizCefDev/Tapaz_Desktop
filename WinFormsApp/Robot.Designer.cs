namespace WinFormsApp
{
    partial class Robot
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(332, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 294);
            label1.Name = "label1";
            label1.Size = new Size(33, 38);
            label1.TabIndex = 3;
            label1.Text = "0";
            label1.Visible = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(28, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 137);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(28, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 87);
            panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(69, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 43);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 313);
            label2.Name = "label2";
            label2.Size = new Size(140, 38);
            label2.TabIndex = 7;
            label2.Text = "baslayir...";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(392, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 43);
            textBox2.TabIndex = 8;
            textBox2.Text = "0";
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(392, 402);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 43);
            textBox3.TabIndex = 9;
            textBox3.Text = "0";
            textBox3.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Black;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(392, 340);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 45);
            comboBox1.TabIndex = 10;
            comboBox1.Visible = false;
            // 
            // Robot
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(559, 493);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(6);
            Name = "Robot";
            Text = "Robot";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
    }
}
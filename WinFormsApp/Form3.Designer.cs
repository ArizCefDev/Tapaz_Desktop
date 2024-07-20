namespace WinFormsApp
{
    partial class Form3
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
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 45);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 0;
            label1.Text = "Kapital Bank";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-16, -27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 142);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1071, 99);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 3;
            label3.Text = "bizimlə əlaqə";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1002, 45);
            label4.Name = "label4";
            label4.Size = new Size(202, 54);
            label4.TabIndex = 2;
            label4.Text = "(012) 196";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 99);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 1;
            label2.Text = "birinci bank";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(499, 231);
            label5.Name = "label5";
            label5.Size = new Size(219, 38);
            label5.TabIndex = 4;
            label5.Text = "Xoş Gəlmişsiniz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(444, 283);
            label6.Name = "label6";
            label6.Size = new Size(346, 54);
            label6.TabIndex = 4;
            label6.Text = "Hörmətli müştəri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(309, 351);
            label7.Name = "label7";
            label7.Size = new Size(576, 46);
            label7.TabIndex = 5;
            label7.Text = "Xahiş edirik PİN şifrənizi daxil edin";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 0, 0);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(512, 457);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = 'O';
            textBox1.PlaceholderText = "OOOO";
            textBox1.Size = new Size(190, 80);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(499, 584);
            button1.Name = "button1";
            button1.Size = new Size(219, 65);
            button1.TabIndex = 7;
            button1.Text = "Daxil olun";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(512, 410);
            label8.Name = "label8";
            label8.Size = new Size(198, 28);
            label8.TabIndex = 8;
            label8.Text = "PIN şifrəniz ylnışdır";
            label8.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1252, 757);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
        private Label label8;
    }
}
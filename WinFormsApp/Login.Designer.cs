namespace WinFormsApp
{
    partial class Login
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
            label7 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 19);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 1;
            label1.Text = "Kabinetə giriş";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 97);
            label7.Name = "label7";
            label7.Size = new Size(149, 28);
            label7.TabIndex = 16;
            label7.Text = "Telefon nömrəsi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 57);
            textBox1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(226, 659);
            label2.Name = "label2";
            label2.Size = new Size(898, 23);
            label2.TabIndex = 18;
            label2.Text = "Saytda Giriş etməklə siz Tap.az-ın İstifadəçi razılaşmasını və Qaydalarını qəbul etdiyinizi təsdiqləmiş olursunuz.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 202);
            button1.Name = "button1";
            button1.Size = new Size(411, 86);
            button1.TabIndex = 20;
            button1.Text = "Kod göndərilsin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(428, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 304);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(1171, 53);
            button2.Name = "button2";
            button2.Size = new Size(71, 64);
            button2.TabIndex = 21;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(83, 69);
            label3.Name = "label3";
            label3.Size = new Size(323, 28);
            label3.TabIndex = 21;
            label3.Text = "Daxil edilən operator kodu yanlışdır";
            label3.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(22F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 767);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daxil ol";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label3;
    }
}
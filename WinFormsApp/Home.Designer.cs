namespace WinFormsApp
{
    partial class Home
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
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 28);
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
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 126);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1070, 82);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 3;
            label3.Text = "bizimlə əlaqə";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1001, 28);
            label4.Name = "label4";
            label4.Size = new Size(202, 54);
            label4.TabIndex = 2;
            label4.Text = "(012) 196";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(206, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 1;
            label2.Text = "birinci bank";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(370, 206);
            label6.Name = "label6";
            label6.Size = new Size(543, 54);
            label6.TabIndex = 10;
            label6.Text = "Xahiş edirik əməliyyat seçin";
            // 
            // button1
            // 
            button1.Location = new Point(46, 305);
            button1.Name = "button1";
            button1.Size = new Size(475, 91);
            button1.TabIndex = 11;
            button1.Text = "Xidmətlər";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(722, 305);
            button2.Name = "button2";
            button2.Size = new Size(475, 91);
            button2.TabIndex = 12;
            button2.Text = "Nağdlaşdırma (AZN)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(46, 575);
            button3.Name = "button3";
            button3.Size = new Size(475, 91);
            button3.TabIndex = 13;
            button3.Text = "English";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(722, 443);
            button4.Name = "button4";
            button4.Size = new Size(475, 91);
            button4.TabIndex = 14;
            button4.Text = "Hesabdan çıxış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1252, 757);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
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
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
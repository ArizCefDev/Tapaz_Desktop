namespace WinFormsApp
{
    partial class Form2
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            btnenter = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btndot = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnx = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            total = new Label();
            pay = new Label();
            returned = new Label();
            error = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(201, 41);
            label1.TabIndex = 0;
            label1.Text = "Məhsul kodu";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(240, 28);
            button1.Name = "button1";
            button1.Size = new Size(233, 51);
            button1.TabIndex = 2;
            button1.Text = "Kod siyahısı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 104);
            button2.Name = "button2";
            button2.Size = new Size(233, 51);
            button2.TabIndex = 3;
            button2.Text = "Əlavə et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnenter);
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btndot);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btnx);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(29, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 476);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Məbləğ";
            // 
            // btnenter
            // 
            btnenter.Location = new Point(28, 395);
            btnenter.Name = "btnenter";
            btnenter.Size = new Size(377, 66);
            btnenter.TabIndex = 18;
            btnenter.Text = "Hesablamaq";
            btnenter.UseVisualStyleBackColor = true;
            btnenter.Click += btnenter_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(328, 308);
            btn0.Name = "btn0";
            btn0.Size = new Size(77, 66);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(228, 308);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 66);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(128, 308);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 66);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(28, 308);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 66);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btndot
            // 
            btndot.Location = new Point(328, 223);
            btndot.Name = "btndot";
            btndot.Size = new Size(77, 66);
            btndot.TabIndex = 13;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btndot_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(228, 223);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 66);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(128, 223);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 66);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(28, 223);
            btn4.Name = "btn4";
            btn4.Size = new Size(77, 66);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnx
            // 
            btnx.Location = new Point(328, 137);
            btnx.Name = "btnx";
            btnx.Size = new Size(77, 66);
            btnx.TabIndex = 9;
            btnx.Text = "X";
            btnx.UseVisualStyleBackColor = true;
            btnx.Click += btnx_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(228, 137);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 66);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(128, 137);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 66);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(28, 137);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 66);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 47);
            textBox2.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(550, 249);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(631, 455);
            listBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(734, 33);
            label2.Name = "label2";
            label2.Size = new Size(243, 41);
            label2.TabIndex = 6;
            label2.Text = "Ümumi məbləğ:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(709, 93);
            label3.Name = "label3";
            label3.Size = new Size(268, 41);
            label3.TabIndex = 7;
            label3.Text = "Ödənilən məbləğ:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(690, 153);
            label4.Name = "label4";
            label4.Size = new Size(287, 41);
            label4.TabIndex = 8;
            label4.Text = "Qaytarılan məbləğ:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(1058, 33);
            total.Name = "total";
            total.Size = new Size(133, 41);
            total.TabIndex = 9;
            total.Text = "0.00 azn";
            total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pay
            // 
            pay.AutoSize = true;
            pay.Location = new Point(1058, 95);
            pay.Name = "pay";
            pay.Size = new Size(133, 41);
            pay.TabIndex = 10;
            pay.Text = "0.00 azn";
            pay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // returned
            // 
            returned.AutoSize = true;
            returned.Location = new Point(1058, 153);
            returned.Name = "returned";
            returned.Size = new Size(133, 41);
            returned.TabIndex = 11;
            returned.Text = "0.00 azn";
            returned.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            error.ForeColor = Color.Red;
            error.Location = new Point(688, 205);
            error.Name = "error";
            error.Size = new Size(493, 31);
            error.TabIndex = 12;
            error.Text = "Ödənilən məbləğ ümumi məbləğdən kiçikdir";
            error.TextAlign = ContentAlignment.MiddleLeft;
            error.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(502, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 118);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1218, 731);
            Controls.Add(pictureBox1);
            Controls.Add(error);
            Controls.Add(returned);
            Controls.Add(pay);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btndot;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnx;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button btnenter;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label total;
        private Label pay;
        private Label returned;
        private Label error;
        private PictureBox pictureBox1;
    }
}
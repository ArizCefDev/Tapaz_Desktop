namespace WinFormsApp
{
    partial class Form5
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox7 = new ComboBox();
            label8 = new Label();
            comboBox8 = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox4 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label28 = new Label();
            label29 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(517, 19);
            label1.Name = "label1";
            label1.Size = new Size(220, 50);
            label1.TabIndex = 0;
            label1.Text = "Hesablayıcı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 89);
            label2.Name = "label2";
            label2.Size = new Size(174, 38);
            label2.TabIndex = 1;
            label2.Text = "Marka seçin";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HP", "Asus", "Samsung", "Apple" });
            comboBox1.Location = new Point(42, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 45);
            comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(53, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 650);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametrlər";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 415);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 43);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 43);
            textBox1.TabIndex = 17;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Qara", "Ağ", "Boz" });
            comboBox7.Location = new Point(304, 540);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(204, 45);
            comboBox7.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(304, 482);
            label8.Name = "label8";
            label8.Size = new Size(157, 38);
            label8.TabIndex = 15;
            label8.Text = "Rəng seçin";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Windows", "Linux", "MacOS", "Unix" });
            comboBox8.Location = new Point(42, 540);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(204, 45);
            comboBox8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(42, 482);
            label9.Name = "label9";
            label9.Size = new Size(127, 38);
            label9.TabIndex = 13;
            label9.Text = "ƏS seçin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(304, 355);
            label7.Name = "label7";
            label7.Size = new Size(217, 38);
            label7.TabIndex = 11;
            label7.Text = "Monitor ölçüsü";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(304, 220);
            label6.Name = "label6";
            label6.Size = new Size(215, 38);
            label6.TabIndex = 9;
            label6.Text = "Yaddaş (GB,TB)";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "SSD", "HDD" });
            comboBox4.Location = new Point(304, 147);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(204, 45);
            comboBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(304, 89);
            label5.Name = "label5";
            label5.Size = new Size(180, 38);
            label5.TabIndex = 7;
            label5.Text = "Yaddaş seçin";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "4", "8", "16", "32", "64" });
            comboBox3.Location = new Point(42, 413);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(204, 45);
            comboBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 355);
            label4.Name = "label4";
            label4.Size = new Size(221, 38);
            label4.TabIndex = 5;
            label4.Text = "RAM seçin (GB)";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "i3", "i5", "i7", "i8", "i9" });
            comboBox2.Location = new Point(42, 278);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 45);
            comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 220);
            label3.Name = "label3";
            label3.Size = new Size(214, 38);
            label3.TabIndex = 3;
            label3.Text = "Prosessor seçin";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(684, 699);
            button1.Name = "button1";
            button1.Size = new Size(147, 53);
            button1.TabIndex = 4;
            button1.Text = "Hesabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(684, 85);
            label10.Name = "label10";
            label10.Size = new Size(217, 38);
            label10.TabIndex = 19;
            label10.Text = "Marka qiyməti:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(1043, 85);
            label11.Name = "label11";
            label11.Size = new Size(118, 38);
            label11.TabIndex = 20;
            label11.Text = "0.00azn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(1043, 150);
            label12.Name = "label12";
            label12.Size = new Size(118, 38);
            label12.TabIndex = 22;
            label12.Text = "0.00azn";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(684, 150);
            label13.Name = "label13";
            label13.Size = new Size(257, 38);
            label13.TabIndex = 21;
            label13.Text = "Prosessor qiyməti:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(1043, 215);
            label14.Name = "label14";
            label14.Size = new Size(118, 38);
            label14.TabIndex = 24;
            label14.Text = "0.00azn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(684, 215);
            label15.Name = "label15";
            label15.Size = new Size(198, 38);
            label15.TabIndex = 23;
            label15.Text = "RAM qiyməti:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(1043, 283);
            label16.Name = "label16";
            label16.Size = new Size(118, 38);
            label16.TabIndex = 26;
            label16.Text = "0.00azn";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(684, 283);
            label17.Name = "label17";
            label17.Size = new Size(170, 38);
            label17.TabIndex = 25;
            label17.Text = "ƏS qiyməti:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(1043, 355);
            label18.Name = "label18";
            label18.Size = new Size(118, 38);
            label18.TabIndex = 28;
            label18.Text = "0.00azn";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(684, 355);
            label19.Name = "label19";
            label19.Size = new Size(223, 38);
            label19.TabIndex = 27;
            label19.Text = "Yaddaş qiyməti:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.White;
            label20.Location = new Point(1043, 425);
            label20.Name = "label20";
            label20.Size = new Size(118, 38);
            label20.TabIndex = 30;
            label20.Text = "0.00azn";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.White;
            label21.Location = new Point(684, 425);
            label21.Name = "label21";
            label21.Size = new Size(323, 38);
            label21.TabIndex = 29;
            label21.Text = "Yaddaş(GB,TB) qiyməti:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.White;
            label22.Location = new Point(1043, 564);
            label22.Name = "label22";
            label22.Size = new Size(118, 38);
            label22.TabIndex = 34;
            label22.Text = "0.00azn";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.White;
            label23.Location = new Point(684, 564);
            label23.Name = "label23";
            label23.Size = new Size(200, 38);
            label23.TabIndex = 33;
            label23.Text = "Rəng qiyməti:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.White;
            label24.Location = new Point(1043, 495);
            label24.Name = "label24";
            label24.Size = new Size(118, 38);
            label24.TabIndex = 32;
            label24.Text = "0.00azn";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.White;
            label25.Location = new Point(684, 495);
            label25.Name = "label25";
            label25.Size = new Size(241, 38);
            label25.TabIndex = 31;
            label25.Text = "Monitor qiyməti:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.White;
            label28.Location = new Point(1043, 639);
            label28.Name = "label28";
            label28.Size = new Size(118, 38);
            label28.TabIndex = 36;
            label28.Text = "0.00azn";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.White;
            label29.Location = new Point(684, 639);
            label29.Name = "label29";
            label29.Size = new Size(229, 38);
            label29.TabIndex = 35;
            label29.Text = "Toplam qiyməti:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(998, 699);
            button2.Name = "button2";
            button2.Size = new Size(163, 53);
            button2.TabIndex = 37;
            button2.Text = "Sifariş ver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(841, 699);
            button3.Name = "button3";
            button3.Size = new Size(147, 53);
            button3.TabIndex = 38;
            button3.Text = "Sıfrla";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1213, 774);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox7;
        private Label label8;
        private ComboBox comboBox8;
        private Label label9;
        private Label label7;
        private Label label6;
        private ComboBox comboBox4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label28;
        private Label label29;
        private Button button2;
        private Button button3;
    }
}
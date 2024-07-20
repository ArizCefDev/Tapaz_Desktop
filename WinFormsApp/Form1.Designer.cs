namespace WinFormsApp
{
    partial class Form1
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
            button1 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 63);
            label1.Name = "label1";
            label1.Size = new Size(126, 46);
            label1.TabIndex = 0;
            label1.Text = "Kodlar";
            // 
            // button1
            // 
            button1.Location = new Point(242, 51);
            button1.Name = "button1";
            button1.Size = new Size(174, 69);
            button1.TabIndex = 1;
            button1.Text = "Göstər";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(242, 131);
            button6.Name = "button6";
            button6.Size = new Size(174, 69);
            button6.TabIndex = 3;
            button6.Text = "Əlavə et";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 51);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(39, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 431);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 51);
            textBox2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(28, 139);
            button2.Name = "button2";
            button2.Size = new Size(80, 69);
            button2.TabIndex = 6;
            button2.Text = "Əlavə et";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(739, 57);
            label2.Name = "label2";
            label2.Size = new Size(117, 46);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(931, 57);
            label3.Name = "label3";
            label3.Size = new Size(117, 46);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Location = new Point(569, 257);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(505, 409);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1122, 730);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(8, 7, 8, 7);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button button1;
        private Button button6;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
    }
}
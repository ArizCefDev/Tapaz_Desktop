namespace WinFormsApp
{
    partial class Group105
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
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(36, 272);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1201, 414);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 1;
            label1.Text = "Masa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 47);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 47);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 107);
            label2.Name = "label2";
            label2.Size = new Size(78, 41);
            label2.TabIndex = 3;
            label2.Text = "Kart";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 47);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 187);
            label3.Name = "label3";
            label3.Size = new Size(92, 41);
            label3.TabIndex = 5;
            label3.Text = "Masa";
            // 
            // Group105
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1274, 716);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Group105";
            Text = "Group105";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}
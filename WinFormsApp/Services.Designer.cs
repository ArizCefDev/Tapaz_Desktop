namespace WinFormsApp
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 146);
            panel1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1071, 86);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 3;
            label3.Text = "bizimlə əlaqə";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1002, 32);
            label4.Name = "label4";
            label4.Size = new Size(202, 54);
            label4.TabIndex = 2;
            label4.Text = "(012) 196";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 86);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 1;
            label2.Text = "birinci bank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 32);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 0;
            label1.Text = "Kapital Bank";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(53, 190);
            label6.Name = "label6";
            label6.Size = new Size(1106, 341);
            label6.TabIndex = 18;
            label6.Text = resources.GetString("label6.Text");
            // 
            // button1
            // 
            button1.Location = new Point(53, 616);
            button1.Name = "button1";
            button1.Size = new Size(475, 91);
            button1.TabIndex = 19;
            button1.Text = "Əsas menyu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1252, 757);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Services";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Services";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button button1;
    }
}
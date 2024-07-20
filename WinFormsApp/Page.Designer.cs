namespace WinFormsApp
{
	partial class Page
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
			dataGridView1 = new DataGridView();
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			textBox3 = new TextBox();
			label3 = new Label();
			button3 = new Button();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(72, 344);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(807, 276);
			dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			button1.BackColor = Color.Yellow;
			button1.Location = new Point(72, 278);
			button1.Name = "button1";
			button1.Size = new Size(201, 60);
			button1.TabIndex = 1;
			button1.Text = "Show";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(232, 35);
			label1.Name = "label1";
			label1.Size = new Size(101, 41);
			label1.TabIndex = 2;
			label1.Text = "Name";
			// 
			// button2
			// 
			button2.BackColor = Color.Blue;
			button2.Location = new Point(695, 29);
			button2.Name = "button2";
			button2.Size = new Size(201, 60);
			button2.TabIndex = 3;
			button2.Text = "Add";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(362, 29);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(242, 47);
			textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(362, 117);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(242, 47);
			textBox2.TabIndex = 6;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(232, 123);
			label2.Name = "label2";
			label2.Size = new Size(105, 41);
			label2.TabIndex = 5;
			label2.Text = "Salary";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(362, 205);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(242, 47);
			textBox3.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(232, 211);
			label3.Name = "label3";
			label3.Size = new Size(74, 41);
			label3.TabIndex = 7;
			label3.Text = "Age";
			// 
			// button3
			// 
			button3.BackColor = Color.Lime;
			button3.Location = new Point(695, 104);
			button3.Name = "button3";
			button3.Size = new Size(201, 60);
			button3.TabIndex = 9;
			button3.Text = "Update";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.Red;
			button4.Location = new Point(695, 192);
			button4.Name = "button4";
			button4.Size = new Size(201, 60);
			button4.TabIndex = 10;
			button4.Text = "Delete";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// Page
			// 
			AutoScaleDimensions = new SizeF(18F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(947, 666);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			Margin = new Padding(7, 6, 7, 6);
			Name = "Page";
			Text = "Page";
			Load += Page_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button button1;
		private Label label1;
		private Button button2;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private TextBox textBox3;
		private Label label3;
		private Button button3;
		private Button button4;
	}
}
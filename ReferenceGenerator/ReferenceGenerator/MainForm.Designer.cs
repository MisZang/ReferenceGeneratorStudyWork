/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2024/6/4
 * 时间: 21:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace ReferenceGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(308, 28);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "搜索文献......";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(326, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "搜索";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(416, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "生成";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.White;
			this.listView1.Location = new System.Drawing.Point(12, 46);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(522, 561);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(540, 46);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(573, 561);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(644, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 30);
			this.button3.TabIndex = 5;
			this.button3.Text = "添加APIKey";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(769, 13);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(344, 28);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "添加APIKey";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(508, 13);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(130, 30);
			this.button4.TabIndex = 7;
			this.button4.Text = "申请APIKey";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1119, 619);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Name = "MainForm";
			this.Text = "简易参考文献生成器";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

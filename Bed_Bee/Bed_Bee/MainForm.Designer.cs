/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 29.07.2024
 * Время: 14:09
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Bed_Bee
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button Push;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.tb = new System.Windows.Forms.TextBox();
			this.Push = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// rtb
			// 
			this.rtb.Location = new System.Drawing.Point(6, 6);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(338, 231);
			this.rtb.TabIndex = 0;
			this.rtb.Text = "";
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(13, 256);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(330, 20);
			this.tb.TabIndex = 1;
			// 
			// Push
			// 
			this.Push.Location = new System.Drawing.Point(250, 298);
			this.Push.Name = "Push";
			this.Push.Size = new System.Drawing.Size(94, 33);
			this.Push.TabIndex = 2;
			this.Push.Text = "Push";
			this.Push.UseVisualStyleBackColor = true;
			this.Push.Click += new System.EventHandler(this.PushClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(369, 124);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(169, 122);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(370, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 88);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Color Person";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(6, 49);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(93, 21);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Color";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(6, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Black Wite";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(439, 252);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(99, 105);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(32, 290);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(160, 76);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 373);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Push);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.rtb);
			this.Name = "MainForm";
			this.Text = "Bed_Bee";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

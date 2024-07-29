/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 29.07.2024
 * Время: 14:09
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bed_Bee
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PushClick(object sender, EventArgs e)
		{
			rtb.AppendText(tb.Text+'\n');
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			rtb.AppendText("Color Black and White\n");
		}
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			rtb.AppendText("Color Color\n");
		}
	}
}

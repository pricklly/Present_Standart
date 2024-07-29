/*
 * Создано в SharpDevelop.
 * Пользователь: pricklly
 * Дата: 29.07.2024
 * Время: 11:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snak_imho
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
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			rtb.ForeColor=Color.Red;
		}
		void Button1Click(object sender, EventArgs e)
		{
			rtb.AppendText(tb.Text);
		}
	}
}

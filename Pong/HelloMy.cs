using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
	public partial class HelloMy : UserControl
	{
		public HelloMy()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("В этой игре вам необходимо забит мачек противоположному сопернику. есть 2 игрока верхний [Управление A-Влево D-Вправо], нижний[<- -Влево -> -Вправо]. Игра продолжается до тек пор пока кто-то не забьет 5 очков.");
			MessageBox.Show("Удачной игры");
			MainForm test = new MainForm();
			test.ShowDialog();
			
		}
	}
}

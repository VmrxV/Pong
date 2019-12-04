using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = truefalse.l1;
			label3.Text = truefalse.l3;
			if (label1.Text == "5")
			{
				MessageBox.Show("Победил верхний игрок");
				this.Close();
			}
			if (label3.Text == "5")
			{
				MessageBox.Show("Победил нижний игрок");
				this.Close();
			}
		}
	}
}

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
    // Ваш код оставил не тронутым
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string K = e.KeyChar.ToString();
            if (K == "W")
            {
                player1.Top = player1.Top - 10;
            }
            if (K == "S")
            {
                player1.Top = player1.Top + 10;
            }
            if (K == "I")
            {
                player2.Top = player2.Top - 10;
            }
            if (K == "K")
            {
                player2.Top = player2.Top + 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void dot_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dot.Left = dot.Left - 10;
            int score11 = 0;
            int score12 = 0;
            if (dot.Left == Width)
            {
                score11 = score11 + 1;
                score1.Text = score11.ToString();
            }
            if (dot.Left <= 0)
            {
                score12 = score12 + 1;
                score2.Text = score12.ToString();
            }

            if ((dot.Left <= player1.Width) && (dot.Top <= player1.Top + 100) && (dot.Top >= player1.Top))
            {
                double normalvetcx = player1.Left + 30 - player1.Left;
                double normalvetcy = player1.Top - player1.Top - 50;
                double normalvetc = Math.Sqrt(normalvetcx * normalvetcx + normalvetcy * normalvetcy);
                double dotvectx = dot.Left + 30 - dot.Left;
                double dotvecty = dot.Top - dot.Top - 20;
                double dotvect = Math.Sqrt(dotvectx * dotvectx + dotvecty * dotvecty);
                double r;
                r = dotvect - 2 * normalvetc * dotvect * normalvetc / normalvetc * normalvetc;
                int rr = Convert.ToInt32(r);
                dot.Left = rr;
            }

        }
        private void dott_Tick(object sender, EventArgs e)
        {
            int score11 = 0;
            int score12 = 0;
            if (dot.Left == Width)
            {
                score11 = score11 + 1;
                score1.Text = score11.ToString();
            }
            if (dot.Left <= 0)
            {
                score12 = score12 + 1;
                score2.Text = score12.ToString();
            }
            if (timer1.Enabled == false)
            {
                dot.Left = dot.Left + 10;
                if ((dot.Left >= 465) && (dot.Top <= player2.Top + 100) && (dot.Top >= player2.Top))
                {
                    timer1.Enabled = true;
                    dott.Enabled = false;
                }
            }
        }
    }
}



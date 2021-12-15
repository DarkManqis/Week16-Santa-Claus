using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week16_Santa_Claus
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int houseSpeed = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_tick_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            Moon_UP.Left -= houseSpeed;
            house_DOWN.Left -= houseSpeed;
            scoreLabel.Text = $"score: {score}";

            if(Moon_UP.Left < -100)
            {
                Moon_UP.Left = 800;
                score++;
            }

            if(house_DOWN.Left < -100)
            {
                house_DOWN.Left = 800;
                score++;
            }

            if(santa.Top < -25)
            {
                gameOver();
            }

            if (santa.Bounds.IntersectsWith(Moon_UP.Bounds) || santa.Bounds.IntersectsWith(house_DOWN.Bounds) || santa.Bounds.IntersectsWith(grounds.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void santa_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer1_tick.Stop();
            scoreLabel.Text = $"GAME OVER!";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

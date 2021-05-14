using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pong
{
    public partial class Pong : Form
    {
        bool moveUp, moveDown;
        int speed = 10;
        int[] direction = new int[] { -1, new Random().Next(2) };
        
        public Pong()
        {
            InitializeComponent();
        }

        private void mainTimerEvent(object sender, EventArgs e)
        {
            ball.Left += speed * direction[0];
            ball.Top += speed * direction[1];

            if (direction[0] == 1)
            {
                if (direction[1] == -1 && paddle2.Top > 75)
                    paddle2.Top -= speed - 2;
                if (direction[1] == 1 && paddle2.Top < 465)
                    paddle2.Top += speed - 2;
            }

            if (moveUp == true && paddle1.Top > 75)
                paddle1.Top -= speed;
            if (moveDown == true && paddle1.Top < 465)
                paddle1.Top += speed;

            if (ball.Left <= 12)                                                        //resets ball and updates score when missed
            {
                ball.Left = 397;
                ball.Top = 265;
                player2Score.Text = (Int32.Parse(player2Score.Text) + 1).ToString();
                
            }
            else if (ball.Left >= 792)
            {
                ball.Left = 397;
                ball.Top = 265;
                direction[0] = -1;
                player1Score.Text = (Int32.Parse(player1Score.Text) + 1).ToString();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "object")                       //checks if the ball hit a paddle
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (moveUp == true)
                            direction[1] = -1;
                        else if (moveDown == true)
                            direction[1] = 1;

                        direction[0] *= -1;
                    }
                }
                else if ((string)x.Tag == "border")                                     //checks if the ball hit a border
                    if (ball.Bounds.IntersectsWith(x.Bounds))    
                        direction[1] *= -1;
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveUp = true;
                    break;
                case Keys.Down:
                    moveDown = true;
                    break;
                case Keys.Escape:
                    speed = 10;
                    direction = new int[] { -1, new Random().Next(2) };
                    player1Score.Text = "0";
                    player2Score.Text = "0";
                    ball.Left = 397;
                    ball.Top = 265;
                    direction[0] = -1;
                    paddle1.Left = 12; paddle2.Left = 778;
                    paddle1.Top = 247; paddle2.Top = 247;
                    break;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moveUp = false;
                    break;
                case Keys.Down:
                    moveDown = false;
                    break;
            }
        }
    }
}

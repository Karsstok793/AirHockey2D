using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey2D
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(10, 120, 50, 60);
        Rectangle player2 = new Rectangle(580, 120, 50, 60);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle p1Goal = new Rectangle(0, 140, 10, 90);
        Rectangle p2Goal = new Rectangle(690, 140, 10, 90);
        Rectangle center = new Rectangle(325, 0, 10, 400);
        Rectangle blueLine1 = new Rectangle(150, 0, 10, 400);
        Rectangle blueLine2 = new Rectangle(500, 0, 10, 400);
        Pen redPen = new Pen(Color.Red, 190);

        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed = 7;
        int ballXSpeed = -7;
        int ballYSpeed = 7;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush RedBrush = new SolidBrush(Color.Red);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }

        }




        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(blueBrush, player1);
            e.Graphics.FillEllipse(blueBrush, player2);
            e.Graphics.FillEllipse(RedBrush, ball);
            e.Graphics.FillRectangle(RedBrush, p1Goal);
            e.Graphics.FillRectangle(RedBrush, p2Goal);
            e.Graphics.FillRectangle(RedBrush, center);
            e.Graphics.FillRectangle(blueBrush, blueLine1);
            e.Graphics.FillRectangle(blueBrush, blueLine2);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //move ball 
            ball.X += ballXSpeed;
            ball.Y += ballYSpeed;

            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed;
            }
            if (dDown == true && player1.X < 325 - player1.Width)
            {
                player1.X += playerSpeed;
            }
            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed;
            }
            if (leftArrowDown == true && player2.X > 325)
            {
                player2.X -= playerSpeed;
            }
            if (rightArrowDown == true && player2.X < 700 - player2.Width)
            {
                player2.X += playerSpeed;
            }

            //check if ball hit top or bottom wall and change direction if it does 
            if (ball.Y < 0 || ball.Y > this.Height - ball.Height)
            {
                ballYSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }

            //check if ball hit side walls
            if (ball.X < 0 ||  ball.X > this.Width - ball.Width)
            {
                ballXSpeed *= -1;
            }

            //check if ball hits either player. If it does change the direction 
            //and place the ball in front of the player hit 
            if (player1.IntersectsWith(ball))
            {
                ballXSpeed *= -1;
                ball.X = player1.X + player1.Width +1;

            }
            else if (player2.IntersectsWith(ball))
            {
                ballXSpeed *= -1;
                ball.X = player2.X - ball.Width;
            }

            if (ball.IntersectsWith(p1Goal))
            {
                player2Score++;
                ball.X = 350;
                ball.Y = 200;

                player1.Y = 200;
                player2.Y = 200;
                player1.X = 0;
                player2.X = 550;
                awayScoreLabel.Text = $"AWAY : {player2Score}";
            }

            if (ball.IntersectsWith(p2Goal))
            {
                player1Score++;
                ball.X = 350;
                ball.Y = 200;

                player1.Y = 200;
                player2.Y = 200;
                player1.X = 0;
                player2.X = 550;
                homeScoreLabel.Text = $"HOME : {player1Score}";
            }

            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";

            }

            Refresh();

        }
    }
}

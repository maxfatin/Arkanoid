using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Board1 : Form
    {
        public const int topSide = 0, leftSide = 0, rightSide = 1025, bottomSide = 630;
        public int xSpeed = 1, ySpeed = 3;
        const int speed = 3;
        bool isLeftPressed, isRightPressed, isSpacePressed = false;
        bool? wasGoingLeft;
        int numOfTicks;
        int numOfPaddleHits = 1;
        Random rand = new Random();

        public Board1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool? goingLeft = null;
            if (isLeftPressed)
            {
                goingLeft = true;
            }
            if (isRightPressed)
            {
                if (goingLeft.HasValue)
                {
                    goingLeft = null;

                }
                else
                    goingLeft = false;
            }
            if (isSpacePressed == true)
            {
                if (Ball.Location.X <= leftSide || Ball.Location.X >= (rightSide + Paddle.Width - 30))
                {
                    xSpeed *= -1;
                }
                if (Ball.Location.Y <= topSide)
                {
                    ySpeed *= -1;
                }
                Ball.Location = new Point(Math.Max(leftSide, Math.Min((rightSide + Paddle.Width - 30), Ball.Location.X + xSpeed)), Math.Max(topSide, Ball.Location.Y - ySpeed));
            }
            else
            {
                if (goingLeft.HasValue)
                    {
                        var ballSpeed = speed*numOfTicks/7;
                        if (goingLeft.Value)
                        {
                            ballSpeed *= -1;
                        }
                        Ball.Location = new Point(Math.Max(leftSide, Math.Min((rightSide+ Paddle.Width - 30), Ball.Location.X)) + ballSpeed, Ball.Location.Y);
                    }
            }
            DoMove(goingLeft, ref wasGoingLeft, ref numOfTicks);
            if (Ball.Location.Y >= bottomSide)
            {
                Paddle.Location = new Point(535, 628);
                Ball.Location = new Point(600, 604);
                isSpacePressed = false;
                ySpeed *= -1;
                xSpeed = rand.Next(-3, 3);
            }

            if (Paddle.Bounds.IntersectsWith(Ball.Bounds))
            {
                numOfPaddleHits++;
                if (numOfPaddleHits % 3 == 0)
                    ySpeed--;
                
                ySpeed *= -1;
                if (wasGoingLeft == true && numOfTicks >=5 && xSpeed >= -7)
                {
                    xSpeed--;
                }
                else if (wasGoingLeft == false && numOfTicks >=5 && xSpeed <= 7)
                {
                    xSpeed++;
                }
            }
            if (Ball.Bounds.IntersectsWith(pictureBox12.Bounds)|| Ball.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                ySpeed *= -1;
                pictureBox12.Hide();
            }

        }
        private void DoMove(bool? goingLeft, ref bool? wasGoingLeft, ref int numOfTicks)
        {
            if (goingLeft.HasValue)
            {
                var movementSpeed = speed * numOfTicks/7;

                if (goingLeft.Value)
                {
                    movementSpeed *= -1;
                }
                Paddle.Location = new Point(Math.Max(leftSide, Math.Min(rightSide, Paddle.Location.X + movementSpeed)), Paddle.Location.Y);
            }

            if (wasGoingLeft.HasValue)
            {
                if(!goingLeft.HasValue)
                {
                    wasGoingLeft = null;
                    numOfTicks = 0;
                }
                else if (wasGoingLeft.Value == goingLeft.Value)
                {
                    numOfTicks++;
                }
                else
                {
                    wasGoingLeft = goingLeft;
                    numOfTicks = 1;
                }
            }
            else if (goingLeft.HasValue)
            {
                wasGoingLeft = goingLeft;
                numOfTicks = 1;
            }
        }
        
        
        
        
        
        //Check if keys are pressed
        private void CheckKeys(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    isLeftPressed = isDown;
                    break;
                case Keys.Right:
                    isRightPressed = isDown;
                    break;
            }
            if (e.KeyCode == Keys.Space)
            {
                isSpacePressed = true;
            }
        }

        private void Board1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeys(e, true);
        }


        private void Board1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }
    }
}

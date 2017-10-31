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
        const int speed = 3;
        bool isLeftPressed, isRightPressed, isSpacePressed = false;

        public Board1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            DoMove(goingLeft);
        }

        private void DoMove(bool? goingLeft)
        {
            if (goingLeft.HasValue)
            {
                var movementSpeed = speed;
                if (goingLeft.Value)
                {
                    movementSpeed *= -1;
                }
                Paddle.Location = new Point(Paddle.Location.X + movementSpeed, Paddle.Location.Y);
            }
        }

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

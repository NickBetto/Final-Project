using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        Rectangle ball = new Rectangle(300, 15, 30, 30);
        int ballSpeedX = 5;
        int ballSpeedY = 10;

        Rectangle pin = new Rectangle(15, 75, 10, 10);
        Rectangle pin1 = new Rectangle(75, 75, 10, 10);
        Rectangle pin2 = new Rectangle(135, 75, 10, 10);
        Rectangle pin3 = new Rectangle(195, 75, 10, 10);
        Rectangle pin4 = new Rectangle(255, 75, 10, 10);
        Rectangle pin5 = new Rectangle(315, 75, 10, 10);
        Rectangle pin6 = new Rectangle(375, 75, 10, 10);
        Rectangle pin7 = new Rectangle(435, 75, 10, 10);
        Rectangle pin8 = new Rectangle(495, 75, 10, 10);
        Rectangle pin9 = new Rectangle(555, 75, 10, 10);
        Rectangle pin10 = new Rectangle(45, 135, 10, 10);
        Rectangle pin11 = new Rectangle(105, 135, 10, 10);
        Rectangle pin12 = new Rectangle(165, 135, 10, 10);
        Rectangle pin13 = new Rectangle(225, 135, 10, 10);
        Rectangle pin14 = new Rectangle(285, 135, 10, 10);
        Rectangle pin15 = new Rectangle(345, 135, 10, 10);
        Rectangle pin16 = new Rectangle(405, 135, 10, 10);
        Rectangle pin17 = new Rectangle(465, 135, 10, 10);
        Rectangle pin18 = new Rectangle(525, 135, 10, 10);
        Rectangle pin19 = new Rectangle(585, 135, 10, 10);
        Rectangle pin20 = new Rectangle(15, 195, 10, 10);
        Rectangle pin21 = new Rectangle(75, 195, 10, 10);
        Rectangle pin22 = new Rectangle(135, 195, 10, 10);
        Rectangle pin23 = new Rectangle(195, 195, 10, 10);
        Rectangle pin24 = new Rectangle(255, 195, 10, 10);
        Rectangle pin25 = new Rectangle(315, 195, 10, 10);
        Rectangle pin26 = new Rectangle(375, 195, 10, 10);
        Rectangle pin27 = new Rectangle(435, 195, 10, 10);
        Rectangle pin28 = new Rectangle(495, 195, 10, 10);
        Rectangle pin29 = new Rectangle(555, 195, 10, 10);
        Rectangle pin30 = new Rectangle(45, 255, 10, 10);
        Rectangle pin31 = new Rectangle(105, 255, 10, 10);
        Rectangle pin32 = new Rectangle(165, 255, 10, 10);
        Rectangle pin33 = new Rectangle(225, 255, 10, 10);
        Rectangle pin34 = new Rectangle(285, 255, 10, 10);
        Rectangle pin35 = new Rectangle(345, 255, 10, 10);
        Rectangle pin36 = new Rectangle(405, 255, 10, 10);
        Rectangle pin37 = new Rectangle(465, 255, 10, 10);
        Rectangle pin38 = new Rectangle(525, 255, 10, 10);
        Rectangle pin39 = new Rectangle(585, 255, 10, 10);
        Rectangle pin40 = new Rectangle(15, 315, 10, 10);
        Rectangle pin41 = new Rectangle(75, 315, 10, 10);
        Rectangle pin42 = new Rectangle(135, 315, 10, 10);
        Rectangle pin43 = new Rectangle(195, 315, 10, 10);
        Rectangle pin44 = new Rectangle(255, 315, 10, 10);
        Rectangle pin45 = new Rectangle(315, 315, 10, 10);
        Rectangle pin46 = new Rectangle(375, 315, 10, 10);
        Rectangle pin47 = new Rectangle(435, 315, 10, 10);
        Rectangle pin48 = new Rectangle(495, 315, 10, 10);
        Rectangle pin49 = new Rectangle(555, 315, 10, 10);
        Rectangle pin50 = new Rectangle(100, 375, 1, 1);
        Rectangle pin51 = new Rectangle(200, 375, 1, 1);
        Rectangle pin52 = new Rectangle(300, 375, 1, 1);
        Rectangle pin53 = new Rectangle(400, 375, 1, 1);
        Rectangle pin54 = new Rectangle(500, 375, 1, 1);




        List<Rectangle> pins = new List<Rectangle>();

        bool leftDown = false;
        bool rightDown = false;
        bool spaceDown = false;
        bool gDown = false;
        bool escDown = false;
        bool falling = false;

        Random randGen = new Random();
        int randValue = 0;

        int score = 0;
        int turns = 3;
        string gameState = "waiting";

        public Form1()
        {
            InitializeComponent();
            pins.Add(pin);
            pins.Add(pin1);
            pins.Add(pin2);
            pins.Add(pin3);
            pins.Add(pin4);
            pins.Add(pin5);
            pins.Add(pin6);
            pins.Add(pin7);
            pins.Add(pin8);
            pins.Add(pin9);
            pins.Add(pin10);
            pins.Add(pin11);
            pins.Add(pin12);
            pins.Add(pin13);
            pins.Add(pin14);
            pins.Add(pin15);
            pins.Add(pin16);
            pins.Add(pin17);
            pins.Add(pin18);
            pins.Add(pin19);
            pins.Add(pin20);
            pins.Add(pin21);
            pins.Add(pin22);
            pins.Add(pin23);
            pins.Add(pin24);
            pins.Add(pin25);
            pins.Add(pin26);
            pins.Add(pin27);
            pins.Add(pin28);
            pins.Add(pin29);
            pins.Add(pin30);
            pins.Add(pin31);
            pins.Add(pin32);
            pins.Add(pin33);
            pins.Add(pin34);
            pins.Add(pin35);
            pins.Add(pin36);
            pins.Add(pin37);
            pins.Add(pin38);
            pins.Add(pin39);
            pins.Add(pin40);
            pins.Add(pin41);
            pins.Add(pin42);
            pins.Add(pin43);
            pins.Add(pin44);
            pins.Add(pin45); 
            pins.Add(pin46);
            pins.Add(pin47);
            pins.Add(pin48); 
            pins.Add(pin49);
            pins.Add(pin50);
            pins.Add(pin51);
            pins.Add(pin52);
            pins.Add(pin53);
            pins.Add(pin54);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (gameState == "running")
            {
                titleLabel.Text = "";
                subtitleLabel.Text = "";
                Pen drawPen = new Pen(Color.Black, 5);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                SolidBrush redBrush = new SolidBrush(Color.Red);

                e.Graphics.DrawLine(drawPen, 100, 350, 100, 400);
                e.Graphics.DrawLine(drawPen, 200, 350, 200, 400);
                e.Graphics.DrawLine(drawPen, 300, 350, 300, 400);
                e.Graphics.DrawLine(drawPen, 400, 350, 400, 400);
                e.Graphics.DrawLine(drawPen, 500, 350, 500, 400);

                e.Graphics.FillRectangle(redBrush, ball);

                for (int i = 0; i < pins.Count; i++)
                {
                    e.Graphics.FillRectangle(drawBrush, pins[i]);
                }

                if(gameState == "over")
                {
                    titleLabel.Text = "Thanks for Playing";
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    falling = true;
                    break;
                case Keys.G:
                    gDown = true;
                    gameState = "running";
                    gameLoop.Enabled = true;
                    turns--;
                    break;
                case Keys.Escape:
                    escDown = true;

                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.G:
                    gDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if(leftDown == true && ball.X > 0)
            {
                ball.X -= ballSpeedX;
            }
            if(rightDown == true && ball.X < 600)
            {
                ball.X += ballSpeedX;
            }
            if(turns == 0)
            {
                gameState = "over";
            }
            if (falling == true && ball.Y < 400 - ball.Height)
            {

                    ball.Y += ballSpeedY;

            }

            for (int i = 0; i < pins.Count; i++)
            {
                if (ball.IntersectsWith(pins[i]))
                {
                    randValue = randGen.Next(1, 101);
                    if(randValue < 50)
                    {
                        ball.X = ball.X - 15;
                    }
                    else if(randValue > 50)
                    {
                        ball.X = ball.X + 15;
                    }
                }
            }
            if(ball.Y > 400 - ball.Height)
            {
                falling = false;
                if(ball.X <= 100)
                {
                    scoreLabel1.Text = $"{score}";
                    score = score + 50;
                    ball.X = 300;
                    ball.Y = 15;
                }
                else if(ball.X <= 200)
                {
                    scoreLabel1.Text = $"{score}";
                    score = score - 50;
                    ball.X = 300;
                    ball.Y = 15;
                }
                else if (ball.X <= 300)
                {
                    scoreLabel1.Text = $"{score}";
                    score = score + 100;
                    ball.X = 300;
                    ball.Y = 15;
                }
                else if(ball.X <= 400)
                {
                    scoreLabel1.Text = $"{score}";
                    score = score + 100;
                    ball.X = 300;
                    ball.Y = 15;
                }
                else if(ball.X <= 500)
                {
                    scoreLabel1.Text = $"{score}";
                    score = score - 50;
                    ball.X = 300;
                    ball.Y = 15;
                }
                else
                {
                    scoreLabel1.Text = $"{score}";
                    score = score + 50;
                    ball.X = 300;
                    ball.Y = 15;
                }
               
            }
            Refresh();
        }
    }
}

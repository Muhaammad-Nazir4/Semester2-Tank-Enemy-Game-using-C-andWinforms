using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
namespace Tank_Enemies_game
{
    public partial class Form1 : Form
    {

        bool upwardDirection, downwardDirection,  gameOver = false;
        int count = 0;
        int score = 0;
       int speed = 8;
        int enemySpeed = 10;

        Random rand = new Random();

        int playerSpeed = 7;
       int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count % 50 == 0) 
            {
                makeenemyfire();
            }
            
            moveenemyfire();
            removeenemyfires();
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                myTankPictureBox.Top = myTankPictureBox.Top - 10;
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                myTankPictureBox.Top = myTankPictureBox.Top + 10;

            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                MakeBullet();
            }
           
            scoreTextBox.Text = "Score: " + score;

            if (upwardDirection== true && myTankPictureBox.Top > 0)
            {
                myTankPictureBox.Top -= playerSpeed;
            }
            if (downwardDirection == true && myTankPictureBox.Top + myTankPictureBox.Height < this.ClientSize.Height)
            {
                myTankPictureBox.Top += playerSpeed;
            }

            enemyTankPictureBox.Left -= enemySpeed;

            if (enemyTankPictureBox.Left + enemyTankPictureBox.Width < 0)
            {
                ChangeEnemy();
            }

            foreach (Control x in this.Controls)
            {
                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && (string)y.Tag == "enemybullet")
                    {

                        y.Left=y.Left-7;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "hurdle")
                {
                    x.Left -= speed;


                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }

                    if (myTankPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }

                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;

                    if (x.Left > 900)
                    {
                        RemoveBullet(((PictureBox)x));
                    }


                    if (enemyTankPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        RemoveBullet(((PictureBox)x));
                        score += 1;
                        ChangeEnemy();
                    }

                }

            }


            if (myTankPictureBox.Bounds.IntersectsWith(enemyTankPictureBox.Bounds))
            {
                GameOver();
            }

            if (score > 10)
            {
                speed = 12;
                enemySpeed = 18;
            }
        }

        private void restet()
        {
           
        }
        private void RestartGame()
        {

            upwardDirection = false;
            downwardDirection = false;
            gameOver = false;
            score = 0;
            speed = 8;
            enemySpeed = 10;

            scoreTextBox.Text = "Score: " + score;

            ChangeEnemy();

            myTankPictureBox.Top = 119;

            hurdelPictureBox1.Left = 174;
            hurdelPictureBox2.Left = 531;
            hurdelPictureBox3.Left = 174;
            hurdelPictureBox4.Left = 531;
            hurdelPictureBox5.Left = 346;
            timerForGame.Start();


        }
        private void removeenemyfires()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemybullet")
                {
                    if (x.Left < 0)
                    {
                        Controls.Remove(x);
                    }
                }
            }
        }
        private void moveenemyfire()
        {
           
        }
        private void makeenemyfire()
        {
            PictureBox enemyfire = new PictureBox();
            enemyfire.Tag = "enemybullet";
            enemyfire.BackgroundImage = Properties.Resources.bullets;
            enemyfire.BackColor = Color.Transparent;
            enemyfire.BackgroundImageLayout = ImageLayout.Stretch;
            enemyfire.Size = new Size(20,20);
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    enemyfire.Left = x.Left - enemyfire.Width;
                    enemyfire.Top = x.Top + enemyfire.Height;
                } 
            } 
            this.Controls.Add(enemyfire);
        }
        private void GameOver()
        {
            gameOver = true;
            timerForGame.Stop();
            scoreTextBox.Text = "Score: " + score + " Game over, press enter to retry!";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void player_Click(object sender, EventArgs e)
        //{

        //}

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(gameOver==true && Keyboard.IsKeyPressed(Key.Enter))
            {
                RestartGame();
            }
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Maroon;
            bullet.Height = 5;
            bullet.Width = 10;

            bullet.Left = myTankPictureBox.Left + myTankPictureBox.Width;
            bullet.Top = myTankPictureBox.Top + myTankPictureBox.Height / 2;

            bullet.Tag = "bullet";

            this.Controls.Add(bullet);

        }

        private void ChangeEnemy()
        {


            if (index > 3)
            {
                index = 1;
            }
            else
            {
                index += 1;
            }


            switch (index)
            {
                case 1:
                    enemyTankPictureBox.Image = Properties.Resources.enemypic2;
                    break;
                case 2:
                    enemyTankPictureBox.Image = Properties.Resources.enemypic3;
                    break;
                case 3:
                    enemyTankPictureBox.Image = Properties.Resources.enemypic2;
                    break;
            }

            enemyTankPictureBox.Left = 1000;

            enemyTankPictureBox.Top = rand.Next(20, this.ClientSize.Height - enemyTankPictureBox.Height);

        }



    }
}

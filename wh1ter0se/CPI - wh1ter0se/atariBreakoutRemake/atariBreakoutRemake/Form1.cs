using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace atariBreakoutRemake
{
    public partial class Form1 : Form
    {

        ////////////////////// Initial Constructor //////////////////////

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(600, 450);
            AssignDefaults();
        }



        ////////////////////// Variables //////////////////////

        bool firstRun;
        bool pauseDuringSpawn;
        bool spawnIsRunning;
        bool youLost;
        bool[] brickExists;
        int brickColumnCount;
        int brickRowCount;
        int currentScreen;
            // 0 = title
            // 1 = game
            // 2 = pause
            // 3 = game over
        int lastScannedScore;
        int lives;
        int paddleSpeed;
        int score;
        int selectedPauseItem;
        int[] runningVelocity;
            // 0 = rise
            // 1 = run
        PictureBox[] picBricks;
        Rectangle[] bricks;
        System.Drawing.Color blackBrush;
        System.Drawing.Color blueBrush;
        System.Drawing.Color brickRowColor;
        System.Drawing.Color greenBrush;
        System.Drawing.Color orangeBrush;
        System.Drawing.Color purpleBrush;
        System.Drawing.Color redBrush;
        System.Drawing.Color yellowBrush;
        System.Drawing.Color whiteBrush;



        ////////////////////// Chronology Methods //////////////////////

        private void AssignDefaults() // sets variables to initial values 
        {
            brickColumnCount = 0;
            brickExists = new bool[60];
            brickRowCount = 0;
            bricks = new Rectangle[60];
            currentScreen = 0;
            firstRun = true;
            lastScannedScore = 0;
            lives = 3;
            paddleSpeed = 8;
            picBricks = new PictureBox[60];
            runningVelocity = new int[2];
            score = 0;
            selectedPauseItem = 0;
            youLost = false;

            // color codes 

            blackBrush = System.Drawing.Color.White;
            blueBrush = System.Drawing.ColorTranslator.FromHtml("#005784");
            greenBrush = System.Drawing.ColorTranslator.FromHtml("#44891A");
            orangeBrush = System.Drawing.ColorTranslator.FromHtml("#EB8931");
            purpleBrush = System.Drawing.ColorTranslator.FromHtml("#CB43A7");
            redBrush = System.Drawing.ColorTranslator.FromHtml("#BE2633");
            yellowBrush = System.Drawing.ColorTranslator.FromHtml("#FAB40B");
            whiteBrush = System.Drawing.Color.White;
        }

        private void GameOver() // ya lost 
        {
            currentScreen = 3;
            this.Size = new Size(600, 450);
            picOverlay.Visible = true;
            picOverlay.BringToFront();
            picOverlay.Image = Properties.Resources.atariBreakoutGameOver;
        }

        private void LoadGame() // sets up the bricks and stuff 
        {
            currentScreen = 1;
            picOverlay.Visible = false;
            this.Size = new Size(600, 480);
            // <bricks>
                brickRowColor = redBrush; 
                for (int i = 0; i < 60; i++)
                {
                    brickExists[i] = true;
                    bricks[i] = new System.Drawing.Rectangle(
                        Convert.ToInt32(brickRowCount * 60),
                        Convert.ToInt32(50 + (brickColumnCount * 25)),
                        60,
                        25);
                    this.picBricks[i] = new PictureBox();
                    this.Controls.Add(this.picBricks[i]);
                    this.picBricks[i].Name = "brick" + i.ToString();
                    this.picBricks[i].Left = Convert.ToInt32(brickRowCount * 60);
                    this.picBricks[i].Top = Convert.ToInt32(50 + (brickColumnCount * 25));
                    this.picBricks[i].Width = 60;
                    this.picBricks[i].Height = 25;
                    this.picBricks[i].Visible = true;
                    this.picBricks[i].BackColor = brickRowColor;
                    this.picBricks[i].BringToFront();
                    brickRowCount++;
                    if (brickRowCount > 9)
                    {
                        brickRowCount = 0; 
                        brickColumnCount++;
                        if (brickColumnCount == 1) { brickRowColor = orangeBrush; }
                        if (brickColumnCount == 2) { brickRowColor = yellowBrush; }
                        if (brickColumnCount == 3) { brickRowColor = greenBrush; }
                        if (brickColumnCount == 4) { brickRowColor = blueBrush; }
                        if (brickColumnCount == 5) { brickRowColor = purpleBrush; }
                    }
                }
            // </bricks>
            tmrSpawnDelay.Start(); 
        }

        private void PauseGame() // pauses the game 
        {
            currentScreen = 2;
            tmrMoveBall.Stop(); tmrMovePaddle.Stop();
            if (spawnIsRunning)
            {
                tmrSpawnDelay.Stop(); firstRun = false; pauseDuringSpawn = true;
            }
            picOverlay.Visible = true;
            picOverlay.BringToFront();
            picOverlay.Image = Properties.Resources.atariBreakoutResume;
            this.Size = new Size(600, 450);
        }

        private void UnpauseGame() // unpauses the game 
        {
            currentScreen = 1;
            tmrMoveBall.Start(); tmrMovePaddle.Start();
            if (pauseDuringSpawn)
            {
                tmrSpawnDelay.Start(); pauseDuringSpawn = false;
            }
            picOverlay.Visible = false;
            this.Size = new Size(600, 480);
        }



        ////////////////////// Game Methods //////////////////////

        private void CurryRebound() // bounces ball off of paddle 
        {
            int xVelocity;
                xVelocity = (picBall.Left + 10) - picPaddle.Left;
                if (xVelocity > 50)
                {
                    xVelocity -= 50;
                    xVelocity = Convert.ToInt32(xVelocity / 10);
                }
                else if (xVelocity == 50)
                {
                    xVelocity = 0;
                }
                else
                {
                    xVelocity = (xVelocity * -1) + 50;
                    xVelocity = Convert.ToInt32(xVelocity / 10);
                    xVelocity *= -1;
                }
                VelocityChange(-5, xVelocity);
            }

        private void LevelUp() // accelerates ball and rebuilds bricks 
        {

        }

        private void MoveBall() // moves the ball one pixel at a time 
        {
            picBall.Left += runningVelocity[1];
            picBall.Top += runningVelocity[0];
        }

        private void RandSpawn() // generates a random angle, genius 
        {
            int tempRun;
            Random rnd = new Random();
            //tempRise = rnd.Next(-5, 6); if (tempRise == 0) { tempRise = 1; }
            tempRun = rnd.Next(-10, 11); if (tempRun == 0) { tempRun = 1; }
            VelocityChange(-5, tempRun);
            tmrMoveBall.Start();
        }

        private void ResetBricks() // rebuilds the bricks after an entire board is completed 
        {          
            for (int i = 0; i < 60; i++)
            {
                brickExists[i] = true;
                picBricks[i].Visible = true;
                picBricks[i].BringToFront();
            }
        }

        private void ScanIntersections() // searches for ball collisions 
        {
            Rectangle ball = new Rectangle(picBall.Left, picBall.Top, 20, 20);
            Rectangle paddle = new Rectangle(picPaddle.Left, picPaddle.Top, 100, 15);

            if (ball.Left < 0) // bounce off left wwall
            {
                picBall.Left = 0;
                runningVelocity[1] *= -1;
            }
            if (ball.Right > 600) // bounce off right wall 
            {
                picBall.Left = 580;
                runningVelocity[1] *= -1;
            }
            if (ball.Top < 0) // bounce off ceiling
            {
                runningVelocity[0] *= -1;
            }
            if (ball.IntersectsWith(paddle) && ball.Bottom < 425) // bounce off paddles
            {
                CurryRebound();
            }
            if (ball.Bottom > 600) // lose a life
            {
                YouReallyDroppedTheBallOnThisOne();
            }
            for (int i = 0; i < 60; i++) // bounces off bricks
            {
                if (ball.IntersectsWith(bricks[i]) && brickExists[i]) 
                {
                    brickExists[i] = false;
                    picBricks[i].Visible = false;
                    score++;
                    lblScore.Text = "SCORE: " + score.ToString();
                    Rectangle leftWall = new Rectangle(bricks[i].Left, bricks[i].Top, 1, 25);
                    Rectangle topWall = new Rectangle(bricks[i].Left, bricks[i].Top, 60, 1);
                    Rectangle rightWall = new Rectangle((bricks[i].Left + 59), bricks[i].Top, 1, 25);
                    Rectangle bottomWall = new Rectangle(bricks[i].Left, (bricks[i].Top + 24), 60, 1);
                    if (ball.IntersectsWith(bottomWall))
                    {
                        runningVelocity[0] *= -1;
                    }
                    else if (ball.IntersectsWith(topWall))
                    {
                        runningVelocity[0] *= -1;
                    }
                    if (ball.IntersectsWith(leftWall))
                    {
                        runningVelocity[1] *= -1;
                    }
                    else if (ball.IntersectsWith(rightWall))
                    {
                        runningVelocity[1] *= -1;
                    }
                }
            }
        }

        private void VelocityChange(int rise, int run) // adjusts the x and y velocities of pingBall; triggered after a bounce 
        {
            //int largerVelocity;
            //int largestVelocity;
            //int multiplier;
            //int smallerVelocity;
            //if (run == 0) { run = 1; }
            //if (rise >= run)
            //{
            //    largestVelocity = 0;
            //    largerVelocity = rise;
            //    smallerVelocity = run;
            //}
            //else
            //{
            //    largestVelocity = 1;
            //    largerVelocity = run;
            //    smallerVelocity = rise;
            //}
            //multiplier = Convert.ToInt32(5 / largerVelocity);
            //if (multiplier > 0) { largerVelocity = 5; }
            //else if (multiplier < 0) { largerVelocity = -5; }
            //else { largerVelocity = 0; }
            //if (multiplier > 0 && run != 0) { smallerVelocity = Convert.ToInt32((5 / smallerVelocity) * multiplier) * -1; }
            //else if (multiplier < 0) { smallerVelocity = Convert.ToInt32((5 / smallerVelocity) * multiplier); }
            //else { smallerVelocity = 0; }
            // exception for negative rise and positive run
            //if (rise < 0)
            //{
            //    if (largestVelocity == 0) { largerVelocity *= -1; }
            //    else { smallerVelocity *= -1; }
            //}
            //
            //if (largestVelocity == 0)
            //{
            //    runningVelocity[0] = largerVelocity;
            //    runningVelocity[1] = smallerVelocity;
            //}
            //else
            //{
            //    runningVelocity[0] = smallerVelocity;
            //    runningVelocity[1] = largerVelocity;
            //}

            ///

            runningVelocity[0] = rise;
            runningVelocity[1] = run;
        }

        private void YouReallyDroppedTheBallOnThisOne() // self explanatory 
        {
            lives--;
            lblLives.Text = "LIVES: " + lives.ToString();
            if (lives < 1)
            {
                tmrMoveBall.Stop();
                tmrMovePaddle.Stop();
                youLost = true;
                tmrSpawnDelay.Start();
            }
            else
            {
                tmrSpawnDelay.Start();
                tmrMoveBall.Stop();
                tmrMovePaddle.Stop();
                picBall.Location = new Point(290, 399);
                picPaddle.Location = new Point(250, 420);
            }
        }



        ////////////////////// Timers and Events //////////////////////

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (currentScreen == 0)
            {
                LoadGame();
            }
            if (currentScreen == 3)
            {
                Application.Exit();
            }
            if ((e.KeyCode == Keys.Escape || e.KeyCode == Keys.P) && currentScreen == 1)
            {
                PauseGame();
            }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) && currentScreen == 2)
            {
                if (selectedPauseItem == 0) { selectedPauseItem = 1; picOverlay.Image = Properties.Resources.atariBreakoutExit; } else { selectedPauseItem = 0; picOverlay.Image = Properties.Resources.atariBreakoutResume; }
            }
            if (e.KeyCode == Keys.Enter && currentScreen == 2)
            {
                if (selectedPauseItem == 0) { UnpauseGame(); } else { Application.Exit(); }
            }
        }

        private void tmrMoveBall_Tick(object sender, EventArgs e)
        {
            MoveBall();
            ScanIntersections();
            if (score % 60 == 0 && score != lastScannedScore)
            {
                lastScannedScore = score;
                ResetBricks();
                if (tmrMoveBall.Interval != 1) { tmrMoveBall.Interval--; }
                tmrMoveBall.Stop(); tmrMovePaddle.Stop();
                picBall.Location = new Point(290, 399);
                picPaddle.Location = new Point(250, 420);
                tmrSpawnDelay.Start();
            }

        }

        private void tmrSpawnDelay_Tick(object sender, EventArgs e)
        {
            if (firstRun) { firstRun = false; spawnIsRunning = true; }
            else
            {
                if (!youLost)
                {
                    firstRun = true;
                    spawnIsRunning = false;
                    RandSpawn();
                    tmrMoveBall.Start();
                    tmrMovePaddle.Start();
                    tmrSpawnDelay.Stop();
                }
                else
                {
                    firstRun = true;
                    tmrSpawnDelay.Stop();
                    GameOver();
                }
            }
        }

        private void tmrMovePaddle_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Left) && picPaddle.Left > 0 && !(Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.Right)))
            {
                picPaddle.Left -= paddleSpeed;
            }
            else if (Keyboard.IsKeyDown(Key.Right) && picPaddle.Right < 600 && !(Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.Right)))
            {
                picPaddle.Left += paddleSpeed;
            }
        }

    }
}

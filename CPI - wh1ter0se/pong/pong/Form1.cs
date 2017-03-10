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
using System.Windows.Media;

namespace pong
{
    public partial class Form1 : Form
    {

        ////////////////////// Initial Constructor //////////////////////

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(450, 600);
            AssignVariables();
            LoadModeSelection();
        }



        ////////////////////// Variables //////////////////////

        bool activatedSpecialFirstRun;
        bool firstRun;
        bool specialFirstRun;
        bool topWins;
        int bottomAutoSpeed;
        int currentBallColor;
        int currentBottomPaddleColor;
        int currentScreen;
            // 0 = mode selection
            // 1 = control screen
            // 2 = game screen
            // 3 = pause screen
        int currentTopPaddleColor;
        int gameMode;
            // 0 = multiplayer mode
            // 1 = singleplayer mode
            // 2 = spectate mode
        int largestVelocity;
            // 0 = rise[0] is larger
            // 1 = run[1] is larger
        int manualSpeed;
        int selectedGameMode;
        int specialState;
            // 0 = invisible
            // 1 = visible
            // 2 = used
        int tempRise;
        int tempRun;
        int topAutoSpeed;
        int[] runningVelocity;
            // 0 = rise
            // 1 = run
        int[] score;
            // 0 = top score
            // 1 = bottom score
        int selectedPauseItem;
        System.Drawing.Color[] colors;



        ////////////////////// Chronology Methods //////////////////////

        private void LoadControlScreen() // loads control listings 
        {
            currentScreen = 1;
            picModeSelect.Image = Properties.Resources.pongControls;
        }

        private void LoadGame() // loads game 
        {
            currentScreen = 2;
            picModeSelect.Visible = false;
            this.ClientSize = new System.Drawing.Size(500, 600);
            tmrSpawnDelay.Start();
        }

        private void LoadModeSelection() // loads gamemode selection screen 
        {
            currentScreen = 0;
        }



        ////////////////////// Game Methods //////////////////////

        private void AssignVariables() // it assigns the variables, bud 
        {
            // defaults

            activatedSpecialFirstRun = true;
            bottomAutoSpeed = 3;
            colors = new System.Drawing.Color[6];
            colors[0] = System.Drawing.ColorTranslator.FromHtml("#BE2633");
            colors[1] = System.Drawing.ColorTranslator.FromHtml("#EB8931");
            colors[2] = System.Drawing.ColorTranslator.FromHtml("#FAB40B");
            colors[3] = System.Drawing.ColorTranslator.FromHtml("#44891A");
            colors[4] = System.Drawing.ColorTranslator.FromHtml("#005784");
            colors[5] = System.Drawing.ColorTranslator.FromHtml("#CB43A7");
            currentBallColor = 0;
            currentBottomPaddleColor = 1;
            currentScreen = 0;
            currentTopPaddleColor = 2;
            firstRun = true;
            gameMode = 0;
            manualSpeed = 4;
            score = new int[2];
            score[0] = 0;
            score[1] = 0;
            runningVelocity = new int[2];
            runningVelocity[0] = 0;
            runningVelocity[1] = 0;
            selectedGameMode = 0;
            specialFirstRun = true;
            specialState = 0;
            topAutoSpeed = 4;
            topWins = true;



            // constants



        }

        private void CurryRebound(int paddle) // bounces ball off of paddle 
        {
            // paddle codes
                // 0 = top
                // 1 = bottom
            int xVelocity;
            if (paddle == 0)
            {
                xVelocity = (picBall.Left + 10) - picTopPaddle.Left;
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
                VelocityChange(5, xVelocity);
            }
            else
            {
                xVelocity = (picBall.Left + 10) - picBottomPaddle.Left;
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
        }

        private void GenerateRandomAngle() // generates a random angle, genius 
        {
            Random rnd = new Random();
            //tempRise = rnd.Next(-5, 6); if (tempRise == 0) { tempRise = 1; }
            tempRun = rnd.Next(-5, 6); if (tempRun == 0) { tempRun = 1; }
            VelocityChange(5, tempRun);
            tmrSpecial.Start();
            tmrMoveBall.Interval = 14;
            tmrProgressiveSpeed.Start();
        }

        private void MoveBall() // moves the ball one pixel at a time 
        {
            picBall.Left += runningVelocity[1];
            picBall.Top += runningVelocity[0];
        }

        private void PauseGame() // pauses the game 
        {
            currentScreen = 3;
            this.ClientSize = new System.Drawing.Size(450, 600);
            tmrMoveBall.Stop(); tmrMovePaddle.Stop();
            picModeSelect.Visible = true; picModeSelect.BringToFront();
            picModeSelect.Image = Properties.Resources.pongResume;
            selectedPauseItem = 0;
        }

        private void ScanIntersections() // scans for ball collisions 
        {
            Rectangle ball = new Rectangle(picBall.Left, picBall.Top, 20, 20);
            Rectangle bottomPaddle = new Rectangle(picBottomPaddle.Left, picBottomPaddle.Top, 100, 15);
            Rectangle bottomWall = new Rectangle(picBottomWall.Left, picBottomWall.Left, 450, 20);
            Rectangle leftWall = new Rectangle(picLeftWall.Left, picLeftWall.Top, 20, 600);
            Rectangle rightWall = new Rectangle(picRightWall.Left, picRightWall.Top, 20, 600);
            Rectangle special = new Rectangle(picSpecial.Left-10, picSpecial.Top-10, 40, 40);
            Rectangle topPaddle = new Rectangle(picTopPaddle.Left, picTopPaddle.Top, 100, 15);
            Rectangle topWall = new Rectangle(picTopWall.Left, picTopWall.Top, 450, 20);
            if (ball.Left < 0) // ball.IntersectsWith(leftWall)
            {
                runningVelocity[1] *= -1;
                if (specialState == 2)
                {
                    currentBallColor++;
                    if (currentBallColor > 5) { currentBallColor = 0; }
                    picBall.BackColor = colors[currentBallColor];
                }
            }
            else if (ball.Right > 450) // ball.IntersectsWith(rightWall)
            {
                runningVelocity[1] *= -1;
                if (specialState == 2) {
                    currentBallColor++;
                    if (currentBallColor > 5) { currentBallColor = 0; }
                    picBall.BackColor = colors[currentBallColor];
                }
            }
            else if (ball.Top < 0) // ball.IntersectsWith(topWall) || 
            {
                score[1]++;
                tmrProgressiveSpeed.Stop();
                specialFirstRun = true;
                tmrSpecial.Stop();
                lblBottomScore.Text = score[1].ToString();
                picBall.Left = 215; picBall.Top = 290;
                picTopPaddle.Left = 175; picBottomPaddle.Left = 175;
                tmrMovePaddle.Stop();
                tmrMoveBall.Stop();
                tmrSpawnDelay.Start();
                if (gameMode == 2)
                {
                    if (topWins) { topWins = false; topAutoSpeed = 2; bottomAutoSpeed = 5; }
                    else { topWins = true; topAutoSpeed = 5; bottomAutoSpeed = 2; }
                }
            }
            else if (ball.Bottom > 600) // ball.IntersectsWith(bottomWall) || 
            {
                score[0]++;
                tmrProgressiveSpeed.Stop();
                specialFirstRun = true;
                tmrSpecial.Stop();
                lblTopScore.Text = score[0].ToString();
                picBall.Left = 215; picBall.Top = 290;
                picTopPaddle.Left = 175; picBottomPaddle.Left = 175;
                tmrMovePaddle.Stop();
                tmrMoveBall.Stop();
                tmrSpawnDelay.Start();
                if (gameMode == 2)
                {
                    if (topWins) { topWins = false; topAutoSpeed = 2; bottomAutoSpeed = 5; }
                    else { topWins = true; topAutoSpeed = 5; bottomAutoSpeed = 2; }
                }
            }
            else if (ball.IntersectsWith(bottomPaddle) && ball.Bottom < 585)
            {
                CurryRebound(1);
                //runningVelocity[0] = Math.Abs(runningVelocity[0]) * -1;
                if (specialState == 2)
                {
                    currentBallColor++;
                    if (currentBallColor > 5) { currentBallColor = 0; }
                    picBall.BackColor = colors[currentBallColor];
                    currentBottomPaddleColor++;
                    if (currentBottomPaddleColor > 5) { currentBottomPaddleColor = 0; }
                    picBottomPaddle.BackColor = colors[currentBottomPaddleColor];
                }
            }
            else if (ball.IntersectsWith(topPaddle) && ball.Top > 15)
            {
                CurryRebound(0);
                //runningVelocity[0] = Math.Abs(runningVelocity[0]);
                if (specialState == 2)
                {
                    currentBallColor++;
                    if (currentBallColor > 5) { currentBallColor = 0; }
                    picBall.BackColor = colors[currentBallColor];
                    currentTopPaddleColor++;
                    if (currentTopPaddleColor > 5) { currentTopPaddleColor = 0; }
                    picTopPaddle.BackColor = colors[currentTopPaddleColor];
                }
            }
            if (ball.IntersectsWith(special) && picSpecial.Visible)
            {
                specialState = 2;
                currentBallColor++;
                if (currentBallColor > 5) { currentBallColor = 0; }
                picBall.BackColor = colors[currentBallColor];
                tmrSpecial.Stop();
                tmrActivatedSpecial.Start();
                manualSpeed *= 2;
                topAutoSpeed *= 2;
                bottomAutoSpeed *= 2;
                tmrMoveBall.Interval /= 2;
                currentBallColor = 0;
                currentBottomPaddleColor = 2;
                currentTopPaddleColor = 4;
                picSpecial.Visible = false;
            }
        }

        private void UnpauseGame() // unpauses the game 
        {
            currentScreen = 2;
            this.ClientSize = new System.Drawing.Size(500, 600);
            picModeSelect.Visible = false;
            tmrMoveBall.Start(); tmrMovePaddle.Start();
        }

        private void VelocityChange(int rise, int run) // adjusts the x and y velocities of pingBall; triggered after a bounce 
        {
            int largerVelocity;
            int smallerVelocity;
            int multiplier;
            if (rise > run)
            {
                largestVelocity = 0;
                largerVelocity = rise;
                smallerVelocity = run;
            }
            else
            {
                largestVelocity = 1;
                largerVelocity = run;
                smallerVelocity = rise;
            }
            if (largerVelocity == 0) { largerVelocity = 1; }
            multiplier = Convert.ToInt32(5 / largerVelocity);
            if (multiplier > 0) { largerVelocity = 5; }
            else if (multiplier < 0) { largerVelocity = -5; }
            else { largerVelocity = 0; }
            if (multiplier > 0 && run != 0) { smallerVelocity = Convert.ToInt32((5 / smallerVelocity) * multiplier) * -1; }
            else if (multiplier < 0) { smallerVelocity = Convert.ToInt32((5 / smallerVelocity) * multiplier); }
            else { smallerVelocity = 0; }
            // exception for negative rise and positive run
            if (rise < 0)
            {
                if (largestVelocity == 0) { largerVelocity *= -1; }
                else { smallerVelocity *= -1; }
            }

            if (largestVelocity == 0)
            {
                runningVelocity[0] = largerVelocity;
                runningVelocity[1] = smallerVelocity;
            }
            else
            {
                runningVelocity[0] = smallerVelocity;
                runningVelocity[1] = largerVelocity;
            }
        }



        ////////////////////// Timers and Events //////////////////////



        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract && currentScreen == 0)
            {
                gameMode = 2;
                tmrMoveBall.Interval = 5;
                LoadControlScreen();
            }
            if (currentScreen == 1)
            {
                LoadGame();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (currentScreen == 0)
                {
                    if (selectedGameMode == 0) { selectedGameMode = 1; picModeSelect.Image = Properties.Resources.pongSingleplayer; }
                    else { selectedGameMode = 0; picModeSelect.Image = Properties.Resources.pongMultiplayer; }
                }
                else if (currentScreen == 3)
                {
                    if (selectedPauseItem == 0) { selectedPauseItem = 1; picModeSelect.Image = Properties.Resources.pongExit; }
                    else { selectedPauseItem = 0; picModeSelect.Image = Properties.Resources.pongResume; }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (currentScreen == 0)
                {
                    if (selectedGameMode == 0) { selectedGameMode = 1; picModeSelect.Image = Properties.Resources.pongSingleplayer; }
                    else { selectedGameMode = 0; picModeSelect.Image = Properties.Resources.pongMultiplayer; }
                }
                else if (currentScreen == 3)
                {
                    if (selectedPauseItem == 0) { selectedPauseItem = 1; picModeSelect.Image = Properties.Resources.pongExit; }
                    else { selectedPauseItem = 0; picModeSelect.Image = Properties.Resources.pongResume; }
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (currentScreen == 0)
                {
                    gameMode = selectedGameMode;
                    LoadControlScreen();
                }
                else if (currentScreen == 3)
                {
                    if (selectedPauseItem == 0) { UnpauseGame(); }
                    if (selectedPauseItem == 1) { Application.Exit(); }
                }
            }
            if ((e.KeyCode == Keys.P || e.KeyCode == Keys.Escape) && (currentScreen == 2))
            {
                PauseGame();
            }
        }

        private void tmrMoveBall_Tick(object sender, EventArgs e)
        {
            MoveBall();
            ScanIntersections();
        }

        private void tmrMovePaddle_Tick(object sender, EventArgs e) 
        {
            if (gameMode < 2)
            {
                if (Keyboard.IsKeyDown(Key.Left))
                {
                    picBottomPaddle.Left -= manualSpeed;
                    if (picBottomPaddle.Left < 0) { picBottomPaddle.Left = 0; }
                }
                if (Keyboard.IsKeyDown(Key.Right))
                {
                    picBottomPaddle.Left += manualSpeed;
                    if (picBottomPaddle.Left > 350) { picBottomPaddle.Left = 350; }
                }
            }
            else
            {
                if ((picBottomPaddle.Left + 20) > picBall.Left) { picBottomPaddle.Left -= bottomAutoSpeed; }
                if (picBottomPaddle.Left < 0) { picBottomPaddle.Left = 0; }
                if ((picBottomPaddle.Left + 60) < picBall.Left) { picBottomPaddle.Left += bottomAutoSpeed; }
                if (picBottomPaddle.Left > 350) { picBottomPaddle.Left = 350; }
            }
            if (gameMode == 0)
            {
                if (Keyboard.IsKeyDown(Key.A))
                {
                    picTopPaddle.Left -= manualSpeed;
                    if (picTopPaddle.Left < 0) { picTopPaddle.Left = 0; }
                }
                if (Keyboard.IsKeyDown(Key.D))
                {
                    picTopPaddle.Left += manualSpeed;
                    if (picTopPaddle.Left > 350) { picTopPaddle.Left = 350; }
                }
            }
            else if (gameMode == 1)
            {
                if ((picTopPaddle.Left + 60) > picBall.Left && picTopPaddle.Left > 0) { picTopPaddle.Left -= topAutoSpeed; }
                if ((picTopPaddle.Left + 20) < picBall.Left && picTopPaddle.Left < 350) { picTopPaddle.Left += topAutoSpeed; }
            }
            else
            {
                if ((picTopPaddle.Left + 30) > picBall.Left) { picTopPaddle.Left -= topAutoSpeed; }
                if (picTopPaddle.Left < 0) { picTopPaddle.Left = 0; }
                if ((picTopPaddle.Left + 45) < picBall.Left) { picTopPaddle.Left += topAutoSpeed; }
                if (picTopPaddle.Left > 350) { picTopPaddle.Left = 350; }
            }
            
        }

        private void tmrSpawnDelay_Tick(object sender, EventArgs e)
        {
            if (firstRun) { firstRun = false; }
            else {
                GenerateRandomAngle();
                tmrMovePaddle.Start();
                tmrMoveBall.Start();
                firstRun = true;
                tmrSpawnDelay.Stop();
                tmrSpecial.Start();
            }
        }



        ////////////////////// Executioner //////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrSpecial_Tick(object sender, EventArgs e)
        {
            if (specialFirstRun) { specialFirstRun = false; }
            else
            {
                Random rnd = new Random();
                specialFirstRun = true;
                picSpecial.Left = rnd.Next(100, 351) + 10;
                picSpecial.Top = rnd.Next(250, 351);
                picSpecial.Visible = true;
                tmrSpecial.Stop();
            }
        }

        private void tmrActivatedSpecial_Tick(object sender, EventArgs e)
        {
            if (activatedSpecialFirstRun) { activatedSpecialFirstRun = false; }
            else
            {
                manualSpeed /= 2;
                topAutoSpeed /= 2;
                bottomAutoSpeed /= 2;
                tmrMoveBall.Interval *= 2;
                activatedSpecialFirstRun = true;
                picSpecial.Visible = false;
                specialState = 0;
                picBall.BackColor = System.Drawing.Color.White;
                picBottomPaddle.BackColor = System.Drawing.Color.White;
                picTopPaddle.BackColor = System.Drawing.Color.White;
                tmrActivatedSpecial.Stop();
                tmrSpecial.Start();
            }
        } 

        private void tmrProgressiveSpeed_Tick(object sender, EventArgs e)
        {
            if (tmrMoveBall.Interval > 2) { tmrMoveBall.Interval -= 2; }
        }
    }
}

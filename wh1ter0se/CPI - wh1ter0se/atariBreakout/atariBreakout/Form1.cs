using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace atariBreakout
{
    public partial class Form1 : Form
    {
            // TODO change lyk button text on title screen
            // TODO change the flash so it it solid in the first frame on the DifSelect screen
                // add "HIT ENTER TO CONTINUE" and "USE ARROW KEYS TO SELECT DIFFICULTY"
            // TODO add control screen in between the DifSelect screen and the game screen
            // TODO set delay on game start
                // make it launch at 90 degrees after 3 seconds
                // make it activate game timer
                // use for score time multiplier
            // TODO finish brick array
            // TODO finish CurryRebound
            // TODO figure out rectangle coloring
            // TODO do a lot of testing on the angles
            // TODO start implementing differences in difficulty
                // make 3 different leaderboards
            // TODO finish code for mouse detection and paddle movement
                // (?) set it for selection of difficulty
            // TODO finish pause screen
                // finish image
                // finish corresponding functions
                // resume
                // exit
                // controls
                // paddle mode
                    // mouse
                    // keyboard (default)
            // TODO sweep code for left over dynamic window size code
            // TODO clean up code
                // relocate appropriately
                // fix inefficient processes
                // remove unused code
            // TODO make pause screen stuff
                // add actions to up and down keys
                // add action to enter key
                    // if over resume, resume
                    // if over paddle type, convert to inverse

        ///////////////////////// Things I Need To Ask Miller About /////////////////////////
            
            // talk about paint event
                // go back to coloring rectangles
            // get help on setting up server
                // (?) y115 firewall blocks sql access
            
        ///////////////////////// Initial Constructor /////////////////////////

        public Form1()
        {
            InitializeComponent();
            VariableConstructor();
            BuildTitleScreen();
        }


        /////////////////////////  Utility Methods  /////////////////////////

        public static bool IsAnyKeyDown()
        {
            var values = Enum.GetValues(typeof(Key));

            foreach (var v in values)
            {
                if (((Key)v) != Key.None)
                {
                    if (Keyboard.IsKeyDown((Key)v))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        /////////////////////////  Variables  /////////////////////////

        bool instantTick;
        bool[] brickExists;
        int ballSize;
        int brickColumnCount;
        int brickRowCount;
        int currentPauseSelect;
            // 0 = resume
            // 1 = help
            // 2 = paddle mode
            // 3 = exit
        int currentScreen;
            // 0 = titleScreen
            // 1 = charSelectScreen
            // 2 = gameScreen
            // 3 = pauseScreen
            // 4 = help screen
            // 5 = score screen
        int difficultyLevel;
            // 0 = n00b
            // 1 = normie
            // 2 = vet
        int largestVelocity;
            // 0 = rise[0] is larger
            // 1 = run[1] is larger
        int livesRemaining;
        int mouseX;
        int mouseY;
        int paddleMode;
            // 0 = keyboard (default)
            // 1 = mouse
        int paddleWidth;
        int pauseCurrentSelection;
        int score;
            // [0] = vertical count
            // [1] = horizontal count
        int[] runningVelocity;
            // 0 = rise
            // 1 = run
        PictureBox picBall;
        PictureBox picPaddle;
        PictureBox[] picBricks;
        Point newMousePosition;
        System.Drawing.Color blackBrush;
        System.Drawing.Color blueBrush;
        System.Drawing.Color brickRowColor;
        System.Drawing.Color greenBrush;
        System.Drawing.Color orangeBrush;
        System.Drawing.Color purpleBrush;
        System.Drawing.Color redBrush;
        System.Drawing.Color yellowBrush;
        System.Drawing.Color whiteBrush;
        System.Drawing.Rectangle bottomWall;
        System.Drawing.Rectangle leftWall;
        System.Drawing.Rectangle paddle;
        System.Drawing.Rectangle pingBall;
        System.Drawing.Rectangle rightWall;
        System.Drawing.Rectangle topWall;
        System.Drawing.Rectangle[] bricks;


        /////////////////////////  Bricks  /////////////////////////



        /////////////////////////  Game Methods  /////////////////////////


        private void CurryRebound() // bounces pingBall off of paddle; needs to be finished 
        {
            int ballXPos = Convert.ToInt32(pingBall.X + Math.Round(ballSize * 0.5));
            int paddleXPos = paddle.X;
            int rise; int run;
            double reboundOutput = 90;
            double distFromLeft = ballXPos - paddleXPos;
            reboundOutput = Math.Round((distFromLeft / paddleWidth) * 180);
            if (reboundOutput < 1) { reboundOutput = 1; } else if (reboundOutput > 179) { reboundOutput = 179; }
            if (reboundOutput == 90)
            {
                rise = 1; run = 0;
            }
            else if (reboundOutput < 90) 
            {

            }
            else
            {
                reboundOutput -= 90;

            }
            //VelocityChange(rise, run);
        }
         
        private void LaunchBall()
        {
            VelocityChange(1, 0);
            tmrMoveBall.Start();
        }

        private void MovePaddle(int direction)
        {
            // direction 0 = left
            // direction 1 = right
            if (paddleMode == 0)
            {
                if (direction == 0)
                {

                }
                else
                {

                }
            }
            else
            {
                paddle.X = (MousePosition.X - (paddle.Width / 2));
            }
        }

        private void MovePingBall() // moves the ball one pixel
        {
            picBall.Left += runningVelocity[1];
            picBall.Top += runningVelocity[0];
        }

        private void SearchIntersections() // scans if the ball is intersecting with anything 
        {
            for (int i = 0; i < 60; i++) {
                if (pingBall.IntersectsWith(bricks[i]) && brickExists[i] == true) {
                    //rectangleGraphics.FillRectangle(blackBrush, bricks[i]);
                    brickExists[i] = false;
                    // write code to detect specific wall; WallRebound(0/1/2/3);
                    System.Drawing.Rectangle leftSide = new System.Drawing.Rectangle(bricks[i].Left, bricks[i].Top, 1, 25);
                }
            }
            if (pingBall.Left < 0) { runningVelocity[1] *= -1; }
            if (pingBall.IntersectsWith(topWall)) { runningVelocity[0] *= -1; }
            if (pingBall.Right > 450) { runningVelocity[1] *= -1; }
            if (pingBall.IntersectsWith(bottomWall)) { YouDroppedTheBallOnThisOne(); }
            if (pingBall.IntersectsWith(paddle)) { CurryRebound(); }
        }

        private void SwitchPaddleMode(int mode) // switches the paddle mode
        {
            if (mode == 0)
            {
                //Cursor.Show();
                tmrDetectMouse.Stop();
                tmrLeftKey.Start(); tmrRightKey.Start();
                paddleMode = 0;
            }
            else
            {
                //Cursor.Hide();
                tmrDetectMouse.Start();
                tmrLeftKey.Stop(); tmrRightKey.Stop();
                paddleMode = 1;
            }
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

        private void YouDroppedTheBallOnThisOne() // pretty self explanatory 
        {
            livesRemaining--;
            lblLivesRemaining.Text = "Lives: " + livesRemaining;
            if (livesRemaining < 1)
            {
                GameOver();
            }
            else
            {

                lblLivesRemaining.Text = "Lives: " + livesRemaining;
                tmrRespawn.Start();
                pingBall.Location = new Point(343, 420);
                paddle.Location = new Point((300 - (paddleWidth / 2)), 435);
                tmrRightKey.Stop();
                tmrLeftKey.Stop();
                tmrDetectMouse.Stop();
                tmrMoveBall.Stop();

            }
        }

        private void PlayTheGame(int difficulty) // plays the game
        {
            BuildGameScreen(difficulty);
            
        }


        /////////////////////////  Program Methods  /////////////////////////

        public void VariableConstructor() // set variables to their initial values 
        {
            /// Defaults ///

            ballSize = 15;
            brickColumnCount = 0;
            brickRowCount = 0;
            difficultyLevel = 1;
            instantTick = true;
            livesRemaining = 3;
            paddleMode = 0;
            paddleWidth = 100;

            /// Constants ///

            blackBrush = System.Drawing.Color.White;
            blueBrush = System.Drawing.ColorTranslator.FromHtml("#005784");
            greenBrush = System.Drawing.ColorTranslator.FromHtml("#44891A");
            orangeBrush = System.Drawing.ColorTranslator.FromHtml("#EB8931");
            purpleBrush = System.Drawing.ColorTranslator.FromHtml("#CB43A7");
            redBrush = System.Drawing.ColorTranslator.FromHtml("#BE2633");
            yellowBrush = System.Drawing.ColorTranslator.FromHtml("#FAB40B");
            whiteBrush = System.Drawing.Color.White;
        }
          
        public void BuildTitleScreen() // builds initial screen 
        {
            currentScreen = 0;
            picWorkingArea.Image = atariBreakout.Properties.Resources.titleScreen;
            tmrAnyKey.Start();
        }

        public void BuildDifSelectScreen() // builds difficulty selection screen 
        {
            currentScreen = 1;
            picWorkingArea.Image = Properties.Resources.normieDifficulty;
            // tmrDownKey.Start(); tmrUpKey.Start(); tmrEnterKey.Start();
        }

        public void BuildGameScreen(int level) // builds screen with game on it 
        {
            // pingBall code
             
            pingBall = new System.Drawing.Rectangle(
                343,
                420,
                ballSize,
                ballSize);
            //rectangleGraphics.FillRectangle(whiteBrush, pingBall);
            if (level == 0) { tmrMoveBall.Interval = 15; }
            else if (level == 1) { tmrMoveBall.Interval = 10; }
            else { tmrMoveBall.Interval = 5; }

            // bricks code

            brickRowColor = redBrush;
            for (int i = 1; i > 60; i++)
            {
                brickExists[i] = true;
                bricks[i] = new System.Drawing.Rectangle(
                    Convert.ToInt32(brickRowCount * 60),
                    Convert.ToInt32(50 + (brickColumnCount * 25)),
                    60,
                    25);
                // e.Graphics.FillRectangle(brickRowColor, bricks[1]);
                picBricks[i] = new PictureBox();
                picBricks[i].Left = bricks[i].Left;
                picBricks[i].Top = bricks[i].Top;
                picBricks[i].Width = 60;
                picBricks[i].Height = 25;
                picBricks[i].BackColor = brickRowColor;
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

            // paddle code

            if (level == 0) { paddleWidth = 150; }
            else if (level == 1) { paddleWidth = 100; }
            else { paddleWidth = 50; }
            paddle = new System.Drawing.Rectangle(
                (300 - (paddleWidth / 2)),
                435,
                paddleWidth,
                10);
            picPaddle = new PictureBox();
            picPaddle.Left = 300 - (paddleWidth / 2);
            picPaddle.Top = 435;
            picPaddle.Width = paddleWidth;
            picPaddle.Height = 10;

            // walls code

            leftWall = new System.Drawing.Rectangle(
                -10,
                0,
                10,
                450);
            rightWall = new System.Drawing.Rectangle(
                600,
                0,
                10,
                450);
            topWall = new System.Drawing.Rectangle(
                0,
                0,
                600,
                30);
            bottomWall = new System.Drawing.Rectangle(
                0,
                450,
                600,
                10);

            // picWorkingArea code

            picWorkingArea.Image = atariBreakout.Properties.Resources.blackout;
            picWorkingArea.SendToBack();
            lblLivesRemaining.Visible = true;
            lblScore.Visible = true;

        }

        public void BuildPauseScreen()
        {
            tmrMoveBall.Stop();
            tmrMovePaddle.Stop();
        }

        public void GameOver() // ends game; shows leaderboard
        {

        }

        public void ActivatePauseScreen() // pauses the game; needs to be finished 
        {
            currentScreen = 3;
            picWorkingArea.BringToFront();
        }

        public void ExitProgram() // closes the window 
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void Form1_Load(object sender, EventArgs e) // runs everything in order; send this to end when finished 
        {
            
        }


        /////////////////////////  Timers and Events /////////////////////////

        private void tmrAnyKey_Tick(object sender, EventArgs e) // detects if any key is pressed 
        {
            if (IsAnyKeyDown())
            {
                // title screen
                if (currentScreen == 0)
                {
                    BuildDifSelectScreen();
                    tmrAnyKey.Stop();
                }
            }
        }

        private void tmrDetectMouse_Tick(object sender, EventArgs e) // 
        {
            mouseX = MousePosition.X; mouseY = MousePosition.Y;
            if (currentScreen == 2)
            {
                paddle.X = Convert.ToInt32((mouseX) - (0.5 * paddle.Width));
                if(paddle.X < 10) { paddle.X = 10; } if (paddle.X > (590 - paddleWidth)) { paddle.X = (590 - paddleWidth); }
            }
        }

        private void tmrDownKey_Tick(object sender, EventArgs e) // detects if the down key is pressed 
        {
            if (Keyboard.IsKeyDown(Key.Down))
            {
                
            }
        }

        private void tmrMoveBall_Tick(object sender, EventArgs e) // moves the ball 
        {
            MovePingBall();
            SearchIntersections();

        }

        private void tmrLeftKey_Tick(object sender, EventArgs e)
        {
            if (currentScreen == 2 && Keyboard.IsKeyDown(Key.Right))
            {
                paddle.X -= 1;
                if (paddle.X < 10) { paddle.X = 10; } if (paddle.X > (590 - paddleWidth)) { paddle.X = (590 - paddleWidth); }
            }
        }

        private void tmrRightKey_Tick(object sender, EventArgs e)
        {
            if (currentScreen == 2 && Keyboard.IsKeyDown(Key.Right))
            {
                paddle.X += 1;
                if (paddle.X < 10) { paddle.X = 10; } if (paddle.X > (590 - paddleWidth)) { paddle.X = (590 - paddleWidth); }
            }
        }

        private void tmrUpKey_Tick(object sender, EventArgs e) // detects if the up key is pressed 
        {
            if (Keyboard.IsKeyDown(Key.Up))
            {
                
            }
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (currentScreen == 0)
            {
                BuildDifSelectScreen();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (currentScreen == 1)
                {
                    PlayTheGame(difficultyLevel);
                }
            }
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.P)
            {
                ActivatePauseScreen();
            }
            if (e.KeyCode == Keys.Down)
            {
                if (currentScreen == 1)
                {
                    difficultyLevel++;
                    if (difficultyLevel > 2) { difficultyLevel = 0; }
                    if (difficultyLevel == 0) { picWorkingArea.Image = Properties.Resources.n00bDifficulty; }
                    if (difficultyLevel == 1) { picWorkingArea.Image = Properties.Resources.normieDifficulty; }
                    if (difficultyLevel == 2) { picWorkingArea.Image = Properties.Resources.vetDifficulty; }
                    
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (currentScreen == 1)
                {
                    difficultyLevel--;
                    if (difficultyLevel < 0) { difficultyLevel = 2; }
                    if (difficultyLevel == 0) { picWorkingArea.Image = Properties.Resources.n00bDifficulty; }
                    if (difficultyLevel == 1) { picWorkingArea.Image = Properties.Resources.normieDifficulty; }
                    if (difficultyLevel == 2) { picWorkingArea.Image = Properties.Resources.vetDifficulty; }
                }
            }
        }

        private void picWorkingArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (currentScreen == 0)
            {
                BuildDifSelectScreen();
            }
        }

        private void tmrRespawn_Tick(object sender, EventArgs e)
        {
            if (instantTick)
            {
                instantTick = false;
            }
            else
            {
                LaunchBall();
                if (paddleMode == 0)
                {
                    tmrRightKey.Start();
                    tmrLeftKey.Start();
                }
                else
                {
                    tmrDetectMouse.Start();
                }
                tmrRespawn.Stop();
            }
        }

        private void tmrMovePaddle_Tick(object sender, EventArgs e)
        {

        }
    }
}

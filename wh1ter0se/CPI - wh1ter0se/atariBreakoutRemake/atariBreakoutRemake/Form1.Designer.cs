namespace atariBreakoutRemake
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.tmrSpawnDelay = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveBall = new System.Windows.Forms.Timer(this.components);
            this.tmrMovePaddle = new System.Windows.Forms.Timer(this.components);
            this.picOverlay = new System.Windows.Forms.PictureBox();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(12, 448);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(285, 23);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "SCORE: 0";
            // 
            // lblLives
            // 
            this.lblLives.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(303, 448);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(285, 23);
            this.lblLives.TabIndex = 3;
            this.lblLives.Text = "LIVES: 3";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tmrSpawnDelay
            // 
            this.tmrSpawnDelay.Interval = 1500;
            this.tmrSpawnDelay.Tick += new System.EventHandler(this.tmrSpawnDelay_Tick);
            // 
            // tmrMoveBall
            // 
            this.tmrMoveBall.Interval = 3;
            this.tmrMoveBall.Tick += new System.EventHandler(this.tmrMoveBall_Tick);
            // 
            // tmrMovePaddle
            // 
            this.tmrMovePaddle.Interval = 1;
            this.tmrMovePaddle.Tick += new System.EventHandler(this.tmrMovePaddle_Tick);
            // 
            // picOverlay
            // 
            this.picOverlay.Image = global::atariBreakoutRemake.Properties.Resources.titleScreen;
            this.picOverlay.Location = new System.Drawing.Point(0, 0);
            this.picOverlay.Name = "picOverlay";
            this.picOverlay.Size = new System.Drawing.Size(600, 450);
            this.picOverlay.TabIndex = 4;
            this.picOverlay.TabStop = false;
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.White;
            this.picPaddle.Location = new System.Drawing.Point(250, 420);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(100, 15);
            this.picPaddle.TabIndex = 0;
            this.picPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(290, 399);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.picOverlay);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atari Breakout";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer tmrSpawnDelay;
        private System.Windows.Forms.Timer tmrMoveBall;
        private System.Windows.Forms.Timer tmrMovePaddle;
        private System.Windows.Forms.PictureBox picOverlay;
    }
}


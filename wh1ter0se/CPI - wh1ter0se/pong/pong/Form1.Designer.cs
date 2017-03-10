namespace pong
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
            this.lblTopScore = new System.Windows.Forms.Label();
            this.lblBottomScore = new System.Windows.Forms.Label();
            this.tmrMoveBall = new System.Windows.Forms.Timer(this.components);
            this.tmrMovePaddle = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnDelay = new System.Windows.Forms.Timer(this.components);
            this.picModeSelect = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picTopPaddle = new System.Windows.Forms.PictureBox();
            this.picBottomPaddle = new System.Windows.Forms.PictureBox();
            this.picRightWall = new System.Windows.Forms.PictureBox();
            this.picLeftWall = new System.Windows.Forms.PictureBox();
            this.picTopWall = new System.Windows.Forms.PictureBox();
            this.picBottomWall = new System.Windows.Forms.PictureBox();
            this.picSpecial = new System.Windows.Forms.PictureBox();
            this.tmrSpecial = new System.Windows.Forms.Timer(this.components);
            this.tmrActivatedSpecial = new System.Windows.Forms.Timer(this.components);
            this.tmrProgressiveSpeed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picModeSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopScore
            // 
            this.lblTopScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScore.ForeColor = System.Drawing.Color.White;
            this.lblTopScore.Location = new System.Drawing.Point(450, 0);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(50, 300);
            this.lblTopScore.TabIndex = 7;
            this.lblTopScore.Text = "0";
            this.lblTopScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomScore
            // 
            this.lblBottomScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomScore.ForeColor = System.Drawing.Color.White;
            this.lblBottomScore.Location = new System.Drawing.Point(450, 300);
            this.lblBottomScore.Name = "lblBottomScore";
            this.lblBottomScore.Size = new System.Drawing.Size(50, 300);
            this.lblBottomScore.TabIndex = 8;
            this.lblBottomScore.Text = "0";
            this.lblBottomScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMoveBall
            // 
            this.tmrMoveBall.Interval = 14;
            this.tmrMoveBall.Tick += new System.EventHandler(this.tmrMoveBall_Tick);
            // 
            // tmrMovePaddle
            // 
            this.tmrMovePaddle.Interval = 1;
            this.tmrMovePaddle.Tick += new System.EventHandler(this.tmrMovePaddle_Tick);
            // 
            // tmrSpawnDelay
            // 
            this.tmrSpawnDelay.Interval = 1500;
            this.tmrSpawnDelay.Tick += new System.EventHandler(this.tmrSpawnDelay_Tick);
            // 
            // picModeSelect
            // 
            this.picModeSelect.Image = global::pong.Properties.Resources.pongMultiplayer;
            this.picModeSelect.Location = new System.Drawing.Point(0, 0);
            this.picModeSelect.Name = "picModeSelect";
            this.picModeSelect.Size = new System.Drawing.Size(450, 600);
            this.picModeSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picModeSelect.TabIndex = 9;
            this.picModeSelect.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(215, 290);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 6;
            this.picBall.TabStop = false;
            // 
            // picTopPaddle
            // 
            this.picTopPaddle.BackColor = System.Drawing.Color.White;
            this.picTopPaddle.Location = new System.Drawing.Point(175, 10);
            this.picTopPaddle.Name = "picTopPaddle";
            this.picTopPaddle.Size = new System.Drawing.Size(100, 15);
            this.picTopPaddle.TabIndex = 5;
            this.picTopPaddle.TabStop = false;
            // 
            // picBottomPaddle
            // 
            this.picBottomPaddle.BackColor = System.Drawing.Color.White;
            this.picBottomPaddle.Location = new System.Drawing.Point(175, 575);
            this.picBottomPaddle.Name = "picBottomPaddle";
            this.picBottomPaddle.Size = new System.Drawing.Size(100, 15);
            this.picBottomPaddle.TabIndex = 4;
            this.picBottomPaddle.TabStop = false;
            // 
            // picRightWall
            // 
            this.picRightWall.Location = new System.Drawing.Point(449, 0);
            this.picRightWall.Name = "picRightWall";
            this.picRightWall.Size = new System.Drawing.Size(20, 600);
            this.picRightWall.TabIndex = 3;
            this.picRightWall.TabStop = false;
            // 
            // picLeftWall
            // 
            this.picLeftWall.Location = new System.Drawing.Point(-19, 0);
            this.picLeftWall.Name = "picLeftWall";
            this.picLeftWall.Size = new System.Drawing.Size(20, 600);
            this.picLeftWall.TabIndex = 2;
            this.picLeftWall.TabStop = false;
            // 
            // picTopWall
            // 
            this.picTopWall.Location = new System.Drawing.Point(0, -19);
            this.picTopWall.Name = "picTopWall";
            this.picTopWall.Size = new System.Drawing.Size(450, 20);
            this.picTopWall.TabIndex = 1;
            this.picTopWall.TabStop = false;
            // 
            // picBottomWall
            // 
            this.picBottomWall.Location = new System.Drawing.Point(0, 599);
            this.picBottomWall.Name = "picBottomWall";
            this.picBottomWall.Size = new System.Drawing.Size(450, 20);
            this.picBottomWall.TabIndex = 0;
            this.picBottomWall.TabStop = false;
            // 
            // picSpecial
            // 
            this.picSpecial.BackColor = System.Drawing.Color.White;
            this.picSpecial.Location = new System.Drawing.Point(215, 290);
            this.picSpecial.Name = "picSpecial";
            this.picSpecial.Size = new System.Drawing.Size(20, 20);
            this.picSpecial.TabIndex = 10;
            this.picSpecial.TabStop = false;
            this.picSpecial.Visible = false;
            // 
            // tmrSpecial
            // 
            this.tmrSpecial.Interval = 5000;
            this.tmrSpecial.Tick += new System.EventHandler(this.tmrSpecial_Tick);
            // 
            // tmrActivatedSpecial
            // 
            this.tmrActivatedSpecial.Interval = 10000;
            this.tmrActivatedSpecial.Tick += new System.EventHandler(this.tmrActivatedSpecial_Tick);
            // 
            // tmrProgressiveSpeed
            // 
            this.tmrProgressiveSpeed.Interval = 2500;
            this.tmrProgressiveSpeed.Tick += new System.EventHandler(this.tmrProgressiveSpeed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.picModeSelect);
            this.Controls.Add(this.picSpecial);
            this.Controls.Add(this.lblBottomScore);
            this.Controls.Add(this.lblTopScore);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picTopPaddle);
            this.Controls.Add(this.picBottomPaddle);
            this.Controls.Add(this.picRightWall);
            this.Controls.Add(this.picLeftWall);
            this.Controls.Add(this.picTopWall);
            this.Controls.Add(this.picBottomWall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picModeSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBottomWall;
        private System.Windows.Forms.PictureBox picTopWall;
        private System.Windows.Forms.PictureBox picLeftWall;
        private System.Windows.Forms.PictureBox picRightWall;
        private System.Windows.Forms.PictureBox picBottomPaddle;
        private System.Windows.Forms.PictureBox picTopPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label lblBottomScore;
        private System.Windows.Forms.Timer tmrMoveBall;
        private System.Windows.Forms.Timer tmrMovePaddle;
        private System.Windows.Forms.Timer tmrSpawnDelay;
        private System.Windows.Forms.PictureBox picModeSelect;
        private System.Windows.Forms.PictureBox picSpecial;
        private System.Windows.Forms.Timer tmrSpecial;
        private System.Windows.Forms.Timer tmrActivatedSpecial;
        private System.Windows.Forms.Timer tmrProgressiveSpeed;
    }
}


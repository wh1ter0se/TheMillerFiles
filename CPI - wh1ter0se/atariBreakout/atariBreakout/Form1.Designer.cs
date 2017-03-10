namespace atariBreakout
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
            this.tmrAnyKey = new System.Windows.Forms.Timer(this.components);
            this.tmrDownKey = new System.Windows.Forms.Timer(this.components);
            this.tmrUpKey = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveBall = new System.Windows.Forms.Timer(this.components);
            this.tmrDetectMouse = new System.Windows.Forms.Timer(this.components);
            this.tmrLeftKey = new System.Windows.Forms.Timer(this.components);
            this.tmrRightKey = new System.Windows.Forms.Timer(this.components);
            this.lblLivesRemaining = new System.Windows.Forms.Label();
            this.picWorkingArea = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrRespawn = new System.Windows.Forms.Timer(this.components);
            this.tmrMovePaddle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAnyKey
            // 
            this.tmrAnyKey.Interval = 1;
            this.tmrAnyKey.Tick += new System.EventHandler(this.tmrAnyKey_Tick);
            // 
            // tmrDownKey
            // 
            this.tmrDownKey.Interval = 1;
            this.tmrDownKey.Tick += new System.EventHandler(this.tmrDownKey_Tick);
            // 
            // tmrUpKey
            // 
            this.tmrUpKey.Interval = 1;
            this.tmrUpKey.Tick += new System.EventHandler(this.tmrUpKey_Tick);
            // 
            // tmrMoveBall
            // 
            this.tmrMoveBall.Interval = 10;
            this.tmrMoveBall.Tick += new System.EventHandler(this.tmrMoveBall_Tick);
            // 
            // tmrDetectMouse
            // 
            this.tmrDetectMouse.Interval = 1;
            this.tmrDetectMouse.Tick += new System.EventHandler(this.tmrDetectMouse_Tick);
            // 
            // tmrLeftKey
            // 
            this.tmrLeftKey.Interval = 2;
            this.tmrLeftKey.Tick += new System.EventHandler(this.tmrLeftKey_Tick);
            // 
            // tmrRightKey
            // 
            this.tmrRightKey.Interval = 2;
            this.tmrRightKey.Tick += new System.EventHandler(this.tmrRightKey_Tick);
            // 
            // lblLivesRemaining
            // 
            this.lblLivesRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesRemaining.ForeColor = System.Drawing.Color.White;
            this.lblLivesRemaining.Location = new System.Drawing.Point(350, 0);
            this.lblLivesRemaining.Name = "lblLivesRemaining";
            this.lblLivesRemaining.Size = new System.Drawing.Size(200, 30);
            this.lblLivesRemaining.TabIndex = 3;
            this.lblLivesRemaining.Text = "LIVES: 3";
            this.lblLivesRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLivesRemaining.Visible = false;
            // 
            // picWorkingArea
            // 
            this.picWorkingArea.Image = global::atariBreakout.Properties.Resources.blackout;
            this.picWorkingArea.Location = new System.Drawing.Point(0, 0);
            this.picWorkingArea.Name = "picWorkingArea";
            this.picWorkingArea.Size = new System.Drawing.Size(600, 450);
            this.picWorkingArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWorkingArea.TabIndex = 1;
            this.picWorkingArea.TabStop = false;
            this.picWorkingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picWorkingArea_MouseDown);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(50, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(200, 30);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "SCORE: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblScore.Visible = false;
            // 
            // tmrRespawn
            // 
            this.tmrRespawn.Interval = 1500;
            this.tmrRespawn.Tick += new System.EventHandler(this.tmrRespawn_Tick);
            // 
            // tmrMovePaddle
            // 
            this.tmrMovePaddle.Interval = 1;
            this.tmrMovePaddle.Tick += new System.EventHandler(this.tmrMovePaddle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLivesRemaining);
            this.Controls.Add(this.picWorkingArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picWorkingArea;
        private System.Windows.Forms.Timer tmrAnyKey;
        private System.Windows.Forms.Timer tmrDownKey;
        private System.Windows.Forms.Timer tmrUpKey;
        private System.Windows.Forms.Timer tmrMoveBall;
        private System.Windows.Forms.Timer tmrDetectMouse;
        private System.Windows.Forms.Timer tmrLeftKey;
        private System.Windows.Forms.Timer tmrRightKey;
        private System.Windows.Forms.Label lblLivesRemaining;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrRespawn;
        private System.Windows.Forms.Timer tmrMovePaddle;
    }
}


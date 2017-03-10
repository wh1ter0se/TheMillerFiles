namespace NameThatQuote
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
            this.lblQuote = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pgsTriesLeft = new System.Windows.Forms.ProgressBar();
            this.lblAttemptsLeft = new System.Windows.Forms.Label();
            this.tmrYouWrong = new System.Windows.Forms.Timer(this.components);
            this.lblPoints = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblNameForgotten = new System.Windows.Forms.Label();
            this.tmrYouRight = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuote
            // 
            this.lblQuote.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuote.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(12, 9);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(616, 278);
            this.lblQuote.TabIndex = 0;
            this.lblQuote.Text = "Quote Will Appear Here";
            this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuote.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(19, 333);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(304, 68);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Start Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.AcceptsReturn = true;
            this.txtEntry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntry.Location = new System.Drawing.Point(19, 290);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(609, 37);
            this.txtEntry.TabIndex = 2;
            this.txtEntry.Text = "Who said it first?";
            this.txtEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntry_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(329, 334);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(299, 67);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pgsTriesLeft
            // 
            this.pgsTriesLeft.Location = new System.Drawing.Point(19, 446);
            this.pgsTriesLeft.Maximum = 3;
            this.pgsTriesLeft.Name = "pgsTriesLeft";
            this.pgsTriesLeft.Size = new System.Drawing.Size(609, 23);
            this.pgsTriesLeft.TabIndex = 4;
            this.pgsTriesLeft.Value = 3;
            // 
            // lblAttemptsLeft
            // 
            this.lblAttemptsLeft.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttemptsLeft.Location = new System.Drawing.Point(213, 404);
            this.lblAttemptsLeft.Name = "lblAttemptsLeft";
            this.lblAttemptsLeft.Size = new System.Drawing.Size(236, 23);
            this.lblAttemptsLeft.TabIndex = 5;
            this.lblAttemptsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrYouWrong
            // 
            this.tmrYouWrong.Interval = 1000;
            this.tmrYouWrong.Tick += new System.EventHandler(this.tmrYouWrong_Tick);
            // 
            // lblPoints
            // 
            this.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPoints.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(634, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(189, 168);
            this.lblPoints.TabIndex = 6;
            this.lblPoints.Text = "Points";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(634, 290);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(189, 208);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            this.picBox.Visible = false;
            // 
            // lblNameForgotten
            // 
            this.lblNameForgotten.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForgotten.Location = new System.Drawing.Point(634, 218);
            this.lblNameForgotten.Name = "lblNameForgotten";
            this.lblNameForgotten.Size = new System.Drawing.Size(189, 69);
            this.lblNameForgotten.TabIndex = 8;
            this.lblNameForgotten.Text = "You forgot my name?!";
            this.lblNameForgotten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameForgotten.Visible = false;
            // 
            // tmrYouRight
            // 
            this.tmrYouRight.Interval = 1000;
            this.tmrYouRight.Tick += new System.EventHandler(this.tmrYouRight_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 481);
            this.Controls.Add(this.lblNameForgotten);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblAttemptsLeft);
            this.Controls.Add(this.pgsTriesLeft);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblQuote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar pgsTriesLeft;
        private System.Windows.Forms.Label lblAttemptsLeft;
        private System.Windows.Forms.Timer tmrYouWrong;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblNameForgotten;
        private System.Windows.Forms.Timer tmrYouRight;
    }
}


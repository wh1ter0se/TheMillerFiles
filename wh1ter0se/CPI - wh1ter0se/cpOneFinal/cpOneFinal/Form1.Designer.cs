namespace cpOneFinal
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
            this.lblCount = new System.Windows.Forms.Label();
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblThirdNumber = new System.Windows.Forms.Label();
            this.lblFourthNumber = new System.Windows.Forms.Label();
            this.lblFifthNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrPizzazNumbers = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Crimson;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(12, 338);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(276, 53);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "COUNT: NULL";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCount.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 10000;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.BackColor = System.Drawing.Color.Crimson;
            this.lblFirstNumber.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.Location = new System.Drawing.Point(12, 10);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(60, 50);
            this.lblFirstNumber.TabIndex = 1;
            this.lblFirstNumber.Text = "0";
            this.lblFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFirstNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.BackColor = System.Drawing.Color.Crimson;
            this.lblSecondNumber.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.Location = new System.Drawing.Point(12, 70);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(60, 50);
            this.lblSecondNumber.TabIndex = 2;
            this.lblSecondNumber.Text = "0";
            this.lblSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecondNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblThirdNumber
            // 
            this.lblThirdNumber.BackColor = System.Drawing.Color.Crimson;
            this.lblThirdNumber.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdNumber.Location = new System.Drawing.Point(12, 130);
            this.lblThirdNumber.Name = "lblThirdNumber";
            this.lblThirdNumber.Size = new System.Drawing.Size(60, 50);
            this.lblThirdNumber.TabIndex = 3;
            this.lblThirdNumber.Text = "0";
            this.lblThirdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThirdNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblFourthNumber
            // 
            this.lblFourthNumber.BackColor = System.Drawing.Color.Crimson;
            this.lblFourthNumber.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthNumber.Location = new System.Drawing.Point(12, 190);
            this.lblFourthNumber.Name = "lblFourthNumber";
            this.lblFourthNumber.Size = new System.Drawing.Size(60, 50);
            this.lblFourthNumber.TabIndex = 4;
            this.lblFourthNumber.Text = "0";
            this.lblFourthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFourthNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblFifthNumber
            // 
            this.lblFifthNumber.BackColor = System.Drawing.Color.Crimson;
            this.lblFifthNumber.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifthNumber.Location = new System.Drawing.Point(12, 250);
            this.lblFifthNumber.Name = "lblFifthNumber";
            this.lblFifthNumber.Size = new System.Drawing.Size(60, 50);
            this.lblFifthNumber.TabIndex = 5;
            this.lblFifthNumber.Text = "0";
            this.lblFifthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFifthNumber.Click += new System.EventHandler(this.lblFirstNumber_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(91, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 59);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Random Number Generator";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(188, 130);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 7;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(188, 160);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 8;
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(96, 127);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(86, 23);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "Minimum:";
            // 
            // lblMax
            // 
            this.lblMax.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(92, 160);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(86, 23);
            this.lblMax.TabIndex = 10;
            this.lblMax.Text = "Maximum:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(96, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(188, 234);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(142, 263);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tmrPizzazNumbers
            // 
            this.tmrPizzazNumbers.Tick += new System.EventHandler(this.tmrPizzazNumbers_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFifthNumber);
            this.Controls.Add(this.lblFourthNumber);
            this.Controls.Add(this.lblThirdNumber);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.lblCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblThirdNumber;
        private System.Windows.Forms.Label lblFourthNumber;
        private System.Windows.Forms.Label lblFifthNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer tmrPizzazNumbers;
    }
}


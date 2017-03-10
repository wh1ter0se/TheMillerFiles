namespace Variables
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
            this.txtFirstYear = new System.Windows.Forms.TextBox();
            this.txtSecondYear = new System.Windows.Forms.TextBox();
            this.lblFirstYear = new System.Windows.Forms.Label();
            this.lblSecondYear = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.picFreg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFreg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstYear
            // 
            this.txtFirstYear.Location = new System.Drawing.Point(12, 47);
            this.txtFirstYear.Name = "txtFirstYear";
            this.txtFirstYear.Size = new System.Drawing.Size(88, 20);
            this.txtFirstYear.TabIndex = 0;
            this.txtFirstYear.TextChanged += new System.EventHandler(this.txtFirstYear_TextChanged);
            this.txtFirstYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstYear_KeyDown);
            // 
            // txtSecondYear
            // 
            this.txtSecondYear.Location = new System.Drawing.Point(12, 111);
            this.txtSecondYear.Name = "txtSecondYear";
            this.txtSecondYear.Size = new System.Drawing.Size(88, 20);
            this.txtSecondYear.TabIndex = 1;
            this.txtSecondYear.TextChanged += new System.EventHandler(this.txtSecondYear_TextChanged);
            this.txtSecondYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecondYear_KeyDown);
            // 
            // lblFirstYear
            // 
            this.lblFirstYear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstYear.ForeColor = System.Drawing.Color.White;
            this.lblFirstYear.Location = new System.Drawing.Point(12, 21);
            this.lblFirstYear.Name = "lblFirstYear";
            this.lblFirstYear.Size = new System.Drawing.Size(88, 23);
            this.lblFirstYear.TabIndex = 2;
            this.lblFirstYear.Text = "First Year";
            this.lblFirstYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondYear
            // 
            this.lblSecondYear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondYear.ForeColor = System.Drawing.Color.White;
            this.lblSecondYear.Location = new System.Drawing.Point(12, 85);
            this.lblSecondYear.Name = "lblSecondYear";
            this.lblSecondYear.Size = new System.Drawing.Size(88, 23);
            this.lblSecondYear.TabIndex = 3;
            this.lblSecondYear.Text = "Second Year";
            this.lblSecondYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Black;
            this.lblOutput.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(106, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(193, 164);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Please Enter 2 Numbers";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Check it";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // picFreg
            // 
            this.picFreg.Image = global::Variables.Properties.Resources.freg;
            this.picFreg.Location = new System.Drawing.Point(305, -5);
            this.picFreg.Name = "picFreg";
            this.picFreg.Size = new System.Drawing.Size(256, 197);
            this.picFreg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFreg.TabIndex = 6;
            this.picFreg.TabStop = false;
            this.picFreg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(560, 179);
            this.Controls.Add(this.picFreg);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblSecondYear);
            this.Controls.Add(this.lblFirstYear);
            this.Controls.Add(this.txtSecondYear);
            this.Controls.Add(this.txtFirstYear);
            this.Name = "Form1";
            this.Text = "leap years, my dude";
            ((System.ComponentModel.ISupportInitialize)(this.picFreg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstYear;
        private System.Windows.Forms.TextBox txtSecondYear;
        private System.Windows.Forms.Label lblFirstYear;
        private System.Windows.Forms.Label lblSecondYear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picFreg;
    }
}


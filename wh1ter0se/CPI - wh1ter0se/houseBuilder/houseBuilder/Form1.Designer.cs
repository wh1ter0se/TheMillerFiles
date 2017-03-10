namespace houseBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFirstHouse = new System.Windows.Forms.Button();
            this.btnSecondHouse = new System.Windows.Forms.Button();
            this.btnThirdHouse = new System.Windows.Forms.Button();
            this.btnFourthHouse = new System.Windows.Forms.Button();
            this.txtBaths = new System.Windows.Forms.TextBox();
            this.txtBeds = new System.Windows.Forms.TextBox();
            this.picFirstHouse = new System.Windows.Forms.PictureBox();
            this.picSecondHouse = new System.Windows.Forms.PictureBox();
            this.picThirdHouse = new System.Windows.Forms.PictureBox();
            this.picFourthHouse = new System.Windows.Forms.PictureBox();
            this.lblBeds = new System.Windows.Forms.Label();
            this.lblBaths = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourthHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirstHouse
            // 
            this.btnFirstHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstHouse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstHouse.Location = new System.Drawing.Point(161, 112);
            this.btnFirstHouse.Name = "btnFirstHouse";
            this.btnFirstHouse.Size = new System.Drawing.Size(120, 23);
            this.btnFirstHouse.TabIndex = 0;
            this.btnFirstHouse.Text = "Build House";
            this.btnFirstHouse.UseVisualStyleBackColor = true;
            this.btnFirstHouse.Click += new System.EventHandler(this.btnFirstHouse_Click);
            // 
            // btnSecondHouse
            // 
            this.btnSecondHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondHouse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondHouse.Location = new System.Drawing.Point(371, 128);
            this.btnSecondHouse.Name = "btnSecondHouse";
            this.btnSecondHouse.Size = new System.Drawing.Size(120, 23);
            this.btnSecondHouse.TabIndex = 1;
            this.btnSecondHouse.Text = "Build House";
            this.btnSecondHouse.UseVisualStyleBackColor = true;
            this.btnSecondHouse.Click += new System.EventHandler(this.btnSecondHouse_Click);
            // 
            // btnThirdHouse
            // 
            this.btnThirdHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThirdHouse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdHouse.Location = new System.Drawing.Point(161, 327);
            this.btnThirdHouse.Name = "btnThirdHouse";
            this.btnThirdHouse.Size = new System.Drawing.Size(120, 23);
            this.btnThirdHouse.TabIndex = 2;
            this.btnThirdHouse.Text = "Build House";
            this.btnThirdHouse.UseVisualStyleBackColor = true;
            this.btnThirdHouse.Click += new System.EventHandler(this.btnThirdHouse_Click);
            // 
            // btnFourthHouse
            // 
            this.btnFourthHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourthHouse.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFourthHouse.Location = new System.Drawing.Point(371, 315);
            this.btnFourthHouse.Name = "btnFourthHouse";
            this.btnFourthHouse.Size = new System.Drawing.Size(120, 23);
            this.btnFourthHouse.TabIndex = 3;
            this.btnFourthHouse.Text = "Build House";
            this.btnFourthHouse.UseVisualStyleBackColor = true;
            this.btnFourthHouse.Click += new System.EventHandler(this.btnFourthHouse_Click);
            // 
            // txtBaths
            // 
            this.txtBaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaths.Location = new System.Drawing.Point(72, 75);
            this.txtBaths.Name = "txtBaths";
            this.txtBaths.Size = new System.Drawing.Size(72, 20);
            this.txtBaths.TabIndex = 4;
            this.txtBaths.Visible = false;
            this.txtBaths.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaths_KeyPress);
            // 
            // txtBeds
            // 
            this.txtBeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBeds.Enabled = false;
            this.txtBeds.Location = new System.Drawing.Point(72, 29);
            this.txtBeds.Name = "txtBeds";
            this.txtBeds.Size = new System.Drawing.Size(72, 20);
            this.txtBeds.TabIndex = 5;
            this.txtBeds.Visible = false;
            this.txtBeds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeds_KeyPress);
            // 
            // picFirstHouse
            // 
            this.picFirstHouse.Enabled = false;
            this.picFirstHouse.Location = new System.Drawing.Point(161, 0);
            this.picFirstHouse.Name = "picFirstHouse";
            this.picFirstHouse.Size = new System.Drawing.Size(120, 120);
            this.picFirstHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirstHouse.TabIndex = 6;
            this.picFirstHouse.TabStop = false;
            this.picFirstHouse.Visible = false;
            this.picFirstHouse.Click += new System.EventHandler(this.picFirstHouse_Click);
            // 
            // picSecondHouse
            // 
            this.picSecondHouse.Enabled = false;
            this.picSecondHouse.Location = new System.Drawing.Point(371, 12);
            this.picSecondHouse.Name = "picSecondHouse";
            this.picSecondHouse.Size = new System.Drawing.Size(120, 120);
            this.picSecondHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecondHouse.TabIndex = 7;
            this.picSecondHouse.TabStop = false;
            this.picSecondHouse.Visible = false;
            this.picSecondHouse.Click += new System.EventHandler(this.picSecondHouse_Click);
            // 
            // picThirdHouse
            // 
            this.picThirdHouse.Enabled = false;
            this.picThirdHouse.Location = new System.Drawing.Point(161, 216);
            this.picThirdHouse.Name = "picThirdHouse";
            this.picThirdHouse.Size = new System.Drawing.Size(120, 120);
            this.picThirdHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThirdHouse.TabIndex = 8;
            this.picThirdHouse.TabStop = false;
            this.picThirdHouse.Visible = false;
            this.picThirdHouse.Click += new System.EventHandler(this.picThirdHouse_Click);
            // 
            // picFourthHouse
            // 
            this.picFourthHouse.Enabled = false;
            this.picFourthHouse.Location = new System.Drawing.Point(371, 196);
            this.picFourthHouse.Name = "picFourthHouse";
            this.picFourthHouse.Size = new System.Drawing.Size(120, 120);
            this.picFourthHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFourthHouse.TabIndex = 9;
            this.picFourthHouse.TabStop = false;
            this.picFourthHouse.Visible = false;
            this.picFourthHouse.Click += new System.EventHandler(this.picFourthHouse_Click);
            // 
            // lblBeds
            // 
            this.lblBeds.BackColor = System.Drawing.Color.Transparent;
            this.lblBeds.Enabled = false;
            this.lblBeds.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeds.Location = new System.Drawing.Point(13, 6);
            this.lblBeds.Name = "lblBeds";
            this.lblBeds.Size = new System.Drawing.Size(100, 23);
            this.lblBeds.TabIndex = 10;
            this.lblBeds.Text = "Bedrooms:";
            this.lblBeds.Visible = false;
            // 
            // lblBaths
            // 
            this.lblBaths.BackColor = System.Drawing.Color.Transparent;
            this.lblBaths.Enabled = false;
            this.lblBaths.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaths.Location = new System.Drawing.Point(13, 51);
            this.lblBaths.Name = "lblBaths";
            this.lblBaths.Size = new System.Drawing.Size(100, 23);
            this.lblBaths.TabIndex = 11;
            this.lblBaths.Text = "Bathrooms:";
            this.lblBaths.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(17, 101);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 31);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(0, 327);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(54, 23);
            this.lblExit.TabIndex = 13;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::houseBuilder.Properties.Resources.cloverfieldLane;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblBaths);
            this.Controls.Add(this.lblBeds);
            this.Controls.Add(this.btnThirdHouse);
            this.Controls.Add(this.btnSecondHouse);
            this.Controls.Add(this.btnFirstHouse);
            this.Controls.Add(this.picFourthHouse);
            this.Controls.Add(this.picThirdHouse);
            this.Controls.Add(this.picSecondHouse);
            this.Controls.Add(this.picFirstHouse);
            this.Controls.Add(this.txtBeds);
            this.Controls.Add(this.txtBaths);
            this.Controls.Add(this.btnFourthHouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "House Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFirstHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourthHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstHouse;
        private System.Windows.Forms.Button btnSecondHouse;
        private System.Windows.Forms.Button btnThirdHouse;
        private System.Windows.Forms.Button btnFourthHouse;
        private System.Windows.Forms.TextBox txtBaths;
        private System.Windows.Forms.TextBox txtBeds;
        private System.Windows.Forms.PictureBox picFirstHouse;
        private System.Windows.Forms.PictureBox picSecondHouse;
        private System.Windows.Forms.PictureBox picThirdHouse;
        private System.Windows.Forms.PictureBox picFourthHouse;
        private System.Windows.Forms.Label lblBeds;
        private System.Windows.Forms.Label lblBaths;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblExit;
    }
}


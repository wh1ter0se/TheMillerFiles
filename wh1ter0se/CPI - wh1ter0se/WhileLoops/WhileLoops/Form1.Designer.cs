namespace WhileLoops
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.txtRowNumber = new System.Windows.Forms.TextBox();
            this.lblEnterRowNumber = new System.Windows.Forms.Label();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.BackgroundImage = global::WhileLoops.Properties.Resources.robbie;
            this.btnWhile.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhile.Location = new System.Drawing.Point(12, 57);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(260, 238);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // txtRowNumber
            // 
            this.txtRowNumber.Location = new System.Drawing.Point(12, 31);
            this.txtRowNumber.Name = "txtRowNumber";
            this.txtRowNumber.Size = new System.Drawing.Size(260, 20);
            this.txtRowNumber.TabIndex = 2;
            this.txtRowNumber.TextChanged += new System.EventHandler(this.btnWhile_Click);
            // 
            // lblEnterRowNumber
            // 
            this.lblEnterRowNumber.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterRowNumber.Location = new System.Drawing.Point(13, 12);
            this.lblEnterRowNumber.Name = "lblEnterRowNumber";
            this.lblEnterRowNumber.Size = new System.Drawing.Size(259, 16);
            this.lblEnterRowNumber.TabIndex = 3;
            this.lblEnterRowNumber.Text = "Enter row number";
            this.lblEnterRowNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk.Location = new System.Drawing.Point(279, 14);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(399, 470);
            this.lblAsterisk.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 493);
            this.Controls.Add(this.lblAsterisk);
            this.Controls.Add(this.lblEnterRowNumber);
            this.Controls.Add(this.txtRowNumber);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.TextBox txtRowNumber;
        private System.Windows.Forms.Label lblEnterRowNumber;
        private System.Windows.Forms.Label lblAsterisk;
    }
}


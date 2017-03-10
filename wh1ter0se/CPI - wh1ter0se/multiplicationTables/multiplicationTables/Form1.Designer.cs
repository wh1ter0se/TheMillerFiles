namespace multiplicationTables
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
            this.txtStartNumberInput = new System.Windows.Forms.TextBox();
            this.lstListOfEquations = new System.Windows.Forms.ListBox();
            this.txtEndNumberInput = new System.Windows.Forms.TextBox();
            this.txtMultiplierInput = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblStartNumberInput = new System.Windows.Forms.Label();
            this.lblEndNumberInput = new System.Windows.Forms.Label();
            this.lblMultiplierInput = new System.Windows.Forms.Label();
            this.btnSmashDatLykButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartNumberInput
            // 
            this.txtStartNumberInput.Location = new System.Drawing.Point(12, 63);
            this.txtStartNumberInput.Name = "txtStartNumberInput";
            this.txtStartNumberInput.Size = new System.Drawing.Size(100, 20);
            this.txtStartNumberInput.TabIndex = 0;
            // 
            // lstListOfEquations
            // 
            this.lstListOfEquations.FormattingEnabled = true;
            this.lstListOfEquations.Location = new System.Drawing.Point(485, 12);
            this.lstListOfEquations.Name = "lstListOfEquations";
            this.lstListOfEquations.Size = new System.Drawing.Size(120, 238);
            this.lstListOfEquations.TabIndex = 1;
            // 
            // txtEndNumberInput
            // 
            this.txtEndNumberInput.Location = new System.Drawing.Point(12, 109);
            this.txtEndNumberInput.Name = "txtEndNumberInput";
            this.txtEndNumberInput.Size = new System.Drawing.Size(100, 20);
            this.txtEndNumberInput.TabIndex = 2;
            // 
            // txtMultiplierInput
            // 
            this.txtMultiplierInput.Location = new System.Drawing.Point(12, 155);
            this.txtMultiplierInput.Name = "txtMultiplierInput";
            this.txtMultiplierInput.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplierInput.TabIndex = 3;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(404, 43);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 40);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(404, 89);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 40);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(404, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(404, 181);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 40);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblStartNumberInput
            // 
            this.lblStartNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartNumberInput.Location = new System.Drawing.Point(13, 32);
            this.lblStartNumberInput.Name = "lblStartNumberInput";
            this.lblStartNumberInput.Size = new System.Drawing.Size(99, 28);
            this.lblStartNumberInput.TabIndex = 8;
            this.lblStartNumberInput.Text = "Start Number";
            this.lblStartNumberInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndNumberInput
            // 
            this.lblEndNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndNumberInput.Location = new System.Drawing.Point(13, 78);
            this.lblEndNumberInput.Name = "lblEndNumberInput";
            this.lblEndNumberInput.Size = new System.Drawing.Size(99, 28);
            this.lblEndNumberInput.TabIndex = 9;
            this.lblEndNumberInput.Text = "End Number";
            this.lblEndNumberInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultiplierInput
            // 
            this.lblMultiplierInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplierInput.Location = new System.Drawing.Point(13, 124);
            this.lblMultiplierInput.Name = "lblMultiplierInput";
            this.lblMultiplierInput.Size = new System.Drawing.Size(99, 28);
            this.lblMultiplierInput.TabIndex = 10;
            this.lblMultiplierInput.Text = "Multipier";
            this.lblMultiplierInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSmashDatLykButton
            // 
            this.btnSmashDatLykButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmashDatLykButton.Location = new System.Drawing.Point(164, 43);
            this.btnSmashDatLykButton.Name = "btnSmashDatLykButton";
            this.btnSmashDatLykButton.Size = new System.Drawing.Size(203, 178);
            this.btnSmashDatLykButton.TabIndex = 11;
            this.btnSmashDatLykButton.Text = "SMASH DAT LYK BUTTON";
            this.btnSmashDatLykButton.UseVisualStyleBackColor = true;
            this.btnSmashDatLykButton.Click += new System.EventHandler(this.btnSmashDatLykButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 262);
            this.Controls.Add(this.btnSmashDatLykButton);
            this.Controls.Add(this.lblMultiplierInput);
            this.Controls.Add(this.lblEndNumberInput);
            this.Controls.Add(this.lblStartNumberInput);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.txtMultiplierInput);
            this.Controls.Add(this.txtEndNumberInput);
            this.Controls.Add(this.lstListOfEquations);
            this.Controls.Add(this.txtStartNumberInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartNumberInput;
        private System.Windows.Forms.ListBox lstListOfEquations;
        private System.Windows.Forms.TextBox txtEndNumberInput;
        private System.Windows.Forms.TextBox txtMultiplierInput;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblStartNumberInput;
        private System.Windows.Forms.Label lblEndNumberInput;
        private System.Windows.Forms.Label lblMultiplierInput;
        private System.Windows.Forms.Button btnSmashDatLykButton;
    }
}


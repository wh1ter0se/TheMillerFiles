using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoops
{
    public partial class Form1 : Form
    {
        int i = 1;
        int n = 1;
        int bottomCount = 0;
        string additiveTop = "\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int rowNumber;
            if (txtRowNumber.Text == "")
            {
                rowNumber = 0;
            }
            else if (Regex.IsMatch(txtRowNumber.Text, @"^\d+$"))
            {
                rowNumber = Convert.ToInt32(txtRowNumber.Text);
                rowNumber = int.Parse(txtRowNumber.Text);
            }
            else
            {
                if (Regex.IsMatch(txtRowNumber.Text, @"\d"))
                {
                    int q = 1;
                    while (q <= txtRowNumber.Text.Length)
                    {
                        string currentChar = txtRowNumber.Text.Substring(q - 1);
                        if (!Regex.IsMatch(currentChar, @"^\d+$"))
                        {
                            currentChar = "";
                            txtRowNumber.Text = txtRowNumber.Text.Substring(0, q - 1) + currentChar + txtRowNumber.Text.Substring(q, txtRowNumber.Text.Length);
                        }
                        q++;
                    }
                    q = 1;
                }
                else
                {
                    rowNumber = 0;
                }
            }
            lblAsterisk.Text = "";
            while (i <= rowNumber)
                {
                    lblAsterisk.Text += "\n" + additiveTop;
                    i++;
                    additiveTop += " \\";
                }
            i = 1;
            lblAsterisk.Text += "\n";
            while (i <= rowNumber)
            {
                while (n <= rowNumber - bottomCount)
                    {
                        lblAsterisk.Text += "/ ";
                        n++;
                    }
                lblAsterisk.Text += "\n";
                i++;
                bottomCount++;
                n = 1;
            } 

            i = 1;
            bottomCount = 0;
            additiveTop = "\\";
        }

        private void lblAsterisk_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Media.SoundPlayer;

namespace Variables
{
    public partial class Form1 : Form
    {
        SoundPlayer howDarude = new SoundPlayer(Variables.Properties.Resources.mumGetTheCam);
        


        public Form1()
        {
            InitializeComponent();

        }

        private void txtFirstYear_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSecondYear_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void isItALeapYear()
        {
            
            lblOutput.Text = ""; lblOutput.BackColor = Color.Black;
            int firstYear; if (!(txtFirstYear.Text == "")) { firstYear = Convert.ToInt32(txtFirstYear.Text); firstYear = int.Parse(txtFirstYear.Text); } else { firstYear = 0; }
            int secondYear; if(!(txtSecondYear.Text == "")) { secondYear = Convert.ToInt32(txtSecondYear.Text); secondYear = int.Parse(txtSecondYear.Text); } else { secondYear = 0; }
            if(firstYear > secondYear) {int firstAlt = firstYear;  int secondAlt = secondYear; secondYear = firstAlt;  firstYear = secondAlt;}
            int yearGap = secondYear - firstYear; int i = 0; int n = 0;  int leapYearAmount = 0; int lowestNumber = firstYear;
            if (yearGap < 0) { lblOutput.Text = "Error"; lblOutput.BackColor = Color.Red; }
            while(i < yearGap + 1) { while ((lowestNumber % 4 == 0) && ((!(lowestNumber % 100 == 0)) || (lowestNumber % 400 == 0)) && n == 0) { leapYearAmount++; n++; } n = 0; lowestNumber++; i++;}
            MessageBox.Show("There are " + leapYearAmount + " leap years between " + firstYear + " and " + secondYear + ", my dude");
            lblOutput.Text = "The previous set of years had " + leapYearAmount + " leap years between them, my dude";
            picFreg.Image = Variables.Properties.Resources.frEG_OVERLED;
            howDarude.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isItALeapYear();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            resetTheFreg();
        }

        private void txtFirstYear_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { isItALeapYear(); }
        }

        private void txtSecondYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { isItALeapYear(); }
        }

        private void resetTheFreg()
        {
            lblOutput.Text = "Please Enter 2 Numbers";
            picFreg.Image = Variables.Properties.Resources.freg;
            howDarude.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            resetTheFreg();
        }
    }
}

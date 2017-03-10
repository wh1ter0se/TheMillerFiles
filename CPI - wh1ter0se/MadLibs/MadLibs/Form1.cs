using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class Form1 : Form
    {
        int madlibNumber;
        string finalString;
        string windowName;
        bool stringInputReady = true;
        bool madlibError = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirstMadlib_Click(object sender, EventArgs e)
        {
            madlibNumber = 1;
            lblFirstWord.Visible = true;lblSecondWord.Visible = true;lblThirdWord.Visible = true;lblFourthWord.Visible = true;lblFifthWord.Visible = true;lblSixthWord.Visible = true;lblSeventhWord.Visible = true;lblEigthWord.Visible = true;lblNinthWord.Visible = true;lblTenthWord.Visible = true;lblEleventhWord.Visible = true;lblTwelfthWord.Visible = true;
            txtFirstWord.Visible = true;txtSecondWord.Visible = true;txtThirdWord.Visible = true;txtFourthWord.Visible = true;txtFifthWord.Visible = true;txtSixthWord.Visible = true;txtSeventhWord.Visible = true;txtEigthWord.Visible = true;txtNinthWord.Visible = true;txtTenthWord.Visible = true;txtEleventhWord.Visible = true;txtTwelfthWord.Visible = true;
            lblFirstWord.Text = "Location";
            lblSecondWord.Text = "Location";
            lblThirdWord.Text = "Object";
            lblFourthWord.Text = "'-ing' Verb";
            lblFifthWord.Text = "'-ing' Verb";
            lblSixthWord.Text = "Person";
            lblSeventhWord.Text = "Person";
            lblEigthWord.Text = "Beverage";
            lblNinthWord.Text = "Adjective";
            lblTenthWord.Text = "Person";
            lblEleventhWord.Text = "Verb";
            lblTwelfthWord.Text = "Adjective";
        }

        private void btnSecondMadlib_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry my dude, but this madlib isn't ready yet");
        }

        private void btnThirdMadlib_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry my dude, but this madlib isn't ready yet");
        }

        private void btnLykButton_Click(object sender, EventArgs e)
        {
            if (txtFirstWord.Text == "") { txtFirstWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtFirstWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtSecondWord.Text == "") { txtSecondWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtSecondWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtThirdWord.Text == "") { txtThirdWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtThirdWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtFourthWord.Text == "") { txtFourthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtFourthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtFifthWord.Text == "") { txtFifthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtFifthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtSixthWord.Text == "") { txtSixthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtSixthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtSeventhWord.Text == "") { txtSeventhWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtSeventhWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtEigthWord.Text == "") { txtEigthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtEigthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtNinthWord.Text == "") { txtNinthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtNinthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtTenthWord.Text == "") { txtTenthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtTenthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtEleventhWord.Text == "") { txtEleventhWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtEleventhWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (txtTwelfthWord.Text == "") { txtTwelfthWord.BackColor = Color.LightCoral; stringInputReady = false; } else { txtTwelfthWord.BackColor = System.Drawing.SystemColors.Window; stringInputReady = true; }
            if (stringInputReady)
            {
                if (madlibNumber == 1) {
                    string currentChar;
                    string firstWord = txtFirstWord.Text;
                    string secondWord = txtSecondWord.Text;
                    string thirdWord = txtThirdWord.Text;
                    string fourthWord = txtFourthWord.Text;
                    string fifthWord = txtFifthWord.Text;
                    string sixthWord = txtSixthWord.Text;
                    string seventhWord = txtSeventhWord.Text;
                    string eigthWord = txtEigthWord.Text;
                    string ninthWord = txtNinthWord.Text;
                    string tenthWord = txtTenthWord.Text;
                    string eleventhWord = txtEleventhWord.Text;
                    string twelfthWord = txtTwelfthWord.Text;

                    firstWord = firstWord.ToLower(); currentChar = firstWord.Substring(0, 1); currentChar = currentChar.ToUpper(); firstWord = currentChar + firstWord.Substring(1, (firstWord.Length - 1));
                    secondWord = secondWord.ToLower(); currentChar = secondWord.Substring(0, 1); currentChar = currentChar.ToUpper(); secondWord = currentChar + secondWord.Substring(1, (secondWord.Length - 1));
                    thirdWord = thirdWord.ToLower();
                    fourthWord = fourthWord.ToLower();
                    fifthWord = fifthWord.ToLower();
                    sixthWord = sixthWord.ToLower(); currentChar = sixthWord.Substring(0, 1); currentChar = currentChar.ToUpper(); sixthWord = currentChar + sixthWord.Substring(1, (sixthWord.Length - 1));
                    seventhWord = seventhWord.ToLower(); currentChar = seventhWord.Substring(0, 1); currentChar = currentChar.ToUpper(); seventhWord = currentChar + seventhWord.Substring(1, (seventhWord.Length - 1));
                    eigthWord = eigthWord.ToLower();
                    ninthWord = ninthWord.ToLower();
                    eleventhWord = eleventhWord.ToLower();
                    twelfthWord = twelfthWord.ToLower();

                    windowName = "The Fresh Prince of " + firstWord;
                    finalString = "Now, this is a story all about how \nMy life got flipped-turned upside down \nAnd I'd like to take a minute \nJust sit right there \nI'll tell you how I became the prince of a town called " + firstWord + "\nIn west " + secondWord + " born and raised \nOn the " + thirdWord + " was where I spent most of my days \nChillin' out maxin' relaxin' all cool \nAnd all " + fourthWord + " outside of the school \nWhen a couple of guys who were up to no good \nStarted " + fifthWord + " in my neighborhood \nI got in one little fight and my mom got scared \nShe said 'You're movin' with " + sixthWord + " and " + seventhWord + " in " + firstWord + "' \nI begged and pleaded with her day after day \nBut she packed my suitcase and sent me on my way \nShe gave me a kiss and then she gave me my ticket. \nI put my Walkman on and said, 'I might as well kick it'. \nFirst class, yo this is bad \nDrinking " + eigthWord + " out of a champagne glass. \nIs this what the people of " + firstWord + " living like? \nHmm this might be alright. \nBut wait I hear they're " + ninthWord + ", bourgeois, all that \nIs this the type of place thatthey just send this cool cat? \nI don't think so \nI'll see when I get there \nI hope they're prepared for the prince of " + firstWord + " \nWell, the plane landed and when I came out \nThere was a dude who looked like " + tenthWord + " standing there with my name out \nI ain't trying to " + eleventhWord + " yet \nI just got here \nI sprang with the quickness like lightning, disappeared \nI whistled for a cab and when it came near \nThe license plate said fresh and it had dice in the mirror \nIf anything I could say that this cab was " + twelfthWord + " \nBut I thought 'Nah, forget it' - 'Yo, home to " + firstWord + "' \nI pulled up to the house about 7 or 8 \nAnd I yelled to the cabbie 'Yo home smell ya later' \nI looked at my kingdom \nI was finally there \nTo sit on my throne as the Prince of " + firstWord;
                }
                else if (madlibNumber == 2) { windowName = ""; }
                else if (madlibNumber == 3) { windowName = ""; }
                else {madlibError = true;}
                if (madlibError == false)
                {
                    MessageBox.Show(finalString, windowName);
                    lblFirstWord.Visible = false; lblSecondWord.Visible = false; lblThirdWord.Visible = false; lblFourthWord.Visible = false; lblFifthWord.Visible = false; lblSixthWord.Visible = false; lblSeventhWord.Visible = false; lblEigthWord.Visible = false; lblNinthWord.Visible = false; lblTenthWord.Visible = false; lblEleventhWord.Visible = false; lblTwelfthWord.Visible = false;
                    txtFirstWord.Text = ""; txtSecondWord.Text = ""; txtThirdWord.Text = ""; txtFourthWord.Text = ""; txtFifthWord.Text = ""; txtSixthWord.Text = ""; txtSeventhWord.Text = ""; txtEigthWord.Text = ""; txtNinthWord.Text = ""; txtTenthWord.Text = ""; txtEleventhWord.Text = ""; txtTwelfthWord.Text = "";
                }
                madlibError = false;
            }

        }
    }
}

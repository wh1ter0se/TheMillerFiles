using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatQuote
{
    public partial class Form1 : Form
    {
        string[] txtSpeaker = new string[2];
        int timeLeft = 5;
        int attemptsLeft = new int();
        bool activeCountDown = new bool();
        int points = 0;
        int lengthModifier = new int();
        bool easterEggActivated = new bool();
        bool correct = new bool();
        string[] quotes = new string[11];
        public Form1()
        {
            InitializeComponent();
            lblQuote.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            restart();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void submit()
        {
            string submittedAnswer = txtEntry.Text;
            attemptsLeft = attemptsLeft - 1;
            lblAttemptsLeft.Text = "You have " + attemptsLeft + " attempts left.";
            if (activeCountDown == false)
            {
                if (submittedAnswer.ToLower() == txtSpeaker[0].ToLower())
                {
                    lblQuote.BackColor = Color.Lime;
                    lengthModifier = 1;
                    points = points + (lengthModifier * (attemptsLeft + 1));
                    picBox.Visible = true;
                    lblNameForgotten.Visible = false;
                    tmrYouWrong.Enabled = true;
                    activeCountDown = true;
                    lblQuote.Text = "You right, you right. Next question in " + timeLeft + " seconds";
                    correct = true;
                }
                else if (submittedAnswer.ToLower() == txtSpeaker[1].ToLower())
                {
                    lblQuote.BackColor = Color.Lime;
                    lengthModifier = 2;
                    points = points + (lengthModifier * (attemptsLeft + 1));
                    picBox.Visible = true;
                    lblNameForgotten.Visible = false;
                    tmrYouWrong.Enabled = true;
                    activeCountDown = true;
                    lblQuote.Text = "You right, you right. Next question in " + timeLeft + " seconds";
                    correct = true;

                }
                else
                {
                    lblQuote.BackColor = Color.Firebrick;
                    pgsTriesLeft.Value = (pgsTriesLeft.Value - 1);
                    if (pgsTriesLeft.Value <= 0)
                    {
                        lblQuote.Text = "Out of guesses. Next Question in " + timeLeft + " seconds.";
                        tmrYouWrong.Enabled = true;
                        activeCountDown = true;
                        correct = false;
                    }
                    if (attemptsLeft < 3)
                    {
                        picBox.Visible = true;
                        lblNameForgotten.Visible = true;
                    }
                    if (attemptsLeft < -30 && easterEggActivated == false)
                    {
                        points = points + 50;
                        easterEggActivated = true;
                    }
                }
            }
            }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void txtEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!txtEntry.AcceptsReturn)
                {
                    btnSubmit.PerformClick();
                }
            }
        }

        private void countDown() {
            if (timeLeft <= 0)
            {
                tmrYouWrong.Enabled = false;
                activeCountDown = false;
                timeLeft = 5;
                restart();
            }
            else if (correct == false)
            {
                lblQuote.Text = "Out of guesses. Next Question in " + timeLeft + " seconds.";
            }
            else
            {
                lblQuote.Text = "You right, you right. Next Question in " + timeLeft + " seconds";
            }
        }
        
        private void populateThoseArraysBud()
        {
            quotes[0] = "He's not gonna stop. You know that, right? A man like that. He's not even a man.";
            quotes[1] = "I never wanted to be the type to think big thoughts about the nature of things. All I ever wanted was a stack of pancakes and a V8.";
            quotes[2] = "Just one word. Yes, or no?";
            quotes[3] = "[I'm confused]... That's okay, I'm not.";
            quotes[4] = "What's with all the duct tape?";
            quotes[5] = "God is Real.";
            quotes[6] = "No. Highly irregular is the time I found a human foot in a toaster oven. This is just odd.";
            quotes[7] = "Because maps used to say, “There be dragons here.” Now they don’t. But that don’t mean the dragons aren’t there.";
            quotes[8] = "Yah, but you gotta try, don't ya?";
            quotes[9] = "Don't throw up in here. If you do, I will kill you. I will actually kill you.";
            quotes[10] = "That's the thing, you're still wrong!";
        }

        private void restart() {
            attemptsLeft = 3;
            easterEggActivated = false;
            btnRestart.Text = "Next Question";
            btnSubmit.Text = "Submit Answer";
            lengthModifier = 1;
            picBox.Visible = false;
            lblNameForgotten.Visible = false;
            lblPoints.Text = points + " points";
            lblAttemptsLeft.Text = "You have " + attemptsLeft + " attempts left.";
            lblQuote.BackColor = System.Drawing.SystemColors.Control;
            pgsTriesLeft.Value = 3;
            populateThoseArraysBud();
            Random rndGenerator = new Random();
            int rndNumber = rndGenerator.Next(0, 11);
            if (rndNumber == 0)
            {
                lblQuote.Text = quotes[0];
                txtSpeaker[0] = "Molly";
                txtSpeaker[1] = "Molly Solverson";
                picBox.Image = global::NameThatQuote.Properties.Resources.molly;
            }
            else if (rndNumber == 1)
            {
                lblQuote.Text = quotes[1];
                txtSpeaker[0] = "Bill";
                txtSpeaker[1] = "Bill Oswalt";
                picBox.Image = global::NameThatQuote.Properties.Resources.bill;
            }
            else if (rndNumber == 2)
            {
                lblQuote.Text = quotes[2];
                txtSpeaker[0] = "Malvo";
                txtSpeaker[1] = "Lorne Malvo";
                picBox.Image = global::NameThatQuote.Properties.Resources.malvo;
            }
            else if (rndNumber == 3)
            {
                lblQuote.Text = quotes[3];
                txtSpeaker[0] = "Malvo";
                txtSpeaker[1] = "Lorne Malvo";
                picBox.Image = global::NameThatQuote.Properties.Resources.malvo;
            }
            else if (rndNumber == 4)
            {
                lblQuote.Text = quotes[4];
                txtSpeaker[0] = "Chumph";
                txtSpeaker[1] = "Don Chumph";
                picBox.Image = global::NameThatQuote.Properties.Resources.chumph;
            }
            else if (rndNumber == 5)
            {
                lblQuote.Text = quotes[5];
                txtSpeaker[0] = "Stavros";
                txtSpeaker[1] = "The Supermarket King";
                picBox.Image = global::NameThatQuote.Properties.Resources.stavros;
            }
            else if (rndNumber == 6)
            {
                lblQuote.Text = quotes[6];
                txtSpeaker[0] = "Malvo";
                txtSpeaker[1] = "Lorne Malvo";
                picBox.Image = global::NameThatQuote.Properties.Resources.malvo;
            }
            else if (rndNumber == 7)
            {
                lblQuote.Text = quotes[7];
                txtSpeaker[0] = "Malvo";
                txtSpeaker[1] = "Lorne Malvo";
                picBox.Image = global::NameThatQuote.Properties.Resources.malvo;
            }
            else if (rndNumber == 8)
            {
                lblQuote.Text = quotes[8];
                txtSpeaker[0] = "Gus";
                txtSpeaker[1] = "Gus Grimly";
                picBox.Image = global::NameThatQuote.Properties.Resources.gus;
            }
            else if (rndNumber == 9)
            {
                lblQuote.Text = quotes[9];
                txtSpeaker[0] = "Numbers";
                txtSpeaker[1] = "Grady Numbers";
                picBox.Image = global::NameThatQuote.Properties.Resources.numbers;
            }
            else if (rndNumber == 10)
            {
                lblQuote.Text = quotes[10];
                txtSpeaker[0] = "Molly";
                txtSpeaker[0] = "Molly Solverson";
                picBox.Image = global::NameThatQuote.Properties.Resources.numbers;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tmrYouWrong_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            if (activeCountDown == true) {
                countDown();
            }
        }

        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter) {
                submit();
            }
        }

        private void tmrYouRight_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            if (activeCountDown == true)
            {
                countDown();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpOneFinal
{
    public partial class Form1 : Form
    {
        /////////////////// Random Letter Class ///////////////////
        static class RandomLetter
        {
            static Random _random = new Random();
            public static char GetLetter()
            {
                int num = _random.Next(0, 26);
                char let = (char)('a' + num);
                return let;
            }
        }



        /////////////////// Initial Constructor ///////////////////

        public Form1() // runs at beginning 
        {
            InitializeComponent();
            AssignVariables();
        }



        /////////////////// Variables ///////////////////

        bool countCompleted;
        bool firstRun;
        int count;
        int fifthNumber;
        int firstNumber;
        int fourthNumber;
        int secondNumber;
        int thirdNumber;
        string randomLetter;



        /////////////////// Methods ///////////////////

        private void CountNumbers() // counts how many times it has to run to get numbers 1-5 
        {
            if (firstNumber != 1 && secondNumber != 2 && thirdNumber != 3 && fourthNumber != 4 && fifthNumber != 5)
            {
                Random rnd = new Random();
                firstNumber = rnd.Next(1, 6);
                secondNumber = rnd.Next(1, 6);
                thirdNumber = rnd.Next(1, 6);
                fourthNumber = rnd.Next(1, 6);
                fifthNumber = rnd.Next(1, 6);
                count++;
            }
            else
            {
                CountNumbers();
            }
        }

        private void AssignVariables() // assigns default values 
        {
            firstRun = true;

            count = 0;
            lblCount.Text = "COUNT: NULL";
            firstNumber = 0;
            secondNumber = 0;
            thirdNumber = 0;
            fourthNumber = 0;
            fifthNumber = 0;
            lblFirstNumber.Text = "0";
            lblSecondNumber.Text = "0";
            lblThirdNumber.Text = "0";
            lblFourthNumber.Text = "0";
            lblFifthNumber.Text = "0";
        }



        /////////////////// Timers and Events ///////////////////

        private void tmrDelay_Tick(object sender, EventArgs e) // 10 second delay 
        {
                firstRun = true;
                tmrPizzazNumbers.Stop();
                tmrDelay.Stop();
            lblFirstNumber.Text = "1";
            lblSecondNumber.Text = "2";
            lblThirdNumber.Text = "3";
            lblFourthNumber.Text = "4";
            lblFifthNumber.Text = "5";
            lblCount.Text = "COUNT: " + count.ToString();
        }

        private void tmrPizzazNumbers_Tick(object sender, EventArgs e) // displays random numbers 
        {
            Random rnd = new Random();
            lblFirstNumber.Text = rnd.Next(Convert.ToInt32(txtMin.Text), (Convert.ToInt32(txtMax.Text) + 1)).ToString();
            if ( rnd.Next(0, 2) == 0)
            {
                randomLetter = RandomLetter.GetLetter().ToString();
                lblFirstNumber.Text = randomLetter;
            }
            lblSecondNumber.Text = rnd.Next(Convert.ToInt32(txtMin.Text), (Convert.ToInt32(txtMax.Text) + 1)).ToString();
            if (rnd.Next(0, 2) == 0)
            {
                randomLetter = RandomLetter.GetLetter().ToString();
                lblSecondNumber.Text = randomLetter;
            }
            lblThirdNumber.Text = rnd.Next(Convert.ToInt32(txtMin.Text), (Convert.ToInt32(txtMax.Text) + 1)).ToString();
            if (rnd.Next(0, 2) == 0)
            {
                randomLetter = RandomLetter.GetLetter().ToString();
                lblThirdNumber.Text = randomLetter;
            }
            lblFourthNumber.Text = rnd.Next(Convert.ToInt32(txtMin.Text), (Convert.ToInt32(txtMax.Text) + 1)).ToString();
            if (rnd.Next(0, 2) == 0)
            {
                randomLetter = RandomLetter.GetLetter().ToString();
                lblFourthNumber.Text = randomLetter;
            }
            lblFifthNumber.Text = rnd.Next(Convert.ToInt32(txtMin.Text), (Convert.ToInt32(txtMax.Text) + 1)).ToString();
            if (rnd.Next(0, 2) == 0)
            {
                randomLetter = RandomLetter.GetLetter().ToString();
                lblFifthNumber.Text = randomLetter;
            }
        }

        private void btnStart_Click(object sender, EventArgs e) // starts the code 
        {
            tmrDelay.Start();
            CountNumbers();
            tmrPizzazNumbers.Start();
        }

        private void btnQuit_Click(object sender, EventArgs e) // exits the window 
        {
            Application.Exit();
        }

        private void lblFirstNumber_Click(object sender, EventArgs e) // starts the code 
        {
            tmrDelay.Start();
            CountNumbers();
            tmrPizzazNumbers.Start();
        }

        private void btnReset_Click(object sender, EventArgs e) // sets values back to defaults
        {
            count = 0;
            lblCount.Text = "COUNT: NULL";
            firstNumber = 0;
            secondNumber = 0;
            thirdNumber = 0;
            fourthNumber = 0;
            fifthNumber = 0;
            lblFirstNumber.Text = "0";
            lblSecondNumber.Text = "0";
            lblThirdNumber.Text = "0";
            lblFourthNumber.Text = "0";
            lblFifthNumber.Text = "0";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplicationTables
{
    public partial class Form1 : Form
    {
        int multiplierType = 4;
        // 0 = multiplication
        // 1 = subtraction
        // 2 = addition
        // 3 = division
        // 4 = unselected

        public Form1()
        {
            InitializeComponent();

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void theOneThatDoesAllTheMath()
        {
            bool reverseChronology = false;
            bool middleManUsed = false;
            int endNumber;
            int middleMan = 0;
            int multiplier;
            int runTime;
            int startNumber;
            int startNumberPlusI = 0;
            List<string> finalOutput = new List<string>();
            string currentEntry = "";

            // the listbox is named lstListOfEquations
            // the start number input is named txtStartNumberInput
            // the end number input is named txtEndNumberInput
            // the multiplier input is named txtMultiplierInput
            if (-1 < multiplierType && multiplierType < 4)
            {
                if (txtStartNumberInput.Text == null) { startNumber = 0; } else { startNumber = Convert.ToInt32(txtStartNumberInput.Text); }
                if (txtEndNumberInput.Text == null) { endNumber = 0; } else { endNumber = Convert.ToInt32(txtEndNumberInput.Text); }
                if (txtMultiplierInput.Text == null) { multiplier = 0; } else { multiplier = Convert.ToInt32(txtMultiplierInput.Text); }
                // assign the values of start/end number
                if (endNumber < startNumber) { middleManUsed = true; middleMan = startNumber; startNumber = endNumber; endNumber = middleMan; middleMan = 0; }
                runTime = ((endNumber + 1) - startNumber); if (middleManUsed == true) { reverseChronology = true; middleMan = startNumber; startNumber = endNumber; endNumber = middleMan; middleMan = 0; }
                // swaps numbers around to get absolute difference for run time and sets chronology order AKA middle man code
                if (reverseChronology == false)
                {
                    for (int i = 0; i < runTime; i++)
                    {
                        startNumberPlusI = startNumber + i;
                        if (multiplierType == 0) { currentEntry = startNumberPlusI.ToString() + " * " + multiplier.ToString() + " = " + ((startNumberPlusI) * multiplier).ToString(); }
                        if (multiplierType == 1) { currentEntry = startNumberPlusI.ToString() + " - " + multiplier.ToString() + " = " + ((startNumberPlusI) - multiplier).ToString(); }
                        if (multiplierType == 2) { currentEntry = startNumberPlusI.ToString() + " + " + multiplier.ToString() + " = " + ((startNumberPlusI) + multiplier).ToString(); }
                        if (multiplierType == 3) { currentEntry = startNumberPlusI.ToString() + " ÷ " + multiplier.ToString() + " = " + ((startNumberPlusI) / multiplier).ToString(); }
                        finalOutput.Add(currentEntry);
                    }
                    lstListOfEquations.DataSource = finalOutput;
                }
                else
                {
                    for (int i = runTime; i > 0; i--)
                    {
                        if (multiplierType == 0) { currentEntry = (startNumberPlusI).ToString() + " * " + multiplier.ToString() + " = " + ((startNumberPlusI) * multiplier).ToString(); }
                        if (multiplierType == 1) { currentEntry = (startNumberPlusI).ToString() + " - " + multiplier.ToString() + " = " + ((startNumberPlusI) - multiplier).ToString(); }
                        if (multiplierType == 2) { currentEntry = (startNumberPlusI).ToString() + " + " + multiplier.ToString() + " = " + ((startNumberPlusI) + multiplier).ToString(); }
                        if (multiplierType == 3) { currentEntry = (startNumberPlusI).ToString() + " ÷ " + multiplier.ToString() + " = " + ((startNumberPlusI) / multiplier).ToString(); }
                        finalOutput.Add(currentEntry);
                    }
                    lstListOfEquations.DataSource = finalOutput;
                }
                // clean up behind yourself
                currentEntry = null;
                middleManUsed = false;
                reverseChronology = false;
            }
            else
            {
                MessageBox.Show("Please select a modifier.");
            }
        }

        private void buttonColor(int theInput)
        {
            btnMultiply.BackColor = System.Drawing.SystemColors.Control;
            btnSubtract.BackColor = System.Drawing.SystemColors.Control;
            btnAdd.BackColor = System.Drawing.SystemColors.Control;
            btnMultiply.BackColor = System.Drawing.SystemColors.Control;

            if (theInput == 0) { btnMultiply.BackColor = System.Drawing.SystemColors.ControlDark; }
            if (theInput == 1) { btnSubtract.BackColor = System.Drawing.SystemColors.ControlDark; }
            if (theInput == 2) { btnAdd.BackColor = System.Drawing.SystemColors.ControlDark; }
            if (theInput == 3) { btnDivide.BackColor = System.Drawing.SystemColors.ControlDark; }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (multiplierType != 0) { buttonColor(0); multiplierType = 0; } else { buttonColor(4); multiplierType = 4; }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (multiplierType != 1) { buttonColor(1); multiplierType = 1; } else { buttonColor(4); multiplierType = 4; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (multiplierType != 2) { buttonColor(2); multiplierType = 2; } else { buttonColor(4); multiplierType = 4; }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (multiplierType != 3) { buttonColor(3); multiplierType = 3; } else { buttonColor(4); multiplierType = 4; }
        }

        private void btnSmashDatLykButton_Click(object sender, EventArgs e)
        {
            theOneThatDoesAllTheMath();
        }
    }
}

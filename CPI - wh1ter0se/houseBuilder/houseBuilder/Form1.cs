using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace houseBuilder
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        class House
        {
            int bedrooms; int bathrooms;
            public House(int bed, int bath) { bedrooms = bed; bathrooms = bath; }
            public int getBeds() { return bedrooms; }
            public int getBaths() { return bathrooms; }
        }


        //////////////////////////////////////////////////////////

        bool firstHouseBuilt = false;
        bool fourthHouseBuilt = false;
        bool secondHouseBuilt = false;
        bool thirdHouseBuilt = false;
        House[] houses = new House[4];
        int bathValue;
        int bedValue;
        int currentHouse;
        int houseNumber;

        //////////////////////////////////////////////////////////

        private Image GenerateHouse()
        {
            Random rnd = new Random();
            houseNumber = rnd.Next(0, 4);
            if (houseNumber == 0) { return Properties.Resources.houseOne; }
            if (houseNumber == 1) { return Properties.Resources.houseTwo; }
            if (houseNumber == 2) { return Properties.Resources.houseThree; }
            else { return Properties.Resources.houseFour; }
        }

        private void ActivateFields()
        {
            lblBeds.Visible = true; lblBeds.Enabled = true;
            lblBaths.Visible = true; lblBaths.Enabled = true;
            txtBeds.Visible = true; txtBeds.Enabled = true;
            txtBaths.Visible = true; txtBaths.Enabled = true;
            btnGenerate.Visible = true; btnGenerate.Enabled = true;
        }

        private void DeactivateFields()
        {
            lblBeds.Visible = false; lblBeds.Enabled = false;
            lblBaths.Visible = false; lblBaths.Enabled = false;
            txtBeds.Visible = false; txtBeds.Enabled = false;
            txtBaths.Visible = false; txtBaths.Enabled = false;
            btnGenerate.Visible = false; btnGenerate.Enabled = false;
        }

        private void BuildHouse(int id)
        {
            houses[id] = new House(bedValue, bathValue);
        }

        private void SolidifyTextValues()
        {
            if (txtBeds.Text == "") { bedValue = 0; } else { bedValue = Math.Abs(Convert.ToInt32(txtBeds.Text)); }
            if (txtBaths.Text == "") { bathValue = 0; } else { bathValue = Math.Abs(Convert.ToInt32(txtBaths.Text)); }
        }

        private void btnFirstHouse_Click(object sender, EventArgs e)
        {
            if (!firstHouseBuilt)
            {
                ActivateFields();
                currentHouse = 0;
                btnFirstHouse.Enabled = false; btnFirstHouse.Visible = false;
                firstHouseBuilt = true; btnFirstHouse.Text = "Destroy House";
            }
            else
            {
                picFirstHouse.Enabled = false; picFirstHouse.Visible = false;
                firstHouseBuilt = false;
                btnFirstHouse.Text = "Build House";
            }
        }

        private void btnSecondHouse_Click(object sender, EventArgs e)
        {
            if (!secondHouseBuilt)
            {
                ActivateFields();
                currentHouse = 1;
                btnSecondHouse.Enabled = false; btnSecondHouse.Visible = false;
                secondHouseBuilt = true; btnSecondHouse.Text = "Destroy House";
            }
            else
            {
                picSecondHouse.Enabled = false; picSecondHouse.Visible = false;
                secondHouseBuilt = false;
                btnSecondHouse.Text = "Build House";
            }
        }

        private void btnThirdHouse_Click(object sender, EventArgs e)
        {
            if (!thirdHouseBuilt)
            {
                ActivateFields();
                currentHouse = 2;
                btnThirdHouse.Enabled = false; btnThirdHouse.Visible = false;
                thirdHouseBuilt = true; btnThirdHouse.Text = "Destroy House";
            }
            else
            {
                picThirdHouse.Enabled = false; picThirdHouse.Visible = false;
                thirdHouseBuilt = false;
                btnThirdHouse.Text = "Build House";
            }
        }

        private void btnFourthHouse_Click(object sender, EventArgs e)
        {
            if (!fourthHouseBuilt)
            {
                ActivateFields();
                currentHouse = 3;
                btnFourthHouse.Enabled = false; btnFourthHouse.Visible = false;
                fourthHouseBuilt = true; btnFourthHouse.Text = "Destroy House";
            }
            else
            {
                picFourthHouse.Enabled = false; picFourthHouse.Visible = false;
                fourthHouseBuilt = false;
                btnFourthHouse.Text = "Build House";
            }
        }

        private void picFirstHouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This house has " + houses[0].getBeds() + " bedrooms and " + houses[0].getBaths() + " bathrooms.");
        }

        private void picSecondHouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This house has " + houses[1].getBeds() + " bedrooms and " + houses[1].getBaths() + " bathrooms.");
        }

        private void picThirdHouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This house has " + houses[2].getBeds() + " bedrooms and " + houses[2].getBaths() + " bathrooms.");
        }

        private void picFourthHouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This house has " + houses[3].getBeds() + " bedrooms and " + houses[3].getBaths() + " bathrooms.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
                houses[0] = new House(0, 0);
                houses[1] = new House(0, 0);
                houses[2] = new House(0, 0);
                houses[3] = new House(0, 0);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SolidifyTextValues();
            BuildHouse(currentHouse);
            if (currentHouse == 0 ) { picFirstHouse.Image = GenerateHouse(); picFirstHouse.Enabled = true; picFirstHouse.Visible = true; btnFirstHouse.Enabled = true; btnFirstHouse.Visible = true; }
            else if (currentHouse == 1) { picSecondHouse.Image = GenerateHouse(); picSecondHouse.Enabled = true; picSecondHouse.Visible = true; btnSecondHouse.Enabled = true; btnSecondHouse.Visible = true; }
            else if (currentHouse == 2) { picThirdHouse.Image = GenerateHouse(); picThirdHouse.Enabled = true; picThirdHouse.Visible = true; btnThirdHouse.Enabled = true; btnThirdHouse.Visible = true; }
            else { picFourthHouse.Image = GenerateHouse(); picFourthHouse.Enabled = true; picFourthHouse.Visible = true; btnFourthHouse.Enabled = true; btnFourthHouse.Visible = true; }
            DeactivateFields();
        }

        private void txtBeds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtBaths_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}

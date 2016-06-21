using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleTA
{
    //A generic calculator to do a specific integer maths function.
    public partial class IntegerCalculator : Form
    {
        //The bit that actually does the maths we want.
        private CalculationTranslater icProcess;

        public IntegerCalculator(CalculationTranslater Process, String FormName)
        {
            InitializeComponent();
            icProcess = Process;
            this.Text = FormName;
        }

        //A series of events. Together, these make the numpad displayed input a number into the textbox display.
        private void btnNumpad9_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "9";
        }

        private void btnNumpad8_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "8";
        }

        private void btnNumpad7_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "7";
        }

        private void btnNumpad6_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "6";
        }

        private void btnNumpad5_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "5";
        }

        private void btnNumpad4_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "4";
        }

        private void btnNumpad3_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "3";
        }

        private void btnNumpad2_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "2";
        }

        private void btnNumpad1_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "1";
        }

        private void btnNumpad0_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = txbxNumberDisplay.Text + "0";
        }

        //Pressing this will clear the textbox display and the output box.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbxNumberDisplay.Text = "";
            txbxOutput.Text = "";
            icProcess.ClearButtonPressed();
        }

        //Pressing this will take the current displayed number, send it to have maths done, then display an output in the output box.
        private void btnFactorise_Click(object sender, EventArgs e)
        {
            bool boolNumberAccepted = false;
            int intNumberToFactorise = 0;
            //Get the number (it might be too big)
            try
            {
                intNumberToFactorise = Convert.ToInt32(txbxNumberDisplay.Text);
                boolNumberAccepted = true;
            }
            catch (OverflowException oe)
            {
                boolNumberAccepted = false;
                MessageBox.Show("Sorry, but the number you entered is too large. Please try a different number.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If we got a valid input then do some calculation.
            if(boolNumberAccepted)
            {
                txbxOutput.Text += icProcess.CalculationButtonPressed(intNumberToFactorise);
            }

            //Clear the display so a new number can be entered
            txbxNumberDisplay.Text = "";
        }

        //If they press backspace, remove the last digit of displayed number
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txbxNumberDisplay.Text.Length > 0)
            {
                txbxNumberDisplay.Text = txbxNumberDisplay.Text.Remove(txbxNumberDisplay.Text.Length - 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    // Specific translater for the HCF Calculation.
    //Takes a number input and gives it to the calculation. Then takes a number output, writes a string with it, and passes that back to the form.
    class HCFTranslater : CalculationTranslater
    {
        //These hold the inputted values between the button being pressed. (-1) will be used as a null for when one of them still needs to be set.
        private int intValueOne;
        private int intValueTwo;
        //A single HCFC to be used for all calculations
        private HighestCommonFactorCalculation hcfc;

        //Initialise with null values and make a HCFC
        public HCFTranslater()
        {
            intValueOne = -1;
            intValueTwo = -1;
            hcfc = new HighestCommonFactorCalculation();
        }

        //If clear button pressed then set both to null
        public void CalculationTranslater.ClearButtonPressed()
        {
            intValueOne = -1;
            intValueTwo = -1;
        }

        //If calculate button pressed, we need to find out what values need setting, and if we have both values then find the HCF
        public String CalculationTranslater.CalculationButtonPressed(int intInput)
        {
            if (intValueOne == -1)
            {
                //If we're looking for a 1st number, put the value there for later.
                intValueTwo = intInput;
                return "First number has been set to " + intInput.ToString() + ". Please enter a second number." + Environment.NewLine;
            }
            else if (intValueTwo == -1)
            {
                //else we already have a first and need a second
                intValueTwo = intInput;
                String strOutput = "";
                int intHCF = hcfc.FindHCFOfTwoNumbers(intValueOne, intValueTwo);

                if (intHCF != -1)
                {
                    strOutput = "The Lowest Common Multiple of " + intValueOne.ToString() + " and " + intValueTwo.ToString() + " is:" + Environment.NewLine + intHCF.ToString() + Environment.NewLine;
                }
                else
                {
                    strOutput = "Sorry, an error has occured. Please press 'Clear' and try again.";
                }
                intValueOne = -1; //Reset to null for next pair of numbers
                intValueTwo = -1;
                return strOutput;
            }
            else
            {
                //else something has gone wrong, set our numbers to null and give error
                intValueOne = -1;
                intValueTwo = -1;
                return "Sorry, an error has occured. Please press 'Clear' and try again.";
            }
        }
    }
}

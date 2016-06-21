using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //translater for the prime factor calculation
    //Takes a number input and gives it to the calculation. Then takes a number output, writes a string with it, and passes that back to the form.
    class PrimeFactorTranslater : CalculationTranslater
    {
        //Holds a single PFC to be used by this translater
        private PrimeFactorisingCalculation pfc;

        //Initialise and make a PFC to use
        public PrimeFactorTranslater()
        {
            pfc = new PrimeFactorisingCalculation();
        }

        public void CalculationTranslater.ClearButtonPressed()
        {
            //Do nothing, we have no variables to reset.
        }

        public String CalculationTranslater.CalculationButtonPressed(int intInput)
        {
            //Get the Factors
            int[] intFactors = pfc.Factorize(intInput);

            String strOutput = "";

            //Display intro:
            strOutput = "The prime factors of " + intInput.ToString() + " are:";

            //Display factors.
            for (int i = 0; i < intFactors.Length; i++)
            {
                strOutput += Environment.NewLine + intFactors[i];
            }
            strOutput += Environment.NewLine;
            return strOutput;
        }
    }
}

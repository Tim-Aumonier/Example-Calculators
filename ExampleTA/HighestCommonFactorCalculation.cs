using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //Calculation for working out HFCs
    class HighestCommonFactorCalculation : IntCalculationUsingArrays
    {
        public int FindHCFOfTwoNumbers(int intNumberOne, int intNumberTwo)
        {
            //Get prime factors into ordered list.
            PrimeFactorisingCalculation pfc = new PrimeFactorisingCalculation();
            int[] intSortedFirstFactors = pfc.Factorize(intNumberOne);
            int[] intSortedSecondFactors = pfc.Factorize(intNumberTwo);

            //Go through the lists simultainiously, if the current factors don't match then add the lowest to list and increment that array. If they do match then add the value to list once and increment both lists.
            //Once one list is done, add what remains of the other list.
            int intFirstElement = 0;
            int intSecondElement = 0;
            int[] intHCFFactors = new int[0];

            while (intFirstElement < intSortedFirstFactors.Length && intSecondElement < intSortedSecondFactors.Length)
            {
                if (intSortedFirstFactors[intFirstElement] < intSortedSecondFactors[intSecondElement])
                {
                    intFirstElement++;
                }
                else if (intSortedFirstFactors[intFirstElement] > intSortedSecondFactors[intSecondElement])
                {
                    intSecondElement++;
                }
                else if (intSortedFirstFactors[intFirstElement] == intSortedSecondFactors[intSecondElement])
                {
                    intHCFFactors = ExtendIntArray(intHCFFactors, intSortedFirstFactors[intFirstElement]);
                    intFirstElement++;
                    intSecondElement++;
                }
            }

            int intHCF = 1;
            //Now multiply all the prime factors of the HCF together and give the answer
            for (int i = 0; i < intHCFFactors.Length; i++)
            {
                try
                {
                    intHCF = intHCF * intHCFFactors[i];
                }
                catch (OverflowException oe)
                {
                    return -1;
                }
            }

            return intHCF;
        }
    }
}

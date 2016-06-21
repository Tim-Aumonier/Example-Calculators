using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //Calculation for working out LCMs
    public class LowestCommonMultipleCalculation : IntCalculationUsingArrays
    {
        public int FindLCMOfTwoNumbers(int intNumberOne, int intNumberTwo)
        {
            //Get prime factors into ordered list.
            PrimeFactorisingCalculation pfc = new PrimeFactorisingCalculation();
            int[] intSortedFirstFactors = pfc.Factorize(intNumberOne);
            int[] intSortedSecondFactors = pfc.Factorize(intNumberTwo);

            //Go through the lists simultainiously, if the current factors don't match then add the lowest to list and increment that array. If they do match then add the value to list once and increment both lists.
            //Once one list is done, add what remains of the other list.
            int intFirstElement = 0;
            int intSecondElement = 0;
            int[] intLCMFactors = new int[0];

            while (intFirstElement < intSortedFirstFactors.Length && intSecondElement < intSortedSecondFactors.Length)
            {
                if (intSortedFirstFactors[intFirstElement] < intSortedSecondFactors[intSecondElement])
                {
                    intLCMFactors = ExtendIntArray(intLCMFactors, intSortedFirstFactors[intFirstElement]);
                    intFirstElement++;
                }
                else if (intSortedFirstFactors[intFirstElement] > intSortedSecondFactors[intSecondElement])
                {
                    intLCMFactors = ExtendIntArray(intLCMFactors, intSortedSecondFactors[intSecondElement]);
                    intSecondElement++;
                }
                else if (intSortedFirstFactors[intFirstElement] == intSortedSecondFactors[intSecondElement])
                {
                    intLCMFactors = ExtendIntArray(intLCMFactors, intSortedFirstFactors[intFirstElement]);
                    intFirstElement++;
                    intSecondElement++;
                }
            }
            //Add any left over
            for (intFirstElement += 0; intFirstElement < intSortedFirstFactors.Length; intFirstElement++)
            {
                intLCMFactors = ExtendIntArray(intLCMFactors, intSortedFirstFactors[intFirstElement]);
            }
            for (intSecondElement += 0; intSecondElement < intSortedSecondFactors.Length; intSecondElement++)
            {
                intLCMFactors = ExtendIntArray(intLCMFactors, intSortedSecondFactors[intSecondElement]);
            }

            int intLCM = 1;

            //Now multiply all the prime factors of the LCM together and give the answer
            for (int i = 0; i < intLCMFactors.Length; i++)
            {
                try
                {
                    intLCM = intLCM * intLCMFactors[i];
                }
                catch (OverflowException oe)
                {
                    //-1 is used as a null to say that an error occured.
                    return -1;
                }
            }

            //Return answer
            return intLCM;
        }

        //Repeatedly finds LCM of two numbers, going down array with current total and next element.
        public int FindLCMOfArray(int[] intArrayOfNumbers)
        {
            int intCurrentLCM = intArrayOfNumbers[0];
            for(int i = 0 ; i < intArrayOfNumbers.Length ; i++)
            {
                if (intCurrentLCM != -1)
                {
                    intCurrentLCM = FindLCMOfTwoNumbers(intCurrentLCM, intArrayOfNumbers[i]);
                }
            }
            return intCurrentLCM;
        }
    }
}

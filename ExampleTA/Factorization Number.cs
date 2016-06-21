using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //Class to find the prime factorization of a number.
    //Works by recursively finding any factor it can. Eventually it runs out of factors, so the end number must be prime. Return the prime up the tree and follow other branches until all prime factors are found.
    public class FactorizationNumber
    {
        private int intValue;
        private Boolean blnPrime;
        private int[] intPrimeFactors;

        public FactorizationNumber(int number)
        {
            intValue = number;
            intPrimeFactors = new int[0];
            PrimeFactorize();
        }

        private void PrimeFactorize()
        {
            //Find root of Value
            //From largest to smallest, find first number <= root that is factor.


            Boolean blnFoundFactor = false; //Will be used later to cause recursion when a new factor is found.
            double dblAttemptedFactor; //Current number we're attempting to see if it is a factor.
            double dblDivision; //Used for seeing if attempted factor divides the value.
            double dblValue = System.Convert.ToDouble(intValue);

            //Find the largest integer <= the square root of the value
            double dblRoot = dblValue;
            dblRoot = Math.Sqrt(dblRoot);
            dblAttemptedFactor = Math.Floor(dblRoot);
            dblDivision = dblValue / dblAttemptedFactor;

            //While we have yet to find a factor, and our attempt at a factor is bigger than 1:
            //Try each number successivly smaller until we find a factor.
            while (!blnFoundFactor && dblAttemptedFactor > 1)
            {
                //Is our attempt at a factor, a factor?
                dblDivision = dblValue / dblAttemptedFactor;
                if (dblDivision == Math.Floor(dblDivision))
                {
                    //If yes, exit the loop
                    blnFoundFactor = true;
                }
                else
                {
                    //If no, try the next number
                    dblAttemptedFactor = dblAttemptedFactor - 1;
                }
            }

            //Did we find a new factor?
            if (blnFoundFactor)
            {
                //Yes, so not prime. Find the other factor and go reccursive for their prime factors
                SetPrime(false);
                int intFactor1 = System.Convert.ToInt32(dblAttemptedFactor);
                int intFactor2 = System.Convert.ToInt32(dblDivision);

                FactorizationNumber fnFactor1 = new FactorizationNumber(intFactor1);
                FactorizationNumber fnFactor2 = new FactorizationNumber(intFactor2);

                int[] intHalfPrimeList1 = fnFactor1.GetPrimeFactors();
                int[] intHalfPrimeList2 = fnFactor2.GetPrimeFactors();
                int[] intTotalPrimeList = intHalfPrimeList1.Concat(intHalfPrimeList2).ToArray();
                SetPrimeFactors(intTotalPrimeList);
            }
            else
            {
                //No, so our number is prime and we're done
                SetPrime(true);
                int[] IAmPrime = { intValue };
                SetPrimeFactors(IAmPrime);
            }
        }

        private void SetPrime(Boolean Prime)
        {
            blnPrime = Prime;
        }

        private void SetPrimeFactors(int[] PrimeFactors)
        {
            intPrimeFactors = new int[PrimeFactors.Length];
            for (int i = 0; i < PrimeFactors.Length; i++)
            {
                intPrimeFactors[i] = PrimeFactors[i];
            }
        }

        public int[] GetPrimeFactors()
        {
            return intPrimeFactors;
        }

        public Boolean GetPrime()
        {
            return blnPrime;
        }
    }
}

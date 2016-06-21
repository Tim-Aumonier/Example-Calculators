using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //Calculation for finding prime factors
    public class PrimeFactorisingCalculation : IntCalculationUsingArrays
    {
        //The actual method that does factorising work
        public int[] Factorize(int intNumberToFactorise)
        {
            //Factorise the number
            FactorizationNumber fnNumberToFactorise = new FactorizationNumber(intNumberToFactorise);

            //Get the factors and order them.
            int[] intFactors = fnNumberToFactorise.GetPrimeFactors();
            int[] intSortedFactors = SortIntArray(intFactors);

            return intSortedFactors;

        }
    }
}

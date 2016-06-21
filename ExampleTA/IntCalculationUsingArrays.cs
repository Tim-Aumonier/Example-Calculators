using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //Base class. A lot of calculations fiddle around with int arrays. This class holds some commonly used methods to pass on to all calculations that need them.
    public abstract class IntCalculationUsingArrays
    {
        //Just a method to sort arrays
        protected int[] SortIntArray(int[] intToBeSorted)
        {
            //Takes an integer array and sorts it into numerical order.
            int[] intSortedArray = new int[intToBeSorted.Length];
            int intHold = 0; //Hold will be used to remember which number so far is the smallest.
            Boolean[] boolAlreadyTaken = new Boolean[intToBeSorted.Length];
            for (int i = 0; i < boolAlreadyTaken.Length; i++) //Initialise boolean array as false.
            {
                boolAlreadyTaken[i] = false;
            }

            for (int i = 0; i < intToBeSorted.Length; i++)
            {
                intHold = -1; //Set to null, we will later take the first value in the array that hasn't already been used.
                for (int j = 0; j < intToBeSorted.Length; j++)
                {
                    if (intHold == -1 && !boolAlreadyTaken[j])
                    {
                        intHold = j;
                    }
                    else if (intHold != -1)
                    {
                        if (intToBeSorted[intHold] > intToBeSorted[j] && !boolAlreadyTaken[j])
                        {
                            intHold = j;
                        }
                    }
                }
                intSortedArray[i] = intToBeSorted[intHold];
                boolAlreadyTaken[intHold] = true;
            }
            return intSortedArray;
        }

        //Method to take an array and a number, and output a new array with an extra element set to that number.
        protected int[] ExtendIntArray(int[] intToBeExtended, int intToAdd)
        {
            int[] intOutput = new int[intToBeExtended.Length + 1];
            for (int i = 0; i < intToBeExtended.Length; i++)
            {
                intOutput[i] = intToBeExtended[i];
            }
            intOutput[intToBeExtended.Length] = intToAdd;
            return intOutput;
        }
    }
}

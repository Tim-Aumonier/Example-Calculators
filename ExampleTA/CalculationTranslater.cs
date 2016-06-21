using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTA
{
    //This interface is for bridging between The calculator form, and the individual translaters.
    //The translaters are for passing on the numerical input, taking a numerical output, and then turning that to a string to be displayed.
    public interface CalculationTranslater
    {
        string CalculationButtonPressed(int input);

        void ClearButtonPressed();
    }
}

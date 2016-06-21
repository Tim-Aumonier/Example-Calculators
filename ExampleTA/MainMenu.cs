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
    //This exists to be a main menu, allowing acess to everything else
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Open a new form for prime factorisation if the button is pressed
        private void btnPrimeFactorisation_Click(object sender, EventArgs e)
        {
            PrimeFactorTranslater pft = new PrimeFactorTranslater();
            IntegerCalculator icPrimeFactoriser = new IntegerCalculator(pft, "Prime Factoriser");
            icPrimeFactoriser.Show();
        }

        private void btnLCM_Click(object sender, EventArgs e)
        {
            LCMTranslater lcmt = new LCMTranslater();
            IntegerCalculator icLCMFinder = new IntegerCalculator(lcmt, "LCM Finder");
            icLCMFinder.Show();
        }

        private void btnHCF_Click(object sender, EventArgs e)
        {
            HCFTranslater hcft = new HCFTranslater();
            IntegerCalculator icHCFFinder = new IntegerCalculator(hcft, "HCF Finder");
            icHCFFinder.Show();
        }
    }
}

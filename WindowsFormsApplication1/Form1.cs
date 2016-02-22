using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Main Form
        public Form1()
        {
            InitializeComponent();
            recalculate();
        }

        // Test function for calculating the total number of dots on a single die
        public int totalNrOfDotsOnAllSides(int sidesPerDie)
        {
            return (sidesPerDie + 1) * sidesPerDie / 2;
        }

        //
        // Recursive function to calculate the number of ways to throw 'totalNrOfDots' 
        // with 'nrOfDice' Dice with each 'sidePerDie' sides per die.
        //
        public int numberOfWaysToThrow(int totalNrOfDots, int nrOfDice, int sidesPerDie)
        {
            int nrOfWays = 0;

            // The trivial case of a single die
            if (nrOfDice == 1)
            {
                if (totalNrOfDots >= 1 && totalNrOfDots <= sidesPerDie)
                {
                    nrOfWays = 1;
                }
            }
            else

            // All other nr of dice are calculated recursively based on the 1 die case.
            // 
            // The number of ways to throw 'totalNrOfDots' with 'nrOfDice' Dice with each 'sidePerDie' sides per die is the same as
            // The number of ways to throw ('totalNrOfDots' - nrOfDots) with ('nrOfDice' - 1) Dice with each 'sidePerDie' sides per 
            // die for each of the 'nrOfDice'-th die
            // For example, the number of ways to throw 5 with 3 dice is:
            // the number of ways to throw 4 with 2 dies and with 3-rd die 1 => 3
            // PLUS
            // the number of ways to throw 3 with 2 dies and with 3-rd die 2 => 2
            // PLKUS
            // the number of ways to throw 2 with 2 dies and with 3-rd die 3 => 1
            // which totals 3 + 2 + 1 = 6
            {
                Debug.WriteLine("nrOfDice     : " + nrOfDice);
                Debug.WriteLine("totalNrOfDots: " + totalNrOfDots);

                nrOfWays = 0;
                for (int i = Math.Min(nrOfDice * (sidesPerDie + 1) - totalNrOfDots, totalNrOfDots) - 1; i > 0; i--)
                {
                    nrOfWays += numberOfWaysToThrow(i, nrOfDice - 1, sidesPerDie);
                }
                Debug.WriteLine("nrOfWays     : " + nrOfWays);
            }

            Debug.WriteLine("Nr of ways to throw " + totalNrOfDots + " with " + nrOfDice + " = " + nrOfWays);
            return nrOfWays;
        }

        public void recalculate()
        {

            int totalDots = 0;
            int nrOfDice = 0;
            int sidesPerDie = 0;

            try
            {
                totalDots = Int32.Parse(mTotalDots_TXT.Text);
                nrOfDice = Int32.Parse(mNrOfDice_TXT.Text);
                sidesPerDie = Int32.Parse(mSidesPerDie_TXT.Text);
            }
            catch(FormatException e)
            {
                Debug.WriteLine("Exception: " + e);
                return; // Do not calc;
            }
            mNrOfWays_TXT.Text = "" + numberOfWaysToThrow(totalDots, nrOfDice, sidesPerDie);
        }

        private void mNrOfDice_TXT_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Nr Of Dice text changed: " + e.ToString());
            recalculate();
        }

        private void mSidesPerDie_TXT_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Sides per Die text changed: " + e.ToString());
            recalculate();
        }

        private void mTotalDots_TXT_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Total dots text changed: " + e.ToString());
            recalculate();
        }
    }


}

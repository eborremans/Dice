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
        private string possibilities;
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
        public int numberOfWaysToThrow(int totalNrOfDots, int nrOfDice, int sidesPerDie, bool start)
        {
            int nrOfWays = 0;
            Debug.WriteLine("Total nr of dots : " + totalNrOfDots);
            Debug.WriteLine("Nr of dice       : " + nrOfDice);
            Debug.WriteLine("Side per die     : " + sidesPerDie);
            Debug.WriteLine("Start            : " + (start ? "true" : "false"));

            // The trivial case of a single die
            if (nrOfDice == 1)
            {

                if (totalNrOfDots >= 1 && totalNrOfDots <= sidesPerDie)
                {
                    nrOfWays = 1;
                    possibilities = "" + totalNrOfDots;
                    Debug.WriteLine("Nr of ways to throw " + totalNrOfDots + " with " + nrOfDice + " dice = " + nrOfWays);
                    Debug.WriteLine("possibilities[1]: " + possibilities);
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
                nrOfWays = 0;
                for (int i = Math.Min(nrOfDice * (sidesPerDie + 1) - totalNrOfDots, totalNrOfDots); (i - 1) > 0; i--)
                {
                    nrOfWays += numberOfWaysToThrow(i - 1, nrOfDice - 1, sidesPerDie, false);
                    Debug.WriteLine("Nr of ways to throw " + i + " with " + (nrOfDice - 1) + " dice = " + nrOfWays + " prepending " + ((totalNrOfDots - i) + 1));
                    possibilities = "" + ((totalNrOfDots - i) + 1) + possibilities + (start ? "\n" : "");
                    Debug.WriteLine("possibilities[n]: " + possibilities);
                }
            }

            return nrOfWays;
        }

        // Calculate the permutations of 'nrOfDice' dice that add up to 'sum
        public List<string> calcPermutations(int sum, int nrOfDice, int sidesPerDie)
        {
            List<string> result = new List<string>();

            if (sum > 0 && sum <= sidesPerDie * nrOfDice)
            {
                if (nrOfDice > 0)
                {
                    // trivial case for one die
                    if (nrOfDice == 1)
                    {
                        if (sum >= 1 && sum <= sidesPerDie)
                        {
                            result.Add("" + sum);
                        }
                    }
                    else
                    {
                        if (sum >= nrOfDice && sum <= nrOfDice * sidesPerDie)
                        {
                            for (int i = 1; i <= sidesPerDie; i++)
                            {
                                List<string> permutations = calcPermutations(sum - i, nrOfDice - 1, sidesPerDie);
                                int nrOfPermutations = permutations.Count();

                                // Prepend i to the list of permutations found
                                Debug.WriteLine("Prepending " + i + " to " + nrOfPermutations + " permutations");
                                string separator = "-";
                                for (int j = 0; j < nrOfPermutations; j++)
                                {
                                    permutations[j] = "" + i + separator + permutations[j];
                                    result.Add(permutations[j]);
                                }
                            }
                        }
                    }
                }
            }
            Debug.WriteLine("Total nr of dots   : " + sum);
            Debug.WriteLine("Nr of dice         : " + nrOfDice);
            Debug.WriteLine("Side per die       : " + sidesPerDie);
            Debug.WriteLine("Permutations found : " + result.Count());

            Debug.WriteLine(convertPermutationsToString(result));
            return result;
        }

        // Repopulate the result fields
        public void recalcPermutations()
        {
            Debug.WriteLine("");
            Debug.WriteLine("*** New Calculation ***");
            Debug.WriteLine("");

            int sum = 0;
            int nrOfDice = 0;
            int sidesPerDie = 0;
            double nrOfPossibilities = 0;
            double chance = 0;

            try
            {
                sum = Int32.Parse(mTotalDots_TXT.Text);
                nrOfDice = Int32.Parse(mNrOfDice_TXT.Text);
                sidesPerDie = Int32.Parse(mSidesPerDie_TXT.Text);
            }
            catch(FormatException e)
            {
                Debug.WriteLine("Exception: " + e);
                return;
            }
            List<string> result = calcPermutations(sum, nrOfDice, sidesPerDie);
            mPermutations_TXT.Text = convertPermutationsToString(result);
            mNrOfWays_TXT.Text = "" + result.Count();
            nrOfPossibilities = Math.Pow(sidesPerDie, nrOfDice);
            mTotalNrOfPossibilities_TXT.Text = "" + nrOfPossibilities;
            chance = result.Count() / nrOfPossibilities * 100;
            mChance_TXT.Text = string.Format("{0:0.00}", chance) + "%";
        }

        // Converts a List of string to a single string
        public string convertPermutationsToString(List<string> permutations)
        {
            string separator = "";
            string result = "";
            for (int i = 0; i < permutations.Count(); i++)
            {
                result += separator + permutations[i];
                separator = ", ";
            }
            return result;
        }

        // Repopulate the result fields
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

            string possibilities = "";
            int nrOfWays = numberOfWaysToThrow(totalDots, nrOfDice, sidesPerDie, true);
            mNrOfWays_TXT.Text = "" + nrOfWays;
            Debug.WriteLine("Nr of ways to throw " + totalDots + " with " + nrOfDice + " dice = " + nrOfWays);
            mOutput_TXT.Text = possibilities;
            Debug.WriteLine("possibilities[x]: " + possibilities);
        }

        private void mNrOfDice_TXT_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Nr Of Dice text changed: " + e.ToString());
            //recalculate();
            recalcPermutations();
        }

        private void mSidesPerDie_TXT_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Sides per Die text changed: " + e.ToString());
            //recalculate();
            recalcPermutations();
        }

        private void mTotalDots_TXT_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Total dots text changed: " + e.ToString());
            //recalculate();
            recalcPermutations();
        }

    }


}

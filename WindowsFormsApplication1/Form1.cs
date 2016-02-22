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
        public Form1()
        {
            InitializeComponent();
            recalculate();
        }

        public int totalNrOfDotsOnAllSides(int sidesPerDie)
        {
            return (sidesPerDie + 1) * sidesPerDie / 2;
        }

        public int numberOfWaysToThrow(int totalNrOfDots, int nrOfDice, int sidesPerDie)
        {
            int nrOfWays = 0;

            if (nrOfDice == 1)
            {
                if (totalNrOfDots >= 1 && totalNrOfDots <= sidesPerDie)
                {
                    nrOfWays = 1;
                }
            }
            else if(nrOfDice == 2)
            {
                nrOfWays = Math.Min(nrOfDice * (sidesPerDie + 1) - totalNrOfDots, totalNrOfDots) - 1;
                if (nrOfWays < 0) nrOfWays = 0;

                Debug.WriteLine("nrOfDice: " + nrOfDice);
                Debug.WriteLine("nrOfWays: " + nrOfWays);
            }           
            else
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

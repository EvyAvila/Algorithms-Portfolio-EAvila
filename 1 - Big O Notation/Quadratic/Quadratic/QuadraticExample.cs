using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    public class QuadraticExample
    {
        /// <summary>
        /// The following code is a demonstration of Big O Notation O(n^2) or Quadratic
        /// A public void called PrintTimeSignature contains two for loops that
        /// goes through the arrays topNumber and bottom number and displays 
        /// each element. Since it consist of two instructions occuring, each loop
        /// has to look over all combinations, which can display more than the input
        /// values.
        /// </summary>

        public int[] TopNum = { 2, 3, 4, 6};
        public int[] BottomNum = { 2, 4, 8 };

        public void PrintTimeSignatures(int[] topNumber, int[] bottomNumber)
        {
            Console.WriteLine("Time Signatures:");
            for(int b = 0; b < bottomNumber.Length; b++)
            {
                for(int t = 0; t < topNumber.Length; t++)
                {
                    Console.WriteLine(topNumber[t] + "/" + bottomNumber[b]);
                    //Console.WriteLine($"also knowns as top {t + 1} and bottom {b + 1} \n");
                    //Uncomment above line to see how each order is placed
                }
            }
        }
    }
}

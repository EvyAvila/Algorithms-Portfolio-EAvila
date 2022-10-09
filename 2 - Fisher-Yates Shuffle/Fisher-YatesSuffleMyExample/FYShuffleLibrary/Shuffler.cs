using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FYShuffleLibrary.ExtractFile;


namespace FYShuffleLibrary
{
    public static class Shuffler
    {
        /// <summary>
        /// A field called rand is a Random Number Generater that
        /// will be used for the purpose of shuffling.
        /// </summary>
        private static Random rand = new Random();
        
        /// <summary>
        /// The method will shuffle the list from the external data
        /// by getting a random number and swapping the values position.
        /// </summary>
        /// <param name="n"></param>
        public static void Shuffling(this object n)
        {
            for(int i = 0; i < n.GetListNameCount() - 2; i++)
            {
                int j = GetRandomNumberBetweenZeroAnd((n.GetListNameCount() - i) - 1);
                n.SwapListValues(ListOfStringValue, i, i +j);
            }
        }

        /// <summary>
        /// An int method that returns a random number between the location 
        /// of int i plus a step above.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private static int GetRandomNumberBetweenZeroAnd(int i )
        {
            return rand.Next(i + 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYShuffleLibrary
{
    public static class Swapper
    {
        /// <summary>
        /// A method that swaps the values from the list to a different location.
        /// A temp object holds onto the first index i, i then changes its value
        /// from j, and j changes its value from temp.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void SwapListValues(this object n, List<String> list, int i, int j)
        {
            object temp = list[i];
            list[i] = list[j];
            list[j] = temp.ToString();
        }
    }
}

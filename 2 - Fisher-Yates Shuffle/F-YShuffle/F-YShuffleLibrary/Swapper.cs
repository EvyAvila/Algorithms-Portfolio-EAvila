using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_YShuffleLibrary
{
    public static class Swapper
    {
        public static void SwapValuesAtIndices(this object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_YShuffleLibrary
{
    public static class FYShuffler
    {
        private static Random randomNumber = new Random();

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            #region Original
            
            for (int i = objects.Length - 1; i > 0; i--)
            {
                //int j = GetRandomNumber(i); //randomNumber.Next(i + 1);
                int j = GetRandomNumberBetweenZeroAnd(i);
                objects.SwapValuesAtIndices(i, j);
                //object temp = objects[i];
                //objects[i] = objects[j];
                //objects[j] = temp;
            }
            #endregion
            #region Edit1
            /*
            int ilast = objects.Length - 1; //start from end of list
            while(ilast > 0) //loop the value if greater than 0
            {
                ilast = ShuffleArr(objects, ilast);// extracted into a method
            }*/
            #endregion
        }

        public static void DoFisherYatesAlternativeShuffle(this object[] objects)
        {
            for (int i = 0; i < objects.Length - 2; i++)
            {
                int j = GetRandomNumberBetweenZeroAnd((objects.Length - i)-1);
                objects.SwapValuesAtIndices(i, i + j);
            }
        }

        #region Edit2
        /*
        //Another refactor 
        private static int ShuffleArr(object[] objects, int ilast)
        {
            int i = GetRandomNumber(ilast); //still get random number
            Swap(objects, i, ilast); //swap method still called
            ilast--; //ilast moves down until 
            return ilast; //return the value
        }*/
        #endregion

        /*
        private static void Swap(object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }*/

        private static int GetRandomNumberBetweenZeroAnd(int i)
        {
            return randomNumber.Next(i + 1);
        }
    }
}

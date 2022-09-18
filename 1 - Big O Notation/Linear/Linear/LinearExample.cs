using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear
{
    public class LinearExample
    {
        /// <summary>
        /// The following code is a demonstration of Big O Notation O(n) or Linear
        /// A public void called PrintMetronomeMarkings contains a for loop that
        /// goes through the array and displays each element. Each time an element
        /// is added to an array, the amount of times it has to loop increases.
        /// In this example, there are 5 elements in the Metronome array. Thus,
        /// the method will loop 5 times.
        /// </summary>

        public int[] Metronome = {40, 60, 90, 120, 160 };

        public void PrintMetronomeMarkings(int[] metro)
        {
            Console.WriteLine("Metronome Markings:");
            for(int i = 0; i < metro.Length; i++)
            {
                Console.WriteLine("Common metronome markings: " + metro[i]);
            }
        }
    }
}

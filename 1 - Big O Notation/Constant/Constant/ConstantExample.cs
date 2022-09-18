using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    public class ConstantExample
    {
        /// <summary>
        /// The following code is a demonstration of Big O Notation O(1) or Constant
        /// A public void called PrintMusicComposerCatalogueName takes a string array
        /// and prints 1 element from the array. Regardless how big or small the array
        /// size is, the method only requires one step to complete.
        /// </summary>

        public string[] ComposerList = { "K", "BWV", "H", "M" };

        public void PrintMusicComposerCatalogueName(string[] composerlist)
        {
            Console.WriteLine("Composer Catalogue Name:");
            Console.WriteLine("A good music catalogue to look at is " + composerlist[0] + ".");
        }

    }
}

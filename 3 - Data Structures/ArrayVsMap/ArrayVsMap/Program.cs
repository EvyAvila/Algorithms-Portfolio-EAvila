using static System.Console;

namespace ArrayVsMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowExamples se = new ShowExamples();
            se.Show();
        }
    }

    /*
    How does each work?
    How are they different from each other?
    When is one more efficient than another?
     */

    /// <summary>
    /// Both array and dictionary follow the same format of setting the values 
    /// into their respected conntainment. However, how they implement and for
    /// what purpose is unique. For example, an array has a fixed and limited 
    /// set of data that can be inserted. If an element of data is removed, it can
    /// cause some errors of an empty memory. For map, or with the example of
    /// dictionary, it stores key values pairs. The restrain with dictionary
    /// is no pairs are allowed to be identical. 
    /// 
    /// Each data structures have its ups and downs. An array wins with being
    /// able to contain dublicates in the containments. However, the array is
    /// created as an ordered list, which isn't required for dictionary. 
    /// Speaking of dictionary, while it doesn't have a general order, if 
    /// there is an element that is repeated, then there will be a collision
    /// of the same data. 
    /// 
    /// Both data structures have their preference for different circumstances. 
    /// An array is more efficient in ordered containment that doesn't use too
    /// much time, space, or memory since it contains a fixed size. It works
    /// well with small amounts of data. For dictionary, it can be used to search
    /// items easily as each pair is unique. 
    /// </summary>

    public class ShowExamples
    {
        ArrayExample arryexample = new ArrayExample();
        MapExample mapExample = new MapExample();

        public void Show()
        {
            Compare(arryexample, mapExample);
        }
        

        private void Compare(ArrayExample ae, MapExample me)
        {
            WriteLine("Array:");
            ReadKey();
            ae.DisplayArray();
            ResetScreen();
            WriteLine("Map/Dictionary:");
            ReadKey();
            me.DisplayDict();

        }

        private void ResetScreen()
        {
            ReadKey();
            Clear();
        }
    }

}
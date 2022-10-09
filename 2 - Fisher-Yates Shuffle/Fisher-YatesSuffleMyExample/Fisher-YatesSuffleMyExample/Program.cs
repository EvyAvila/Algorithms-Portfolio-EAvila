using FYShuffleLibrary;
using static FYShuffleLibrary.ExtractFile;

namespace Fisher_YatesSuffleMyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set the name of the file
            string name = "InstrumentList.txt";

            //name calls the appropriate methods for shuffling
            name.ReceiveFileName();
            name.ExtractingFileToList();
            name.Shuffling();

            //Display each index after it has been shuffled
            foreach(string n in ListOfStringValue)
            {
                Console.WriteLine(n);
            }
        }
    }
}
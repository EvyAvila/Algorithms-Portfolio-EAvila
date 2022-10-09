using F_YShuffleLibrary;

namespace F_YShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "A", "B", "C", "D", "E", };

            //letters.DoFisherYatesShuffle();

            letters.DoFisherYatesAlternativeShuffle();
            
            foreach(string letter in letters)
            {
                Console.WriteLine(letter + " ");
            }
        }
    }
}
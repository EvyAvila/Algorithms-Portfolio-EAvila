using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingExamples
{
    public class LinearSearch : ISearchComponent
    {
        /*
        Linear Search

        Description: Linear search sequentially checks each element of a data set. It's generally not 
        as efficient as other options unless the data is very small.

        Best case: O(1)
        Worst case: O(n)

        Pseudocode:
        Integer: linearSearch(Data: data, Interger: x)
            For i = 0 to <length of data> - 1
                if (data[i] == x)
                    return i
                EndIf
            Next i
            return 0
        End linearSearch

         */
        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        Random rand = new Random();

        public LinearSearch()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void DisplaySearchData()
        {
            SearchData();
        }

        public void SearchData()
        {
            int value = randomNumberGenerator();
            linear(ScoreData, value);
        }

        private int linear(List<string> data, int x)
        {
            for(int i = 0; i < data.Count-1; i++)
            {
                if (int.Parse(data[i]) == x)
                {
                    int show = i + 1;
                    Console.WriteLine(x + " is found using Linear search in position: " + show);
                    return i;
                }
            }
            return NotFound(x);
        }

        private int randomNumberGenerator()
        {
            int randomNumber = 0;
            foreach (var data in ScoreData)
            {
                randomNumber = rand.Next(int.Parse(data));
            }

            return randomNumber;
        }

        private int NotFound(int value)
        {
            Console.WriteLine($"Number {value} not found");
            return 0;
        }


    }
}

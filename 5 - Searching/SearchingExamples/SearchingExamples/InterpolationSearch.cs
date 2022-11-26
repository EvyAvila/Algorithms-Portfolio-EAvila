using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SearchingExamples
{
    public class InterpolationSearch : ISearchComponent
    {
        /*
        Interpolation Search

        Description: An improvement of Binary Search, Interpolation search uses keys. It can go
        to different locations according to the value of the key being searched. It requires the 
        data set to be sorted.

        Best case: O(log log n)
        Worst case: O(n)

        Pseudocode:
        Integer: interpolationSearch(Data: data, Integer: low, Integer: high, Interger: x)
            Integer: position
            
            if(low <= high && x >= data[low] && x <= data[high] )
                position = low + (((high - low) / (data[high] - data[low]) * (x - data[low])) )
                
                if(data[position] == x)
                    return position
                EndIf
                if(data[position] < x)
                    return interpolationSearch(data, position + 1, high, x)
                EndIf
                if(data[position] > x)
                    return interpolationSearch(data, low, position - 1, x)
                EndIf
            EndIf
            
            return 0
        End interpolationSearch

        */
        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        Random rand = new Random();
        QuickSort quickSort = new QuickSort();

        public InterpolationSearch()
        {
            ScoreData = new List<string>(GetExternalFile);
            quickSort.SortData();
        }

        public void DisplaySearchData()
        {
            ScoreData = quickSort.ScoreData;
            SearchData();
        }

        public void SearchData()
        {
            int value = randomNumberGenerator();
            interpolation(ScoreData, 0, ScoreData.Count-1, value);
        }

        private int interpolation(List<string> data, int low, int high, int x)
        {
            int position;

            if (low <= high && x >= int.Parse(data[low]) && x <= int.Parse(data[high]))
            {
                position = low + (((high - low) / (int.Parse(data[high]) - int.Parse(data[low])) * (x - int.Parse(data[low]))));

                if (int.Parse(data[position]) == x)
                {
                    int show = position + 1;
                    Console.WriteLine(x + " is found using Interpolation search in sorted position: " + show);
                   
                    return position;
                }

                if (int.Parse(data[position]) < x)
                {
                    return interpolation(data, position + 1, high, x);
                    
                }

                if (int.Parse(data[position]) > x)
                {
                    return interpolation(data, low, position - 1, x);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingExamples
{
    public class BinarySearch : ISearchComponent
    {
        /*
        Binary Search

        Description: Binary search compares the value in the middle of that data
        set to the value being searched for. if the values are equal, the target has 
        been found. If values are not equal, the algorithm determines which halft of
        the data set will contain the target. It requires the data set to be sorted.

        Best case: O(1)
        Worst case: O(log n)

        Pseudocode:
        Interger: binarySearch(Data: data, Integer: x)
            Integer: left = 0
            Integer: right = <length of data> - 1
            Integer: middle
            
            While (left <= right)
                middle = ((left + right) / 2 )
                if(data[middle] < x)
                    left = middle + 1
                else if(data[m] > x)
                    right = middle - 1
                else
                    return middle
                EndIf
            EndWhile
            
            return 0
        End binarySearch

         */
        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        Random rand = new Random();

        QuickSort quickSort = new QuickSort();

        public BinarySearch()
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
            binary(ScoreData, value);
        }

        private int binary(List<string> data, int x)
        {
            int left = 0;
            int right = data.Count-1;
            int m;

            while (left <= right)
            {
                m = ((left + right) / 2);
                if(int.Parse(data[m]) < x)
                {
                    left = m + 1;
                }
                else if(int.Parse(data[m]) > x)
                {
                    right = m - 1;
                }
                else
                {
                    int show = m + 1;
                    Console.WriteLine(x + " is found using Binary Search in sorted position: " + show);
                    return m;
                }
            }

            return NotFound( x );
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

    public class QuickSort
    {
        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        public QuickSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void SortData()
        {
            quickSort(ScoreData, 0, ScoreData.Count - 1);
        }

        public void quickSort(List<string> data, int low, int high)
        {
            if (low < high)
            {
                int piv = Position(data, low, high);

                quickSort(data, low, piv - 1);
                quickSort(data, piv + 1, high);
            }
        }

       
        private int Position(List<string> data, int low, int high)
        {
            int pivot = Int32.Parse(data[high]);
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (Int32.Parse(data[j]) < pivot)
                {
                    i++;
                    Swap(data, i, j);
                }
            }
            Swap(data, i + 1, high);
            return (i + 1);
        }

        private void Swap(List<string> data, int i, int j)
        {
            var temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}

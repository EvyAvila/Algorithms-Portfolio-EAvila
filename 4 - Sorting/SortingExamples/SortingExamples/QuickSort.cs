using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public class QuickSort : ISortComponents
    {
        /*
        Quick Sort

        Quick Sort is an comparison-based sort-in-place divide-and-conquer algorithm. An element is choosen
        from the containment to act as a "pivor". The pivot separates the containment into two parts, and each
        element in the subsection is compared to the pivot for sorting. Thus, it recursively calls itself
        on the subdivided sections until all elements are sorted

        Best case: O(n log n )
        Worst case: O(n^2)

        Pseudocode:
        Quicksort()
            quickSort(data, 0, <length of data> - 1)
        End Quicksort

        quickSort(Data: data, Integer: low, Integer: high)
            if(low < high)
                Integer: piv = Position(data, low, high);

                quickSort(data, low, piv - 1)
                quickSort(data, piv + 1, high)
            EndIf
        End quickSort

        Integer: Position(Data: data, Integer: low, Integer: high)
            Integer: pivot = data[high]
            Integer: i = (low - 1)

            For j = low To high - 1
                if(data[j] < pivot)
                    i++
                    Swap(data, i, j)
                EndIf
            Next j
            Swap(data, i + 1, high)

            return (i + 1)
        End Position

        Swap(Data: data, Integer: i, Integer: j)
            var temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        End Swap


        Time Completion: 0.67 millisecond average
         */

        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        public QuickSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }


        public void DisplaySortData()
        {
            Console.WriteLine("Quick Sort:");
            SortData();
            TimerCheck.TimerStop();

            /*
            for (int i = 0; i < ScoreData.Count; i++)
            {
                Console.WriteLine(ScoreData[i]);
                //Console.WriteLine($"{i + 1}) " + ScoreData[i]);
            }*/
        }

        public void SortData()
        {
            TimerCheck.TimerStart();
            quickSort(ScoreData, 0, ScoreData.Count - 1);   
        }

        public void quickSort(List<string> data, int low, int high)
        {
            if( low < high)
            {
                int piv = Position(data, low, high);

                quickSort(data, low, piv - 1);
                quickSort(data, piv + 1, high);
            }
        }

        //Based off: https://www.geeksforgeeks.org/quick-sort/
        private int Position(List<string> data, int low, int high)
        {
            int pivot = Int32.Parse(data[high]);
            int i = (low - 1);

            for(int j = low; j <= high - 1; j++)
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

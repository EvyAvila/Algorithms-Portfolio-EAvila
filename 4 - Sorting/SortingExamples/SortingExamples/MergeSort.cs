using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public class MergeSort : ISortComponents
    {
        /*
            Merge Sort
            
            Merge Sort is an algorithm that uses a divide-and-conquer strategy. Instead of picking a dividing item
            and splitting the items into two groups holding items that are larger and smaller than the dividing item, 
            it instead splits the itmes into two halves holding an equal number of items. It then recursively calls
            itself to sort the two halves. When the recursive calls, the algorithm merges the two sorted halves into
            a combined sorted list.

            Best case: O(n log n)
            Worst case: O(n log n)

            Pseudocode:
            Mergesort
                sortArray(data, 0, <length of data> - 1)
            End Mergesort

            Integer[]: sortArray(Interger[] array, Integer: left, Integer: right)
                if(left < right)
                    Integer: middle = left + (right - left) / 2
                    sortArray(array, left, middle)
                    sortArray(array, middle + 1, right)

                    MergeArray(array, left, middle, right)
                EndIf
                return array
            End sortArray

            MergeArray(Interger[]: array, Integer: left, Integer: middle, Integer: right)
                var leftArrayLength = middle - left + 1
                var rightArrayLength = right - middle
                var leftTempArray = new int[leftArrayLength]
                var rightTempArray = new int[rightArrayLength]
                Integer: i, j

                For i = 0 To leftArrayLength
                    leftTempArray[i] = array[left + i]
                Next i
                For j = 0 To rightArrayLength
                    rightTempArray[j] = array[middle + 1 + j]
                Next j

                i = 0
                j = 0
            
                Integer: k = left;

                While (i < leftArrayLength && j < rightArrayLength)
            
                    if (leftTempArray[i] <= rightTempArray[j])
                        array[k++] = leftTempArray[i++]
                    else
                        array[k++] = rightTempArray[j++]
                    EndIf
                EndWhile
            
                While (i < leftArrayLength)
                    array[k++] = leftTempArray[i++]
                EndWhile

                while (j < rightArrayLength)
                    array[k++] = rightTempArray[j++]
                EndWhile
            End MergeArray

            Time Completion: 72 millisecond average
             */

        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }
        int[] data = new int[474];

        public MergeSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void DisplaySortData()
        {
            Console.WriteLine("Merge Sort:");
            SortData();

            TimerCheck.TimerStop();
            /* 
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"{i+1}) " + data[i]);
            }*/
        }

        public void SortData()
        {
            TimerCheck.TimerStart();
            //Need to transfer data to use array instead of list
            for (int i = 0; i < GetExternalFile.Length; i++)
            {
                data[i] = Int32.Parse( GetExternalFile[i] );
            }
          
            sortArray(data, 0, data.Length - 1);
        }

        public int[] sortArray(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left) / 2;

                sortArray(array, left, middle);
                sortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }

            return array;
        }
        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

    }
}

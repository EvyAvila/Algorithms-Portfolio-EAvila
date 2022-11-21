using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public class SelectionSort : ISortComponents
    {
        /*
        Selection Sort

        Selection Sort is an in-place comparison sorting algorithm. It searches the data list for the
        argest input it contains and then add it to the end of the growing sorted list.

        Best case: O(n^2)
        Worst case: O(n^2)

        Pseudocode:
        Insertionsort()
            Integer: min
            For i = 0 To <length of data> - 1
                min = i
                For j = i + 1 To <length of data>
                    if(data[j] < data[min]
                        min = j
                    EndIf
                Next j
                if(min != i)
                    Integer: temp = data[min]
                    data[min] = data[i]
                    data[i] = temp
                EndIf
            Next i
        End insertionsort

        Time Completion: 4.67 millisecond average
         */

        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        public SelectionSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }
        public void DisplaySortData()
        {
            Console.WriteLine("Selection Sort:");
            SortData();

            TimerCheck.TimerStop();
            /*for (int i = 0; i < ScoreData.Count; i++)
            {
                Console.WriteLine(ScoreData[i]);
            }*/
        }

        public void SortData()
        {
            TimerCheck.TimerStart();
            int min;
            for(int i = 0; i < ScoreData.Count - 1; i++)
            {
                min = i;
                
                for(int j = i + 1; j < ScoreData.Count; j++)
                {
                    if (Int32.Parse(ScoreData[j]) < Int32.Parse(ScoreData[min]))  //checks to see if element is smaller than min value
                    {
                        min = j;
                    }
                }
                if(min != i) //if the min is not the same number, then swap positions
                {
                    int temp = Int32.Parse(ScoreData[min]);
                    ScoreData[min] = ScoreData[i];
                    ScoreData[i] = temp.ToString();
                }
                
            }
        }

        
    }
}

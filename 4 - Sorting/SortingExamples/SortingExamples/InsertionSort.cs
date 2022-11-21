using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public class InsertionSort : ISortComponents
    {
        /*
        Insertion Sort:

        Insertion Sort is a simple algorithm that builds the final sorted set one item at a time.

        Best case: O(n)
        Worst case: O(n^2)

        Pseudocode:
        Insertionsort()
            For i = 0 To <length of data> - 1
                For j = i + 1 To 0
                    If data[j] < data[j - 1]
                        var temp = data[j]
                        data[j] = data[j - 1]
                        data[j - 1] = temp
                    EndIf
                Next j
            Next i
        End Insertionsort

        Time Completion: 5 millisecond average
         */

        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        public InsertionSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void DisplaySortData()
        {
            Console.WriteLine("Insertion Sort:");
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
           for(int i = 0; i < ScoreData.Count-1; i++)
           {
                for(int j = i +1; j > 0; j--)
                {
                    if (Int32.Parse(ScoreData[j]) < Int32.Parse(ScoreData[j - 1])) //checking to see if the element value is smaller 
                    {
                        var temp = ScoreData[j];
                        ScoreData[j] = ScoreData[j - 1];
                        ScoreData[j - 1] = temp;
                    }
                }
           }
        }

       
    }
}

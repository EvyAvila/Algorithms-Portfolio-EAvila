using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public class BubbleSort : ISortComponents
    {
        /*
        Bubble Sort:

        Bubble Sort is an algorithm that starts at the beginning of the containment (array or list)
        and swaps the first two elements if the first element is greater than the second element. As 
        it moves to the next pair, the same comparison is made.

        Best case: O(n)
        Worst case: O(n^2)

        Pseudocode: 
        Bubblesort()
            Boolean: NotSorted = true
            While(NotSorted)
                NotSorted = false
                For i = <length of data> - 1 To 0
                    if(data[i] < data[i - 1]
                        var temp = data[i]
                        data[i] = data[i - 1]
                        data[i - 1] = temp
                        NotSorted = true;
                    EndIf
                Next i
            End While
        End Bubblesort  

        Time Completion: 13 millisecond average
        */
        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }

        public List<string> ScoreData { get; set; }

        public BubbleSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void DisplaySortData()
        {
            Console.WriteLine("Bubble Sort:");
            SortData();
            TimerCheck.TimerStop();
            
            /*
            for (int i = 0; i < ScoreData.Count; i++)
            {
                Console.WriteLine(ScoreData[i]);
            }*/
        }

        public void SortData()
        {
            TimerCheck.TimerStart();

            bool NotSorted = true; //assuming the data is not sorted
            while(NotSorted)
            {
                NotSorted = false;
                for (int i = ScoreData.Count - 1; i > 0; i--)
                {
                    if (Int32.Parse(ScoreData[i]) < Int32.Parse(ScoreData[i - 1])) //if the next element is smaller than the current element, begin swap
                    {
                        var temp = ScoreData[i];
                        ScoreData[i] = ScoreData[i - 1];
                        ScoreData[i - 1] = temp;
                        NotSorted = true;
                    }
                }
            }
        }

        /* Number sorts in descending order
                for (int i = 0; i < ScoreData.Count-1; i++)
                {
                   
                    if (Int32.Parse(ScoreData[i]) < Int32.Parse(ScoreData[i+1]))
                    {
                        var temp = ScoreData[i];
                        ScoreData[i] = ScoreData[i + 1];
                        ScoreData[i + 1] = temp;
                        NotSorted = true;
                    }
                }*/
    }

   

}

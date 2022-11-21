using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public class HeapSort : ISortComponents
    {
        /*
        Heap Sort

        Heap Sort is a comparison-based sort-in-place algorithm. It divides the data into sorted and 
        unsorted aras while maintaing the unsorted area in a heap data structure. That way, it allows
        the largest element in each step to be found more quickly.

        Best case: O(n log n)
        Worst case: O(n log n)

        Pseudocode:
        Heapsort()
            Heapify()
            For i = <length of data> - 1 To 0
                var temp = data[0]
                data[0] = data[i]
                data[i] = temp
                RemoveTopItem(i)
            Next i
        End Heapsort

        Heapify()
            For i = 0 To <length of data> - 1
                Integer: index = i
                While(index != 0)
                    Integer: parent = (index - 1) / 2
                    if (data[index] <= data[parent])
                        break
                    EndIf

                    var temp = data[index];
                    data[index] = data[parent];
                    data[parent] = temp;

                    index = parent
                EndWhile
            Next i
        End Heapify()

        RemoveTopItem(Integer: count)
            Integer: index = 0
            While(true)
                Integer: child1 = 2 * index + 1;
                Integer: child2 = 2 * index + 2;

                if(child1 >= count)
                    child1 = index
                EndIf
                if(child2 >= count)
                    child2 = index
                EndIf

                if( (data[index] >= data[child1]) && data[index] >= data[child2]  )
                    break
                EndIf

                Integer: swapChild
                if(data[child1] > data[child2]
                    swapChild = child1
                else
                    swapChild = child2
                Endif

                var temp = data[index]
                data[index] = data[swapChild]
                data[swapChild] = temp

                index = swapChild
            EndWhile
        End RemoveTopItem

        Time Completion: 0.67 millisecond average
         */

        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }


        public HeapSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void DisplaySortData()
        {
            Console.WriteLine("Heap Sort:");
            SortData();

            TimerCheck.TimerStop();
            /*
            for (int i = 0; i < ScoreData.Count; i++)
            {
                Console.WriteLine( ScoreData[i]);
                //Console.WriteLine($"{i + 1}) " + ScoreData[i]);
            }*/

        }

        public void SortData()
        {
            TimerCheck.TimerStart();
            Heapify();
            for (int i = ScoreData.Count - 1; i > 0; i--)
            {
                var temp = ScoreData[0];
                ScoreData[0] = ScoreData[i];
                ScoreData[i] = temp;

                RemoveTopItem(i);

            }
        }

        private void RemoveTopItem(int count)
        {
            int index = 0;
            while (true)
            {
                int child1 = 2 * index + 1;
                int child2 = 2 * index + 2;

                if (child1 >= count)
                {
                    child1 = index;
                }
                if (child2 >= count)
                {
                    child2 = index;
                }

                if ( (Int32.Parse(ScoreData[index]) >= Int32.Parse(ScoreData[child1]) )
                    && Int32.Parse(ScoreData[index]) >= Int32.Parse(ScoreData[child2]) )
                {
                    break;
                }

                int swapChild;
                if( Int32.Parse(ScoreData[child1]) > Int32.Parse(ScoreData[child2]) )
                {
                    swapChild = child1;
                }
                else
                {
                    swapChild = child2;
                }

                var temp = ScoreData[index];
                ScoreData[index] = ScoreData[swapChild];
                ScoreData[swapChild] = temp;

                index = swapChild;
            }
        }

        private void Heapify()
        {
            for (int i = 0; i < ScoreData.Count - 1; i++)
            {
                int index = i;
                while (index != 0)
                {
                    int parent = (index - 1) / 2;

                    if (Int32.Parse(ScoreData[index]) <= Int32.Parse(ScoreData[parent]))
                    {
                        break;
                    }

                    var temp = ScoreData[index];
                    ScoreData[index] = ScoreData[parent];
                    ScoreData[parent] = temp;

                    index = parent;
                }
            }

            
        }

       
    }
}

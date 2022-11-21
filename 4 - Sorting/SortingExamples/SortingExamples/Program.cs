namespace SortingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display sorting here
            BubbleSort bubble = new BubbleSort();
            InsertionSort insert = new InsertionSort();
            SelectionSort selection = new SelectionSort();
            HeapSort heap = new HeapSort();
            QuickSort quick = new QuickSort();
            MergeSort merge = new MergeSort();

            bubble.DisplaySortData();
            insert.DisplaySortData();
            selection.DisplaySortData();
            heap.DisplaySortData();
            quick.DisplaySortData();
            merge.DisplaySortData();
            
            Console.ReadKey();
        }

        
    }
}
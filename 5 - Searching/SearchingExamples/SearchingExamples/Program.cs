namespace SearchingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinearSearch linear = new LinearSearch();
            BinarySearch binary = new BinarySearch();
            InterpolationSearch interpolation = new InterpolationSearch();

            
            linear.DisplaySearchData();
            binary.DisplaySearchData();
            interpolation.DisplaySearchData();
           
        }
    }
}
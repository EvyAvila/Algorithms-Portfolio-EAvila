namespace Quadratic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuadraticExample qEx = new QuadraticExample();
            qEx.PrintTimeSignatures(qEx.TopNum, qEx.BottomNum);
        }
    }
}
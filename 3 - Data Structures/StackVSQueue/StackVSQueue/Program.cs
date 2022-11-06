using static System.Console;

namespace StackVSQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowExamples se = new ShowExamples();
            se.Show();

        }
    }

    /*
    How does each work?
    How are they different from each other?
    When is one more efficient than another?
     */

    /// <summary>
    /// Both stack and queue follow the same format of setting the values 
    /// into their respected conntainment. For stacks, to insert data they
    /// use a Push method while queues use an Enqueue method. Both operate
    /// the same, but have different names depending on which of the data
    /// structures is being used. 
    /// 
    /// Although similar, they are different in how they operate. For example, 
    /// stacks stores data in a Last-in, First-out order. Meaning, the last data 
    /// will be on top of the containment. For queues, they store data in a First-in, 
    /// First-out order. Meaning, the first data will be on top of the containment. 
    /// 
    /// They each have their advantage over the other over certain circumstances. 
    /// For example, stacks would be useful for getting the top of a shuffle deck 
    /// of cards, or wanting to look at the last entry. For queues, it can be useful 
    /// for a race to see who came first or going through submitted applications.
    /// </summary>

    public class ShowExamples
    {
        StackExample se = new StackExample();
        QueueExample qe = new QueueExample();
        
        public void Show()
        {
            Compare(se, qe);
        }

        private void Compare(StackExample s, QueueExample q)
        {
            WriteLine("Stack:");
            ReadKey();
            s.DisplayValue();
            ResetScreen();
            WriteLine("Queue:");
            ReadKey();
            q.DisplayValue();
        }

        private void ResetScreen()
        {
            ReadKey();
            Clear();
        }
    }

}
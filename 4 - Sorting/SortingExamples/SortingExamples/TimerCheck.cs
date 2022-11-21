using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace SortingExamples
{
    public class TimerCheck
    {
        public static System.Timers.Timer aTimer = new System.Timers.Timer(1000);

        static string startTime = String.Empty;
        static string endTime = String.Empty;

        public static void TimerStart()
        {
            aTimer.Enabled = true;
            aTimer.AutoReset = true;
            aTimer.Start();

            startTime = DateTime.Now.Millisecond.ToString();
            //Console.WriteLine("Start: {0:ss:fff}", DateTime.Now);
        }

        public static void TimerStop()
        {
            aTimer.Enabled = false;
            aTimer.Stop();
            
            endTime = DateTime.Now.Millisecond.ToString();
           
            int totalTimer = Int32.Parse(endTime) - Int32.Parse(startTime);
            //Console.WriteLine("Finished: {0:ss:fff}", DateTime.Now);

            Console.WriteLine("Completed sorting at: " + totalTimer + " milliseconds \n");
        }

        
    }
}

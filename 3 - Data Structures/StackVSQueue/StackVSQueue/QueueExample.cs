using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace StackVSQueue
{
    public class QueueExample
    {
        private static string FileName = "VideoGamesTitleList.txt";

        private string[] GetFile = File.ReadAllLines(FileName);

        public Queue VideoGameTitleQueue { get; private set; }

        public QueueExample()
        {
            VideoGameTitleQueue = new Queue();
            SetQueueValues();
        }

        void SetQueueValues()
        {
            for(int i = 0; i < GetFile.Length; i++)
            {
                VideoGameTitleQueue.Enqueue(GetFile[i]);
            }

            /* Showing an example of removing a certain section
            for (int j = 0; j < 20; j++)
            {
                VideoGameTitleQueue.Dequeue();
            }*/
            
        }

        public void DisplayQueue()
        {
            foreach(var queue in VideoGameTitleQueue)
            {
                Console.WriteLine(queue);
            }
        }
    }
}

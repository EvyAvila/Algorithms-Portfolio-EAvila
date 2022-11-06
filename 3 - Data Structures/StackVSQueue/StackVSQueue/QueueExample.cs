using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using ArrayVsMap;

namespace StackVSQueue
{
    public class QueueExample : IExampleComponents
    {
        public string ExternalFileName { get => "VideoGamesTitleList.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }

        public Queue VideoGameTitleQueue { get; private set; }

        public QueueExample()
        {
            VideoGameTitleQueue = new Queue();
            SetValue();
        }

        public void DisplayValue()
        {
            foreach (var queue in VideoGameTitleQueue)
            {
                Console.WriteLine(queue);
            }
        }

        public void SetValue()
        {
            for (int i = 0; i < GetExternalFile.Length; i++)
            {
                VideoGameTitleQueue.Enqueue(GetExternalFile[i]);
            }

            /* Showing an example of removing a certain section
            for (int j = 0; j < 20; j++)
            {
                VideoGameTitleQueue.Dequeue();
            }*/

        }
    }

}

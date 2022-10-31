using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackVSQueue
{
    public class StackExample
    {
        private static string FileName = "VideoGamesTitleList.txt";

        private string[] GetFile = File.ReadAllLines(FileName);

        public Stack VideoGameTitleStack { get; private set; }

        public StackExample()
        {
            VideoGameTitleStack = new Stack();
            SetStackValues();
        }

        

        void SetStackValues()
        {
            for (int i = 0; i < GetFile.Length; i++)
            {
                VideoGameTitleStack.Push(GetFile[i]);
                
            }

            /* Showing an example of removing a certain section
            for(int j = 0; j < 20; j++)
            {
                VideoGameTitleStack.Pop();
            }*/
        }

        public void DisplayStack()
        {

            foreach (var stack in VideoGameTitleStack)
            {
                Console.WriteLine(stack);
                
            }
        }
    }
}

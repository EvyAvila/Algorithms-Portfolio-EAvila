using ArrayVsMap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackVSQueue
{
    public class StackExample : IExampleComponents
    {
        public string ExternalFileName { get => "VideoGamesTitleList.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }

        public Stack VideoGameTitleStack { get; private set; }

        public StackExample()
        {
            VideoGameTitleStack = new Stack();
            SetValue();
        }

        public void DisplayValue()
        {
            foreach (var stack in VideoGameTitleStack)
            {
                Console.WriteLine(stack);
            }
        }

        public void SetValue()
        {
            for (int i = 0; i < GetExternalFile.Length; i++)
            {
                VideoGameTitleStack.Push(GetExternalFile[i]);
            }

            /* Showing an example of removing a certain section
            for(int j = 0; j < 20; j++)
            {
                VideoGameTitleStack.Pop();
            }*/
        }

    }

}

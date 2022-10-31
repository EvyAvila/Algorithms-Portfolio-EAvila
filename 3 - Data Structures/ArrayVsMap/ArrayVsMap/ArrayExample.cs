using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayVsMap
{
    public class ArrayExample
    {
        private static string FileName = "VideoGamesTitleList.txt";
        public string[] VideoGameTitleArray { get; private set; }

        private string[] GetFile = File.ReadAllLines(FileName);

        public ArrayExample()
        {
            VideoGameTitleArray = new string[GetFile.Length]; //needs to get the size to be even

            SetArrayValues();
        }

        void SetArrayValues()
        {
            for(int i = 0; i < GetFile.Length; i++)
            {
                VideoGameTitleArray[i] = GetFile[i];
            }
        }

        public void DisplayArray()
        {
            for (int i = 0; i < VideoGameTitleArray.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine(num + ") " + VideoGameTitleArray[i]);
            }
        }

    }

    
}

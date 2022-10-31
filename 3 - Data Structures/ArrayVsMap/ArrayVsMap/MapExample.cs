using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayVsMap
{
    public class MapExample
    {
        private static string FileName = "VideoGamesTitleList.txt";

        private string[] GetFile = File.ReadAllLines(FileName);

        //string is the data, and the int is the number in which they appear
        public Dictionary<string, int> VidoeGameTitleDic { get; private set; }

        public MapExample()
        {
            VidoeGameTitleDic = new Dictionary<string, int>();
            SetDictValues();
        }

        private void SetDictValues()
        {
            for(int i = 0; i < GetFile.Length; i++)
            {
                //Similar to a List, Dictionary adds new elements.
                VidoeGameTitleDic.Add(GetFile[i], i);
            }
        }

        public void DisplayDict()
        {
            foreach (var map in VidoeGameTitleDic)
            {
                Console.WriteLine(map);
            }
        }
    }
}

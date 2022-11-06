using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayVsMap
{
    public class MapExample : IExampleComponents
    {
        public string ExternalFileName { get => "VideoGamesTitleList.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }

        public Dictionary<string, int> VidoeGameTitleDic { get; private set; }

        public MapExample()
        {
            VidoeGameTitleDic = new Dictionary<string, int>();
            SetValue();
        }

        public void DisplayValue()
        {
            foreach (var map in VidoeGameTitleDic)
            {
                Console.WriteLine(map); 
            }
        }

        public void SetValue()
        {
            for (int i = 0; i < GetExternalFile.Length; i++)
            {
                //Similar to a List, Dictionary adds new elements.
                VidoeGameTitleDic.Add(GetExternalFile[i], i);
            }
        }
    }


}

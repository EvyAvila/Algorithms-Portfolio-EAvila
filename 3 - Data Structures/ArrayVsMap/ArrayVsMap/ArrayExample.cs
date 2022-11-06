using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayVsMap
{
    public class ArrayExample: IExampleComponents
    {
        public string ExternalFileName { get => "VideoGamesTitleList.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }

        public string[] VideoGameTitleArray { get; private set; }
        public ArrayExample()
        {
            VideoGameTitleArray = new string[GetExternalFile.Length]; //needs to get the size to be even
            SetValue();
        }

        public void DisplayValue()
        {
            for (int i = 0; i < VideoGameTitleArray.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine(num + ") " + VideoGameTitleArray[i]);
            }
        }

        public void SetValue()
        {
            for (int i = 0; i < GetExternalFile.Length; i++)
            {
                VideoGameTitleArray[i] = GetExternalFile[i];
            }
        }
    }

}

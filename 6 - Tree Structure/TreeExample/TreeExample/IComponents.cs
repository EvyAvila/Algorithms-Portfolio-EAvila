using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExample
{
    public interface IComponents
    {

        public string ExternalFileName { get; set; } //Get the name of the external file

        public string[] GetExternalFile { get; set; } //Setting the External file name into the containment

        public List<string> ScoreData { get; set; } //A containment list to hold the score data

    }

    //Using Quick Sort
    public class QuickSort : IComponents
    {
        public string ExternalFileName { get => "scores.txt"; set => ExternalFileName = value; }
        public string[] GetExternalFile { get => File.ReadAllLines(ExternalFileName); set { } }
        public List<string> ScoreData { get; set; }

        public QuickSort()
        {
            ScoreData = new List<string>(GetExternalFile);
        }

        public void SortData()
        {
            quickSort(ScoreData, 0, ScoreData.Count - 1);
        }

        public void quickSort(List<string> data, int low, int high)
        {
            if (low < high)
            {
                int piv = Position(data, low, high);

                quickSort(data, low, piv - 1);
                quickSort(data, piv + 1, high);
            }
        }


        private int Position(List<string> data, int low, int high)
        {
            int pivot = Int32.Parse(data[high]);
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (Int32.Parse(data[j]) < pivot)
                {
                    i++;
                    Swap(data, i, j);
                }
            }
            Swap(data, i + 1, high);
            return (i + 1);
        }

        private void Swap(List<string> data, int i, int j)
        {
            var temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}

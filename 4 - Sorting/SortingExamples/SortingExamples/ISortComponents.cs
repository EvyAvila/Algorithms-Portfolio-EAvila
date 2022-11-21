using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExamples
{
    public interface ISortComponents
    {

        public string ExternalFileName { get; set; } //Get the name of the external file

        public string[] GetExternalFile { get; set; } //Setting the External file name into the containment

        public List<string> ScoreData { get; set; } //A containment list to hold the score data

        public void SortData(); //A method to handle the sorting

        public void DisplaySortData(); //A method mainly used to display the sorted algorithm

    }
}

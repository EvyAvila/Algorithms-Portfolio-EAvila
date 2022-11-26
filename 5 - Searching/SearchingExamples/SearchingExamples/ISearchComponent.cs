using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingExamples
{
    public interface ISearchComponent
    {

        public string ExternalFileName { get; set; } //Get the name of the external file

        public string[] GetExternalFile { get; set; } //Setting the External file name into the containment

        public List<string> ScoreData { get; set; } //A containment list to hold the score data

        public void SearchData(); //A method to handle the search

        public void DisplaySearchData(); //A method mainly used to display the search algorithm

    }
}

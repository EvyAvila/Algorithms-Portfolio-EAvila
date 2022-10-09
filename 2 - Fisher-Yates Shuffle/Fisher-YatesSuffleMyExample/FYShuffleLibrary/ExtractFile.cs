using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYShuffleLibrary
{
    public static class ExtractFile
    {
        /// <summary>
        /// A string field that will get the name of the external data file name
        /// </summary>
        public static string GetFileName; 
        
        /// <summary>
        /// A string array that will read all the lines on the external data file
        /// </summary>
        private static string[] FileLines;

        /// <summary>
        /// Instead of using an array, I decided to use a list to hold my data as it's more flexible
        /// to add and remove values.  
        /// </summary>
        public static List<String> ListOfStringValue = new List<String>();

        /// <summary>
        /// The method gets the name of the file and sets it to the string GetFileName.
        /// Then, the array string FileLines will read all the lines from the string GetFileName.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ReceiveFileName(this object name)
        {
            GetFileName = name.ToString();
            FileLines = File.ReadAllLines(GetFileName);
            //ExtractingFileToList();
            return GetFileName;
        }

        /// <summary>
        /// This method extracts the components from the file and loops through 
        /// to add them to thelist ListOfStringValue
        /// </summary>
        /// <param name="name"></param>
        public static void ExtractingFileToList(this object name)
        {
            for(int i = 0; i < FileLines.Length; i++)
            {
                string lines = FileLines[i].ToString();

                ListOfStringValue.Add(lines);
            }
        }

        /// <summary>
        /// This method it mainly called for the Shuffler class to get the size
        /// count of the List for the purpose of shuffling
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GetListNameCount(this object n)
        {
            return ListOfStringValue.Count;
        }

        //This method was testing to make sure the whole list from
        //an external data was displayed
        /* 
        public static string DisplayAll(this object n)
        {
            string text = "";
            foreach(string line in StringList)
            {
                text += line + "\n";
            }
            return text;
        }*/


    }
}

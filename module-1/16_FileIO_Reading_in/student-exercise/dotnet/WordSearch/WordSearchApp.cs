using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Linq;

namespace WordSearch
{
    public class WordSearchApp
    {
        public void Run()
        {
            //1. Ask the user for the search string
            Console.WriteLine("Please input what you would like to search for");
            string searchPhrase = Console.ReadLine();
            Console.WriteLine("Should the search be case sensitive? Y/N");
            string caseSense = Console.ReadLine();


            //2. Ask the user for the file path
            Console.WriteLine();
            Console.WriteLine("Where is the file found?");
                string filePath = Console.ReadLine();

            //3. Open the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                int lineCounter = 0;
                
                //4. Loop through each line in the file
                while (!reader.EndOfStream)
                {
                    string line;
                    if (caseSense == "n" || caseSense == "N" || caseSense == "no" || caseSense == "No")
                    {
                        line = reader.ReadLine().ToLower();
                        //searchPhrase.toLower();  //trying to figure out how to specify case sensitivity.
                    }
                    else
                    {
                        line = reader.ReadLine();
                    }

                    //5. If the line contains the search string, print it out along with its line number
                    if (line.Contains(searchPhrase))
                    {
                        Console.WriteLine(lineCounter.ToString() + line);

                    }
                    lineCounter++;
                }
                
            }
            // See Part 2 in the Readme.md file for additional changes
        }
    }
}

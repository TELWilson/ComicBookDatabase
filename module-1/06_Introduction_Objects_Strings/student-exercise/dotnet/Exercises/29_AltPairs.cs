using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         AltPairs("kitten") → "kien"
         AltPairs("Chocolate") → "Chole"
         AltPairs("CodingHorror") → "Congrr"
         */
        public string AltPairs(string str)
        {
            // Split into chars
            string newString = "";
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            if (str.Length <= 1)
            {
                return str.Substring(0);
            }
            if (str.Length < 4)
            {
                return str.Substring(0, 2);
            }
            if (str.Length >= 4)
            {
                for (int i = 0; i < str.Length; i+= 4)
                {
                    if (i == str.Length - 1)
                    {
                        newString += str.Substring(i, 1);
                    }
                    else if (i <= str.Length-2)
                    {
                        newString += str.Substring(i, 1) + str.Substring(i + 1, 1);
                    }
                }
            }
            return newString;
        }
    }
}

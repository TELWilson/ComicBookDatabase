using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class RefactorMe
    {
        public string FrontTimes(string input, int timesToRepeat)
        {
            string resultString = "";
            // Maximum number of characters to repeat
            const int MaxCharacters = 3;


            for (int i = 0; i < timesToRepeat; i++)
            {
                //We need to worry about IndexOutOfRange with strings < maxCharacters long
                if (input.Length < MaxCharacters)
                {
                    resultString += input;
                }
                else
                {
                    resultString += input.Substring(0, MaxCharacters);
                }
                
            }
            return resultString;
        }
    }
}
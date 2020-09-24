﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> CharacterKey = new Dictionary<string, string>();

            foreach (string word in words)
            {
                string firstCharacter = "";
                string lastCharacter = "";



                firstCharacter = word.Substring(0, 1);
                lastCharacter = word.Substring(word.Length - 1, 1);
                CharacterKey[firstCharacter] = lastCharacter;

            }

            return CharacterKey;
        }
    }
}

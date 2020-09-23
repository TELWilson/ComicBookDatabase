﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a List of string, return a new list in reverse order of the original. One obvious solution is to
         simply loop through the original list in reverse order, but see if you can come up with an alternative
         solution. (Hint: Think LIFO (i.e. stack))
         ReverseList( ["purple", "green", "blue", "yellow", "green" ])  -> ["green", "yellow", "blue", "green", "purple" ]
         ReverseList( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"} )
            -> ["way", "the", "all", "jingle", "bells", "jingle", "bells", "jingle"]
         */
        public List<string> ReverseList(List<string> objectList)
        {

            // objectList.Reverse ();
            //return objectList
            Stack<string> newStack = new Stack<string>(); //create empty stack
           
            foreach (string value in objectList)  // separating strings to variables called values
            {
                newStack.Push(value);  // adding values to the new stack
            }

            return newStack.ToList();  // taking the stack back to a list.
        }

    }
}

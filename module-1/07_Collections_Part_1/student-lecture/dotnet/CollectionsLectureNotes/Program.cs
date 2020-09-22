using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Namespaces");
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.

            // Creating lists of integers
            List<int> yearsLived = new List<int>();
            // creates a new list
            // assigns it a location
            // assigns it a variable type

            // Creating lists of strings
            List<string> movies = new List<string>();
            List<string> favoriteMovies = new List<string>();
            List<string> otherMovies = movies;

            /////////////////

            // Discuss namespaces & using statements

            //////////////////
            // OBJECT EQUALITY
            //////////////////

            movies.Add("Hook");
            favoriteMovies.Add("Hook");

            // Check reference equality

            bool areMoviesEqual = movies == favoriteMovies;
            Console.WriteLine("Movies are equal == " + areMoviesEqual);

            // Compare two variables pointed at the same list

            
            if (otherMovies == movies)
            {
                Console.WriteLine("They be the same movies, yo!");
            }

            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            yearsLived.Add(2019);
            yearsLived.Add(2020);
            yearsLived.Add(2004);
            yearsLived.Insert(0, 1980);

            Console.WriteLine(yearsLived.Count);

            movies.Add("Sneakers");
            movies.Add("War Games");
            //movies.Add(1984);

            // ADDING MULTIPLE ITEMS
            int[] years = { 1990, 1991, 1992, 1993, 1994 };
            yearsLived.AddRange(years);


            // LIST INITIALIZER
            List<string> colors = new List<string>()
            {
                "Steel Blue",
                "Beige",
                "Transparent",
                "Dark Clear"
            };


            Console.WriteLine(yearsLived.Count);


            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            string warGames = movies[1];

            movies[0] = "The Sound of Music";

            Console.WriteLine(warGames);

            Console.WriteLine(movies);

            for(int i = 0; i < movies.Count; i++)
            {
                string m = movies[i];

                Console.WriteLine(m);
            }

            ///////////////////
            // ACCESSING WITH FOREACH
            ///////////////////

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);  // same as what starts at line 98
            }

            List<int> evenYears = new List<int>();
            foreach (int y in yearsLived)
            {
                if (y % 2 == 0)
                {
                    evenYears.Add(y);


                }

                foreach (int y in evenYears)
                {
                    Console.WriteLine(y);
                }
            }
            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////

            // Contains
            Console.WriteLine("Is movie present?" + movies.Contains("Sneakers"));
            // IndexOf

            // Insert

            // Remove

            // List to Array

            // Array to List

            ////////////////////////
            // SORT / REVERSE
            ////////////////////////



            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            // Enqueue

            // Loop through and Dequeue


            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 


            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 



            ////////////////////
            // POPPING THE STACK
            ////////////////////

            ////////////////////
            // SWITCH STATEMENTS
            ////////////////////
            ///
            bool timeForSwitchStatements = false;

            if (timeForSwitchStatements)
            {
                Console.WriteLine();

                string favoriteLanguage = "C#";

                switch (favoriteLanguage)
                {
                    case "C#":
                        Console.WriteLine("I love C#!");
                        break;

                    case "Java":
                        Console.WriteLine("Java is definitely a programming language");
                        break;

                    case "JavaScript":
                        Console.WriteLine("JavaScript is to Java as Carpet is to Car");
                        break;

                    default:
                        Console.WriteLine($"I don't have much to say about {favoriteLanguage}");
                        break;
                }

                // This is equivalent to the code below:
                if (favoriteLanguage == "C#")
                {
                    Console.WriteLine("I love C#!");
                }
                else if (favoriteLanguage == "Java")
                {
                    Console.WriteLine("Java is definitely a programming language");
                }
                else if (favoriteLanguage == "JavaScript")
                {
                    Console.WriteLine("JavaScript is to Java as Carpet is to Car");
                }
                else
                {
                    Console.WriteLine($"I don't have much to say about {favoriteLanguage}");
                }
            }

            Console.ReadLine();
        }
    }
}

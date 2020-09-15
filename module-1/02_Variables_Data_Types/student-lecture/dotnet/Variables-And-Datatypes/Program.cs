﻿using System;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("strings!");
          

            Console.WriteLine();

            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */

            int numberOfExercises = 26; //Created an int variable named number of exercises
            
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;

            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name = "TechElevator";

            Console.WriteLine(name);

            /*
            4a. Create a variable called seasonsOfFirefly and set it to 1.
            */

            int seasonsOfFirefly = 1; 

            Console.WriteLine(seasonsOfFirefly);

            /*
            4b. Create a variable called mattHasGivenUpHopeOnSeason2 and set it to false.
            */

            bool mattHasGivenUpHopeOnSeason2 = false;

            Console.WriteLine(mattHasGivenUpHopeOnSeason2);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */

            string myFavoriteLanguage = "C#";

            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */

            double pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */

            string myName = "Leslie Wilson";

            Console.WriteLine(myName);

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            int numberOfButtons = 4;

            Console.WriteLine(numberOfButtons);

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */

            double batteryDouble = 0.83;

            Console.WriteLine(batteryDouble);

            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */

            int difference = 121 - 27;
            Console.WriteLine(difference);

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */

            double sum = 12.3 + 32.1;
                Console.WriteLine(sum);

            /*
            12. Create a string that holds your full name.
            */

            string fullName = "Leslie Ann Wilson";

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */

            string message = "Hello, " + fullName;

            Console.WriteLine(message);

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */

            message = message + " Esquire";

            Console.WriteLine(message);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */

            message += " Esquire";

            Console.WriteLine(message);

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */

            string horrorMovie ="Saw";
            horrorMovie += " 2";

            Console.WriteLine(horrorMovie);

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            horrorMovie += 0;

                Console.WriteLine(horrorMovie);

            /*
            18. What is 4.4 divided by 2.2?
            */

            double result = 4.4 / 2.2;

            Console.WriteLine(result);


            /*
            19. What is 5.4 divided by 2?
            */



            /* Double math can be fun in .NET
            float a = 1.03f;
            float b = 0.42f;
            double c = a - b;
            Console.WriteLine("1.03 - 0.42 with mixed float and double = " + c);
            double g = 1.03;
            double h = 0.42;
            double i = g - h;
            Console.WriteLine("1.03 - 0.42 with all double = " + i);
            float j = 1.03f;
            float k = 0.42f;
            float l = j - k;
            Console.WriteLine("1.03 - 0.42 with all float = " + l);
            decimal m = 1.03M;
            decimal n = 0.42M;
            decimal o = m - n;
            Console.WriteLine("1.03 - 0.42 with all decimal = " + o);
            */

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */

            double divideResult = 5 / 2;
            Console.WriteLine(divideResult);


            /*
            21. What is 5.0 divided by 2?
            */

            divideResult = 5.0 / 2;

            Console.WriteLine(divideResult);


            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */

            double balance = 1234.56;
            Console.WriteLine(balance);


            /*
            23. If I divide 5 by 2, what's my remainder?
            */

            int remainder = 5 % 2;
            Console.WriteLine(remainder);

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */

            int three = 3;
            long billion = 1000000000;  //Long is a really big integer

            Console.WriteLine(three * billion);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */

            bool doneWithExercises = false;
            Console.WriteLine(doneWithExercises);

            /*
            26. Now set doneWithExercise to true.
            */

            bool doneWithExercises1 = true;
            Console.WriteLine(doneWithExercises1);

            string quote = "\"50% of all statistics online are Made Up\" - Abe Lincolon";
            Console.WriteLine(quote);

            // The program will stop here and wait for the user to press enter.
            Console.ReadLine(); 
        }
    }
}

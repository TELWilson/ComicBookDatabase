using System;

namespace DiscountCalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to .NET's Dicount Calculator Project");

            string author = "Cohort 12 .NET (CBUS)";

            Console.Write("This application was written by ");
            Console.Write(author);

            Console.WriteLine();

            Console.WriteLine(" We hope you like it!");

            Console.WriteLine();

            Console.WriteLine("Enter the discount percentage (without a % sign)");

            string discountText = Console.ReadLine();

            // For more learning, look into double.TryParse
            double discountPercent = double.Parse(discountText);

            discountPercent += 5;

            Console.WriteLine("Your discount is " + discountPercent);
            Console.WriteLine($"Your discount is {discountPercent} %");

            // Get prices from the user

            bool shouldExit = false;

            while (shouldExit == false)
            { 
            Console.WriteLine();
            Console.WriteLine("Please enter a series of prices separated by spaces or press Q to exit");

            string PriceText = Console.ReadLine();

                if (PriceText == "Q")
                {
                    shouldExit = true;
                }
                else
                {

                    string[] priceArray = PriceText.Split(" ");

                    for (int i = 0; i < priceArray.Length; i++)
                    {
                        double individualPrice = double.Parse(priceArray[i]);

                        double discountAmount = individualPrice * (discountPercent / 100);
                        double discountedPrice = individualPrice - (discountPercent / 100);

                        Console.WriteLine($" {individualPrice} is {discountedPrice} discounted.");
                    }

                }
            }

            Console.WriteLine("Thank you for using our awesome calculator.  May your prices be cheap");
        }

    }
}

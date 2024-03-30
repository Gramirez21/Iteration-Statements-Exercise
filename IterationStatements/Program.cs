using System.ComponentModel.Design;
using System.Diagnostics;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            PrintByThree();
            Console.WriteLine(TwoIntegers(2, 2));
            EvenOrOdd();
            PositiveOrNegative();
            CanYouVote();
            AreYouInRange();
            TimesTable();

        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool TwoIntegers(int number, int number2)
        {
            return number == number2;
        }

        public static void EvenOrOdd()
        {
            Console.Write("please enter a number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput}Number is even");
            }

            else
            {
                Console.WriteLine($"{userInput} is odd");
            }


        }

        public static void PositiveOrNegative()
        {
            Console.WriteLine("please enter a new number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > 0)
            {
                Console.WriteLine($"{userInput} is positive");
            }
            else
            {
                Console.WriteLine($"{userInput} is negative");
            }
            

        }

        public static void CanYouVote()
        {
            Console.WriteLine("Please enter your age");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput >= 18)
            {
                Console.WriteLine("You can legally vote");
            }
            else
            {
                Console.WriteLine("You can not legally vote");
            }
        }

        public static void AreYouInRange()
        {

            Console.WriteLine("Pick a number between -10 and 10");

            var userInput = int.Parse(Console.ReadLine());
            if (userInput <= 10 && userInput >= -10)
            {
                Console.WriteLine("You are in Range ");
            }
            else
            {
                Console.WriteLine("You are not in range");

            }


        }

        public static void TimesTable()
        {
            Console.WriteLine("Please enter a number");
            var userInput = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= 12)
            {
                Console.WriteLine(userInput * i);
                i++;
            }


        }


    }

}

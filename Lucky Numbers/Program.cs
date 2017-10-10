using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            beginning: 

            //User prompt and input
            Console.WriteLine("Welcome to the lucky number lottery! The current jackpot is $1,000,000!\nPress ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;

            Console.WriteLine("Please enter the lowest digit of your range.");
            int lowDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("Now enter the highest digit of your range.");
            int highDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("Now, please guess six numbers from within your range.");
            int[] luckyNumbers = new int[6];
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = int.Parse(Console.ReadLine());
            }

            //Some string/int declaration
            int jackpot = 1000000;
            double correct1 = (jackpot * .1667);
            double correct2 = (jackpot * .33);
            double correct3 = (jackpot * .5);
            double correct4 = (jackpot * .66);
            double correct5 = (jackpot * .83);
            string numberInputLow = "Please re-enter the lowest digit of your range.";
            string numberInputHigh = "Now, re-enter the highest digit of your range.";
            string numberEntry = "Finally, guess six lucky numbers from within your range!";
            string validNumber = "Please make sure the numbers you've entered are within your range";


            //Conditional regarding numbers below and above user defined range
                 if (luckyNumbers[0] < lowDigit | luckyNumbers[1] < lowDigit | luckyNumbers[2] < lowDigit |
                luckyNumbers[3] < lowDigit | luckyNumbers[4] < lowDigit | luckyNumbers[5] < lowDigit|
                luckyNumbers[0] > highDigit | luckyNumbers[1] > highDigit | luckyNumbers[2] > highDigit |
                luckyNumbers[3] > highDigit | luckyNumbers[4] > highDigit | luckyNumbers[5] > highDigit)
            {
                Console.WriteLine(validNumber);
                Console.WriteLine(numberInputLow);
                lowDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(numberInputHigh);
                highDigit = int.Parse(Console.ReadLine());
                Console.WriteLine(numberEntry);
                luckyNumbers = new int[6];

                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    luckyNumbers[i] = int.Parse(Console.ReadLine());
                }
            }



            //Random number generator
            Console.WriteLine("Press enter to reveal lucky numbers!");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;

            int score = 0;
            int Min = lowDigit;
            int Max = highDigit;
            int[] numbers = new int[6];

            Random randNum = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(Min, Max);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("Lucky number: " + number);
            }

            if (numbers == luckyNumbers)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Press ENTER to see your results!");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;


            //Compre answers w/ random numbers
            foreach (int number in numbers)
            {
                if (luckyNumbers.Contains(number))
                {
                   score++; 
                }
            }

            Console.WriteLine("You guessed " + score + " correctly!");
            if (score == 0)
            {
                Console.WriteLine("Sorry! You don't win anything...");
            }
            else if (score == 1)
            {
                Console.WriteLine("You win $" + correct1);
            }
            else if (score == 2)
            {
                Console.WriteLine("You win $" + correct2);
            }
            else if (score == 3)
            {
                Console.WriteLine("You win $" + correct3);
            }
            else if (score == 4)
            {
                Console.WriteLine("You win $" + correct4);
            }
            else if (score == 5)
            {
                Console.WriteLine("You win $" + correct5);
            }
            else if (score == 6)
            {
                Console.WriteLine("Congradulations! You win the $" + jackpot + " jackpot!");
            }
            Console.WriteLine("Press ENTER to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;

            //Play again sequence
            Console.WriteLine("Would you like to play again? [YES/NO]");
            string yesNo = Console.ReadLine().ToUpper();

            if (yesNo == "YES")
            {
                goto beginning;
            }
            else if (yesNo == "NO")
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);               
            }
        }
    }
}

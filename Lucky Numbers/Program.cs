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

            //User prompt and input
            Console.WriteLine("Welcome to the lucky number lottery! The current jackpot is $1,000,000!\nPress ENTER to continue.");
            Console.ReadKey();
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
            int[] score = new int[7];
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
            if (luckyNumbers[0] < lowDigit | luckyNumbers[0] > highDigit)
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
            else if (luckyNumbers[1] < lowDigit | luckyNumbers[1] > highDigit)
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
            else if (luckyNumbers[2] < lowDigit | luckyNumbers[2] > highDigit)
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
            else if (luckyNumbers[3] < lowDigit | luckyNumbers[3] > highDigit)
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
            else if (luckyNumbers[4] < lowDigit | luckyNumbers[4] > highDigit)
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
            else if (luckyNumbers[5] < lowDigit | luckyNumbers[5] > highDigit)
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
            Console.ReadKey();
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;

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

            if (Enumerable.SequenceEqual(numbers, luckyNumbers))
            {
                Console.WriteLine("Congradulations! You won the $1,000,000 JACKPOT!");
            }
            else if (numbers != luckyNumbers)
            {
                Console.WriteLine("YOU LOSE!");
            }


        }
    }
}

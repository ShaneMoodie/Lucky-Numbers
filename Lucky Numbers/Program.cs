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


            string numberInputLow = "Please re-enter the lowest digit of your range.";
            string numberInputHigh = "Now, re-enter the highest digit of your range.";
            string numberEntry = "Finally, guess six lucky numbers from within your range!";
            string validNumber = "Please make sure the numbers you've entered are within your range";

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

            Console.WriteLine("Press enter to reveal lucky numbers!");
            Console.ReadKey();

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
        }
    }
}

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

            Console.WriteLine("Now please enter the highest digit of your range.");
            int highDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("Next, guess six lucky numbers from your range!");
            int[] luckyNumbers = new int[6];

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = int.Parse(Console.ReadLine());
            }

            if (luckyNumbers > lowDigit | luckyNumbers < highDigit)
            {
                Console.WriteLine("Please enter a valid number from within your range.");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}

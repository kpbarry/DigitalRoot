using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("31337");
            DigitalRoot("8675309");

            Console.ReadKey();
        }
        static void DigitalRoot(string input)
        {
            /*
             * Needs recursion!! My function is kinda confusing @_@
             */

            //String array to store each number
            string[] firstNumbers = new string[input.Length];
            //Store sums for each time
            int firstSum = 0;
            int secondSum = 0;
            int thirdSum = 0;
            //Loop through characters in input to build firstNumbers array
            for (int i = 0; i < input.Length; i++)
            {
                //Building firstNumbers to match input
                firstNumbers[i] = input[i].ToString();
                //Add individual numbers together to get sum of input
                foreach (char c in firstNumbers[i])
                {
                    firstSum += Convert.ToInt32(firstNumbers[i]);
                }
            }

            //Print if 1 digit
            if (firstSum < 10)
            {
                Console.WriteLine("Digital root of " + input + ": " + firstSum);
            }
            //More than 1 digit long, so we want to keep going until it's not
            else if (firstSum > 10)
            {
                //Loop to build new number to add digits of
                for (int i = 0; i < firstSum.ToString().Length; i++)
                {
                    string secondString = firstSum.ToString();
                    string[] secondNumbers = new string[firstSum.ToString().Length];
                    secondNumbers[i] = secondString[i].ToString();

                    foreach (char c in secondNumbers[i])
                    {
                        secondSum += Convert.ToInt32(secondNumbers[i]);
                    }
                }
                if (secondSum < 10)
                {
                    Console.WriteLine("Digital root of " + input + ": " + secondSum);
                }
            }
            //1 + 0 = 1, if firstSum happens to be 10
            else if (firstSum == 10)
            {
                firstSum = 1;
            }

            //Go again if the number still sums to > 10
            if (secondSum > 10)
            {
                for (int i = 0; i < secondSum.ToString().Length; i++)
                {
                    string thirdString = secondSum.ToString();
                    string[] thirdNumbers = new string[secondSum.ToString().Length];
                    thirdNumbers[i] = thirdString[i].ToString();

                    foreach (char c in thirdNumbers[i])
                    {
                        thirdSum += Convert.ToInt32(thirdNumbers[i]);
                    }
                }
                Console.WriteLine("Digital root of " + input + ": " + thirdSum);
            }
            else if (secondSum == 10)
            {
                secondSum = 1;
            }
        }
    }
}

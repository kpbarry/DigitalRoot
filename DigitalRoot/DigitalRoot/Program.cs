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
            Console.ReadKey();
        }
        static void DigitalRoot(string input)
        {
            int x = int.Parse(input);
            int[] intArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                intArray[i] = int.Parse(numbers[i]);
            }
            //intList.Sum(x => x))
            //string inputArray = input.Split();
            //int[] intArray = new int[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    intArray[i] = int.Parse(input[i].ToString());
            //    Convert.ToInt32(intArray[i]);
            //    intArray[i] += intArray[i];
            //    Console.WriteLine(intArray[i]);
            //}
            
        }
    }
}

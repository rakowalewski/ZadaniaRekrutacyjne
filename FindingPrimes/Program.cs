using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPrimes
{
    class Program
    {
        static int[] readArray(string arrayValue)
        {
            string[] separators = { " " };
            string[] values = arrayValue.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[2];
            for (int i = 0; i < 2; i++)
            {
                array[i] = Convert.ToInt32(values[i]);
            }

            return array;
        }
        static int[] CreateRange(int[] inputValue)
        {
            int[] rangeArray = new int[inputValue[1]];
            for (int i = 0; i < inputValue[1]; i++)
            {
                rangeArray[i] = inputValue[0] + i;
            }
            return rangeArray;
        }
        static void FindPrime(int[] inputValue)
        {
            int temp = 0;
            for (int i = 0; i < inputValue.Length; i++)
            {
                bool prime = IsPrime(inputValue[i]);
                if (prime)
                {
                    temp++;
                }
            }
            Console.WriteLine(temp);

        }
        static bool IsPrime(int value)
        {
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i <= testCase; i++)
            {
                string userInput = Console.ReadLine();
                int[] inputValue = readArray(userInput);
                int[] rangeArray = CreateRange(inputValue);
                FindPrime(rangeArray);
            }
            
        }
    }
}

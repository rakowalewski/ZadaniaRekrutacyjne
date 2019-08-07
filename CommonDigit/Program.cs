using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonDigit
{
    class Program
    {
        static int[] Result(int[] array)
        {
            int[] arrayResult = new int[10];
            for (int a = 0; a < array.Length; a++)  
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (array[a] == i )
                    {
                        arrayResult[i]++;
                    }
                }
            }
            return arrayResult;

        }
        //static void printResult(int[] arrayResult)
        //{
        //    for (int i = 0; i < arrayResult.Length; i++)
        //    {
        //        Console.WriteLine("{0}:{1}",i, arrayResult[i]);
        //    }
        //}
        static void printDigit(int[] array)
        {
            int maxValue = array.Max();
            int index = array.ToList().IndexOf(maxValue);
            Console.Write(index+ " " );
        }
        static int[] readArray(string arrayValue, int size)
        {
            string[] separators = { " " };
            string[] values = arrayValue.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(values[i]);
            }

            return array;
        }

        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            string arrayInput = Console.ReadLine();
            int[] array = readArray(arrayInput, arraySize);
            int[] arrayResult = Result(array);
            //printResult(arrayResult);
            printDigit(arrayResult);
            Console.ReadLine();

        }
    }
}

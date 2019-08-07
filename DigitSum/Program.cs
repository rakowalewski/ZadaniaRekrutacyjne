using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitSum
{
    class Program
    {
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

        static int[] CreateSumArray(int[] inputArray, int size)
        {
            int[] sumArray = new int[size];
            for (int i = 0; i < inputArray.Length; i++)
            {
                char[] temp;
                int sum = 0;
                temp = inputArray[i].ToString().ToCharArray();
               
                for (int a = 0; a < temp.Length; a++)
                {
                    
                    string change = temp[a].ToString();
                   
                    sum += int.Parse(change);
                }
                sumArray[i] = sum;
            }
            return sumArray;
        }
        static int MaxSum(int[] sumArray)
        {
            int wynik = sumArray[0];
            int index = 0;
            for (int i = 1; i < sumArray.Length; i++)
            {
                if (wynik < sumArray[i])
                {
                    wynik = sumArray[i];
                }
            }
            index = Array.IndexOf(sumArray, wynik);
            return index;
        }

        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            string inputValues = Console.ReadLine();
            int[] inputArray = readArray(inputValues, sizeOfArray);
            int[] sumValues = CreateSumArray(inputArray, sizeOfArray);
            int index = MaxSum(sumValues);
            Console.WriteLine(index);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void revereseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
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
            int size = 0;
            size = Convert.ToInt32(Console.ReadLine());
            string arrayValue;
            arrayValue = Console.ReadLine();
            int[] arr = readArray(arrayValue, size);
            revereseArray(arr, 0, arr.Length - 1);
            printArray(arr, size);

            Console.ReadLine();
        }
    }
}

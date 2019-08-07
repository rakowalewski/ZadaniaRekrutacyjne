using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static Boolean arePermutations(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> hM = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                int x = arr1[i];
                if (!hM.ContainsKey(x))
                {
                    hM.Add(x, 1);
                }
                else
                {
                    int k = hM[x];
                    hM.Remove(x);
                    hM.Add(x, k + 1);
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                int x = arr2[i];

                if (!hM.ContainsKey(x))
                    return false;

                int k = hM[x];
                if (!hM.ContainsKey(x))
                    hM.Add(x, k - 1);
                else
                {
                    int a = hM[x];
                    hM.Remove(x);
                    hM.Add(x, a + 1);
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 5, 3, 7, 0, 7, 3, 5, 2, 1 };
            int[] arr2 = { 7, 3, 1, 2, 5, 0, 5, 2, 1, 3, 7 };

            if (arePermutations(arr1, arr2))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadLine();
        }
    }
}

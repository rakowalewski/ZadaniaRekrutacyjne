using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingPowers
{
    class Program
    {
        static bool IsPowerOfTwo(uint x)
        {
            return (x!=0)&&((x & (x - 1)) == 0);
        }

        static void Main(string[] args)
        {
            var numbers = new List<uint>();
            do
            {
               var result = uint.TryParse(Console.ReadLine(), out var value);
                if (!result)
                {
                    continue;
                }
                if (IsPowerOfTwo(value))
                {
                    numbers.Add(value);
                    numbers.Sort();
                }
                if (numbers.Count() == 0)
                {
                    Console.WriteLine("NA");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", numbers));
                }
            } while (true);
        }
    }
}

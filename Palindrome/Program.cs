using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string str)
        {
            var temp = str.ToLower();
            return temp.SequenceEqual(temp.Reverse());
        }
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            bool palindrome = IsPalindrome(sentence);
            if (palindrome == true)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
            Console.ReadLine();
        }
    }
}

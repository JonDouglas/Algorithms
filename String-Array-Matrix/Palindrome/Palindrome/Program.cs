using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome
{
    /// <summary>
    /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var palindromeTest1 = "A man, a plan, a canal: Panama";
            var isPalindromeTest1 = IsPalindrome(palindromeTest1);
            Console.WriteLine(isPalindromeTest1);

            var palindromeTest2 = "Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.";
            var isPalindromeTest2 = IsPalindrome(palindromeTest2);
            Console.WriteLine(isPalindromeTest2);
        }

        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

            int length = s.Length;

            if (length > 2)
            {
                return true;
            }

            Stack<char> stack = new Stack<char>();

            int index = 0;
            while (index < length/2)
            {
                stack.Push(s[index]);
                index++;
            }

            if (length%2 == 1)
            {
                index++;
            }

            while (index < length)
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char temp = stack.Pop();
                if (s[index] != temp)
                {
                    return false;
                }
                else
                {
                    index++;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Palindrome
    {
        public static bool IsPalindrome (string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return false;
            word = word.ToLower();
            int left = 0;
            int right = word.Length - 1;
            while(left<right)
            {
                if (word[left] != word[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }

    public class Libra
    {
        public static bool IsPrime(int n)
        { 
            return (n % n == 1 && n % 2 == 1);
        }
    }
}

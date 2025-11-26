using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class RomanInt
    {
        public static int RomanToInt(string s)
        {
            s = s.ToUpper();
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int value = 0;
                if (s[i] == 'I') value = 1;
                else if (s[i] == 'V') value = 5;
                else if (s[i] == 'X') value = 10;
                else if (s[i] == 'L') value = 50;
                else if (s[i] == 'C') value = 100;
                else if (s[i] == 'D') value = 500;
                else if (s[i] == 'M') value = 1000;
                if (i + 1 < s.Length)
                {
                    int nextValue = 0;
                    if (s[i + 1] == 'I') nextValue = 1;
                    else if (s[i + 1] == 'V') nextValue = 5;
                    else if (s[i + 1] == 'X') nextValue = 10;
                    else if (s[i + 1] == 'L') nextValue = 50;
                    else if (s[i + 1] == 'C') nextValue = 100;
                    else if (s[i + 1] == 'D') nextValue = 500;
                    else if (s[i + 1] == 'M') nextValue = 1000;
                    if (value < nextValue)
                    {
                        total -= value;
                        continue;
                    }
                }
                total += value;
            }
            return total;
        }
    }
}

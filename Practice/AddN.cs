using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class TwistedSum
    {
        public static long Solution(long n)
        {
            long result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i.ToString().Length == 1)
                {
                    result += i;
                }
                else
                {
                    foreach (char a in i.ToString())
                        result += (long)Char.GetNumericValue(a);
                }
            }
            return result;
        }
    }
}
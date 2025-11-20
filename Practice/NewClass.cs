using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class NewClass
    {
        public static int GetProduct(int a, int b)
        {
            return a * b;
        }
    }
    public class ReturnList
    {
        public static List <string> GetList(string a, string b, string c)
        {
           List <string> newStringList = new List <string> ();
            newStringList.Add (a);
            newStringList.Add (b);
            newStringList.Add (c);
            return newStringList;
        }
    }
    public class SecondOne
    {
        public static List <string> NewList(int a, int b, int c)
        {
            List <string> newString = new List <string> ();
            string newA = a.ToString();
            string newB = b.ToString();
            string newC = c.ToString();
            newString.Add(newA);
            newString.Add(newB);
            newString.Add(newC);
            return newString;
        }
    }
    public class ThirdOne
    {
        public static bool CheckOdd(string name)
        {
            return !(name.Length % 2 == 0);
        }
    }
    internal class FourthOne
    {
        public static int Bigger(int  a, int b)
        {
         return  a > b? a : b;
        }
    }
}

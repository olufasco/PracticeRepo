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
         List <int> intList = new List <int> ();
            intList.Add(a);
            intList.Add(b);
            int [] result = intList.ToArray();
            return result.Max();
        }
    }
    internal class Lmao
    {
        public static int NameLength(string fasco, char n)
        {
            Console.Write($"The index of {n} is: ");
            return fasco.Contains(n) ? fasco.IndexOf(n) : -2;
        }
    }
    internal class Friday
    {
        public static int A(int a)
        {
            return (a + 1);
        }
    }

    public class Today
    {
        public static List<int>AddTwoList(List<int> listOne, List<int> listTwo)
        {
            List<int> resultList = new List<int>();
            foreach (int num in listOne)
            {
                if(!resultList.Contains(num))
                    resultList.Add(num);
            }
            foreach(int num in listTwo)
            {
                if (!resultList.Contains(num))
                    resultList.Add(num);
            }
            return resultList;
        }

    }

    internal class Today2
    {
        public static List<int>AddTwoNewList(List<int>newListA, List<int> newListB)
        {
            var finalList = newListA.Union(newListB);
            return finalList.ToList();
        }
    }

    public class Today3
    {
        public static string CharString(List<char>newCharList)
        {
            return string.Join("", newCharList);
        }
    }
}

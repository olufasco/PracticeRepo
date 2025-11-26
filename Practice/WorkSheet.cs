namespace Practice
{
    class Fasco
    {
        public static bool CheckIfOdd(int num1, int num2, int num3)
        {
            return (num1 * num2 * num3) % 2 == 1;
        }
        public static char GetCharAtIndex(string name, int num)
        {
            if (num >= name.Length || num < 0)
            {
                return 'A';
            }
            else
            {
                return name[num];
            }
        }
    }
}
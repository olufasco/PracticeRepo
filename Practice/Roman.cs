using System;

public class Roman
{
    public static string IntToRoman(int n)
    {
     
        if (n < 1 || n > 3999)
        {
            return "number must be from 1 to 3999";
        }
        var mappings = new (int value, string symbol)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"), 
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var result = new System.Text.StringBuilder();

        foreach (var mapping in mappings)
        {
            while (n >= mapping.value)
            {
                result.Append(mapping.symbol);
                n -= mapping.value;
            }
        }

        return result.ToString(); 
    }
}

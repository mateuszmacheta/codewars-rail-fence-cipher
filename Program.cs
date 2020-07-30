using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    public static string Encode(string s, int n)
    {
        int sLen = s.Length;
        if (sLen == 0) { return null; }
        List<List<char>> encoder = new List<List<char>>();
        string outString = "";
        for (int i = 0; i < n; i++)
        {
            encoder.Add(new List<char>());
        }
        int step = 1; int pos = 0;
        for (int i = 0; pos < sLen; i += step)
        {
            encoder[i].Add(s[pos]);
            if (i == 0) { step = 1; }
            else if (i == n - 1) { step = -1; };
            pos++;
        }
        for (int i = 0; i < n; i++)
        {
            outString = outString + String.Join("", encoder[i]);
        }
        return outString;
    }

    public static string Decode(string s, int n)
    {
        // Your code here
        return null;
    }
    static void Main(string[] args)
    {
        string test = "Hello, World!";
        Console.WriteLine(test);
        Console.WriteLine(Encode(test, 3));
    }
}

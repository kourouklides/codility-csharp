using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        string binary = Convert.ToString(N, 2);
    
        string[] gaps = binary.Split('1');
    
        string biggestGap = "";
        for (int i = 0; i < (binary.EndsWith("1") ? gaps.Length : gaps.Length-1); i++)
        {
            if (gaps[i].Contains("0") && gaps[i].Length > biggestGap.Length )
            biggestGap = gaps[i];
    
        }
    
        return biggestGap.Length;
    }
}


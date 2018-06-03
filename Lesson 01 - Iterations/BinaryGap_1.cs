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
        
        string N_binary = Convert.ToString(N, 2);
    
        string[] gaps = N_binary.Split('1');
    
        string max_gap = "";
        int repetitions = (N_binary.EndsWith("1") ? gaps.Length : gaps.Length-1);
        for (int i = 0; i < repetitions; i++)
        {
            if (gaps[i].Contains("0") && gaps[i].Length > max_gap.Length )
            {
                max_gap = gaps[i];
            }
        }
    
        return max_gap.Length;
    }
}


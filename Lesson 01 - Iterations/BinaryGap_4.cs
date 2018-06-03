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
    
        int max_gap = 0;
        int current_gap = -1;
    
        for (int i = 1; i < N_binary.Length; i++)
        {
            if (N_binary[i-1] == '1' && N_binary[i] == '0')
            {
                current_gap = 1;
            }
            else if (N_binary[i - 1] == '0' && N_binary[i] == '0')
            {
                current_gap++;
            }
            else if (N_binary[i - 1] == '0' && N_binary[i] == '1')
            {
                max_gap = Math.Max(max_gap, current_gap);
            }
        }
        
        return max_gap;
    }
}


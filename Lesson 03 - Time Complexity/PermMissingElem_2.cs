using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        
        int N = A.Length + 1;
        int missing = N;
        
        for (int i=1; i < N; i++)
        {
            missing ^= A[i-1];
            missing ^= i;
        }
        
        return missing;
    }
}


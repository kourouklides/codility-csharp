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
        
        
        int N = A.Length;
        
        int sum1 = 0;
        int sum2 = 0;
        for (int i=0; i < N; i++)
        {
            sum1 += A[i];
            sum2 += i+1;
        }
        sum2 += N+1;
        
        int missing = sum2 - sum1;
        
        return missing;
    }
}


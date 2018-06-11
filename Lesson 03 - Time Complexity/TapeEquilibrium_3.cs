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
        int sum1 = A[0];
        int sum2 = A.Sum() - A[0];
        int min_diff = Math.Abs(sum1-sum2);
        
        for (int i=1; i<N-1; i++)
        {
            sum1 += A[i];
            sum2 -= A[i];
            min_diff = Math.Min(min_diff, Math.Abs(sum1-sum2));
        }
        
        return min_diff;
    }
}

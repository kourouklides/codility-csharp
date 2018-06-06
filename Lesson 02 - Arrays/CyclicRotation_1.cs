using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int n = A.Length;
        int[] B = new int[n];
        
        for (int i=0; i<n; i++)
        {
            B[(i + K) % n] = A[i];
        }
        
        return B;
    }
}

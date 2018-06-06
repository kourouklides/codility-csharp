using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int N = A.Length;
        
        if ((N==0) || (K==0) || (K==N))
        {
            return A;
        }
        
        int i;
        
        if (K > N)
        {
            i = K % N;
        }
        else
        {
            i = K;
        }
        
        var A1 = A.Skip(N-i).Take(i);
        var A2 = A.Skip(0).Take(N-i);
        
        int[] B = A1.Concat(A2).ToArray();
        
        return B;
    }
}

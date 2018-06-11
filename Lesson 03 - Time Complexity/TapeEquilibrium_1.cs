using System;
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
        
        int index1 = 0;
        int index2 = N-1;
        
        int sum1 = A[index1];
        int sum2 = A[index2];
        
        int sum1_next = sum1+A[index1+1];
        int sum2_next = sum2+A[index2-1];
        
        int diff = 0;
        
        while (index1 < index2)
        {   
            diff = Math.Abs(sum1-sum2);
            
            sum1_next = sum1+A[index1+1];
            sum2_next = sum2+A[index2-1];
            
            if ( Math.Abs(sum1 - sum2_next) > Math.Abs(sum1_next - sum2) )
            {
                index1++;
                sum1 += A[index1];
            }
            else
            {
                index2--;
                sum2 += A[index2];
            } 
        }
        
        return diff;
    }
}

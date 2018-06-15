using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int X, int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        int N = A.Length;
        
        bool [] isNotThere = new bool[X+1];
        
        for (int i = 0; i < isNotThere.Length; i++)
        {
            isNotThere[i] = true;
        }
        
        int counter =  0;
        
        for (int i=0; i<N; i++)
        {
            if ( ( A[i] <= X) && isNotThere[ A[i] ] )
            {
                isNotThere[A[i]] = false;
                counter++;
                
                if (counter == X)
                {
                    return i;
                }
            }
        }
        
        return -1;
    }
}


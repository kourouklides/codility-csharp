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
        
        int i = N;
        int max_gap = 0;
        int current_gap = -1;

        while (i > 0)
        {
            if (i % 2 != 0)
            {
               if(current_gap > max_gap)
               {
                    max_gap = current_gap;
               }
                current_gap = 0;
            }
            else if(current_gap >= 0)
            {
                 current_gap++;
            }
            
            i >>= 1;
            
            // i /= 2;
        }

        return max_gap;
    
    }
}


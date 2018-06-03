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
        int counter = 0;
        int result = 0;
        bool found_one = false;
        
        while (i > 0)
        {
            if ( (i & 1) == 1)
            {
                if (found_one == false)
                {
                    found_one = true;
                }
                else
                {
                    result = Math.Max(result, counter);
                }
                counter = 0;
            }
            else
            {
                counter++;
            }
            
            i >>= 1;
            
            // i /= 2;
            
        }
        
        return result;
    
    }
}


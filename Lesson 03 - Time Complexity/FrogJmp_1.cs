using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int X, int Y, int D)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        var num = (decimal) Y - X;
        var den = (decimal) D;
        var jumps = (int) Math.Ceiling( num/den );
        
        return jumps;
        
    }
}


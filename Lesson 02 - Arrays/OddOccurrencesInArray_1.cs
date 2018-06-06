using System;
using System.Linq;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        var uniqueInt = A.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToList();
        
        return uniqueInt[0];
    }
}


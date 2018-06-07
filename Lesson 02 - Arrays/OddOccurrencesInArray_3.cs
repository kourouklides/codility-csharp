using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        var dictionary = new Dictionary<int, int>();
        
        foreach (var number in A)
        {
        	if (!dictionary.ContainsKey(number))
        	{
        		dictionary.Add(number, 1);
        	}
        	else
        	{
        		dictionary[number] = 2;
        	}
        }
        
        int result = -1;
        
        foreach (var key in dictionary)
        	if (key.Value == 1)
        	{
        		result = key.Key;
        	}
        
        return result;
    }
}

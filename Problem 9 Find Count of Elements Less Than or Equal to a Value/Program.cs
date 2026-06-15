using System;
using System.Collections.Generic;

class Program
{
    static int CountLessThanOrEqual(SortedSet<int> set, int value)
    {
        return set.GetViewBetween(int.MinValue, value).Count;
    }

    static void Main()
    {
        SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine(CountLessThanOrEqual(set, 3)); 
    }
}

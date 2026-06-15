using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
        var range = set.GetViewBetween(2,4);
        SortedSet<int> result = new SortedSet<int>(set);
        result.ExceptWith(range);
        Console.WriteLine(string.Join(", ", result));
        Console.ReadKey();
    }
}

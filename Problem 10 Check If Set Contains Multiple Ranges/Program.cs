using System;
using System.Collections.Generic;
class Program
{
    static bool ContainsAllRanges(SortedSet<int> set, List<(int, int)> ranges)
    {
        foreach(var (low, high) in ranges)
        {
            var view = set.GetViewBetween(low, high);
            if (view.Count != high - low + 1)
                return false;
        }
        return true;
    }
    static void Main()
    {
        SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var ranges = new List<(int, int)> { (1, 2), (4, 9) };
        Console.WriteLine(ContainsAllRanges(set, ranges)); // Output: True
        Console.ReadKey();
    }
}

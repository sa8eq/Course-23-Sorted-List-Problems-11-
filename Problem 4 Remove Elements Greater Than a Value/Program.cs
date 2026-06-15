using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
        sortedSet = sortedSet.GetViewBetween(int.MinValue, 3);

        Console.WriteLine(string.Join(", ", sortedSet));
        Console.ReadKey();
    }
}


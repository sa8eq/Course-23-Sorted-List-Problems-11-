using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static int CountElementsGreaterThan(int value, SortedSet<int> nums)
    {
        int count = 0;
        foreach(int num in nums)
        {
            if (num > value)
                count++;
        }
        return count;
    }
    static void Main(string[] args)
    {
        SortedSet<int> nums = new SortedSet<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        Console.WriteLine(CountElementsGreaterThan(3, nums));

    }
}


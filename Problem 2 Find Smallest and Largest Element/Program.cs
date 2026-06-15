using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> nums = new SortedSet<int>(new[] { 4, 2, 5, 1, 3 });
        int min = nums.Min();
        int max = nums.Max();

        Console.WriteLine($"Largest In Sorted List Is: {max}");
        Console.WriteLine($"Smallest In Sorted List Is: {min}");

    }
}


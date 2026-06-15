using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> nums = new SortedSet<int>(new[] { 1, 2, 3, 4, 5 });
        nums.GetViewBetween(2, 4).Clear();
        Console.WriteLine(string.Join(", ", nums));
    }
}


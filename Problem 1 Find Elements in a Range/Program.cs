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
        SortedSet<int> view = nums.GetViewBetween(2,4);
        foreach (int i in view)
        {
            Console.WriteLine(i);
        }
    }
}


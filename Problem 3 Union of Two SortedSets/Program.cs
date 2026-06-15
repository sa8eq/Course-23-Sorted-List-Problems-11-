using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        SortedSet<int> set1 = new SortedSet<int>(new[] { 1, 2, 3 });
        SortedSet<int> set2 = new SortedSet<int>(new[] { 3, 4, 5 });
        set1.UnionWith(set2);
        Console.WriteLine($"Set1 United With Set2 Is: {string.Join(", ", set1)}");
    }
}


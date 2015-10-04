using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggerNumber
{
    static int GetMax(int a, int b)
    {
        int c = Math.Max(a, b);
        return c;
    }
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        int max = GetMax(first, second);
        Console.WriteLine(max);
    }
}

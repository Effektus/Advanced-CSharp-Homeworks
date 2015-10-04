using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        string twenty = input.Length > 20 ? new string(input.Take(20).ToArray()) : input;
        Console.WriteLine(twenty.PadRight(20, '*'));
    }
}


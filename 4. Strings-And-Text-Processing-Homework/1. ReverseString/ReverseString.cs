using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        string reverseText = new string(text.Reverse().ToArray());
        Console.WriteLine(reverseText);
    }
}


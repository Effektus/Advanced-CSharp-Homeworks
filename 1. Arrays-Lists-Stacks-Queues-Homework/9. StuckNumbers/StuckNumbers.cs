using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StuckNumbers
{
    static void Main(string[] args)
    {
        string numInput = Console.ReadLine();
        List<int> numbers = numInput.Split().Select(int.Parse).ToList();
        bool isResult = false;

        foreach (int a in numbers)
        {
            foreach (int b in numbers)
            {
                foreach (int c in numbers)
                {
                    foreach (int d in numbers)
                    {
                        if (a != b && a != c && a != d && b != c && b != d && c != d)
                        {
                            string leftSide = "" + a + b;
                            string rightSide = "" + c + d;
                            if (leftSide.Equals(rightSide))
                            {
                                isResult = true;
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                            }
                        }
                    }
                }
            }
        }
        if (!isResult)
        {
            Console.WriteLine("No");
        }
    }
}

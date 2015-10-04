using System;

class Disk
{
    static void Main()
    {
        Console.WriteLine("Please enter disk size:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter disk radius:");
        int radius = int.Parse(Console.ReadLine());
        int center = n / 2;

        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < n; column++)
            {
                double checkRadius = Math.Sqrt(Math.Pow(column - center, 2) + Math.Pow(row - center, 2));
                if (checkRadius <= radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');   
                }
            }
            Console.WriteLine();
        }
    }
}
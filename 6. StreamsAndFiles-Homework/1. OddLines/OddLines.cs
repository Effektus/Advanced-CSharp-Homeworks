using System;
using System.IO;

class OddLines
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("../../Streams-And-Files-Homework.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Odd Line {0}: {1}", lineNumber, line);
                }
                lineNumber ++;
                line = reader.ReadLine();
            }
        }

    }
}
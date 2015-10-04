using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../Streams-And-Files-Homework.txt");
        StreamWriter writer = new StreamWriter("../../Streams-And-Files-Homework-New.txt");

        using (reader)
        {
            using (writer)
            {
                int lineNumber = 1;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    writer.WriteLine($"{lineNumber}. {line}");
                    lineNumber++;
                }
            }
        }
    }
}
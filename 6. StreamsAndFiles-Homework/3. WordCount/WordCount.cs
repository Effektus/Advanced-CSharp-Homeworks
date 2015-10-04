using System.Collections.Generic;
using System.Linq;
using System.IO;

class WordCount
{
    static void Main()
    {
        StreamReader readWords = new StreamReader("words.txt");
        StreamReader readText = new StreamReader("text.txt");
        StreamWriter writeResult = new StreamWriter("result.txt");

        using (readWords)
        {
            using (readText)
            {
                using (writeResult)
                {
                    string text = readText.ReadToEnd();
                    SortedDictionary<int, string> sortResult = new SortedDictionary<int, string>();
                    List<string> result = new List<string>();
                    while (true)
                    {
                        int count = 0;
                        string line = readWords.ReadLine();

                        if (line == null)
                        {
                            foreach (var pair in sortResult)
                            {
                                result.Add($"{pair.Value} - {pair.Key}");
                            }
                            for (int i = result.Count - 1; i >= 0; i--)
                            {
                                writeResult.WriteLine(result[i]);
                            }
                            break;
                        }
                        string[] textToArr = text.Split(new[] { ' ', '.', ',', '-', '\r', '?', '!' }).ToArray();

                        for (int i = 0; i < textToArr.Length; i++)
                        {
                            if (line == textToArr[i].ToLower())
                            {
                                count++;
                            }
                        }
                        sortResult[count] = line;
                    }
                }
            }
        }
    }
}
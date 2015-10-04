using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Please enter the members of Array separated by space!");
        string values = Console.ReadLine();
        string[] items = values.Split(' ');
        int[] arr = new int[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            arr[i] = int.Parse(items[i]);
        }
        int temp;
        for (int p = 0; p <= arr.Length - 2; p++)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        foreach (int aa in arr)
        {
            Console.Write(aa + " ");
        }
        Console.Read();
    }
}
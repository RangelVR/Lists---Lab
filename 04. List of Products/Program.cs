using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> prodName = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                prodName.Add(product);
            }
            prodName.Sort();

            for (int i = 0; i <= prodName.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1}.{prodName[i]}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            nums.RemoveAll(x => x < 0); 
            nums.Reverse();

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
               
        }
    }
}

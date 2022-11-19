using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            nums.RemoveAll(x => x < 0);

            if (nums.Count > 0)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command.Contains("Add"))
                {
                    nums.Add(command[1]);
                }
                else if (command.Contains("Remove"))
                {
                    nums.Remove(command[1]);
                }
                else if (command.Contains("RemoveAt"))
                {
                    nums.RemoveAt(int.Parse(command[1]));
                }
                else if (command.Contains("Insert"))
                {
                    nums.Insert(int.Parse(command[2]), command[1]);
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

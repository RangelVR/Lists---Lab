using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arr = command.Split().ToArray();
                string mainComm = arr[0];

                switch (mainComm)
                {
                    case "Add":
                        int addNum = int.Parse(arr[1]);
                        nums.Add(addNum);
                        break;

                    case "Remove":
                        int remNum = int.Parse(arr[1]);
                        nums.Remove(remNum);
                        break;

                    case "RemoveAt":
                        int remAtIndex = int.Parse(arr[1]);
                        nums.RemoveAt(remAtIndex);
                        break;

                    case "Insert":
                        int insNum = int.Parse(arr[1]);
                        int atIndex = int.Parse(arr[2]);
                        nums.Insert(atIndex, insNum);
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
        
    }
}

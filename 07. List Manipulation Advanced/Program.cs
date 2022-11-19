using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Advansed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split().ToArray();
            bool chanches = false;

            while (command[0] != "end")
            {
                if (command.Contains("Add"))
                {
                    nums.Add(command[1]);
                    chanches = true;
                }
                else if (command.Contains("Remove"))
                {
                    nums.Remove(command[1]);
                    chanches = true;
                }
                else if (command.Contains("RemoveAt"))
                {
                    nums.RemoveAt(int.Parse(command[1]));
                    chanches = true;
                }
                else if (command.Contains("Insert"))
                {
                    nums.Insert(int.Parse(command[2]), command[1]);
                    chanches = true;
                }
                else if (command.Contains("Contains"))
                {
                    if (nums.Contains(command[1]))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command.Contains("PrintEven"))
                {
                    List<int> evenNums = nums.Select(int.Parse).ToList();
                    evenNums.RemoveAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", evenNums));
                }
                else if (command.Contains("PrintOdd"))
                {
                    List<int> oddNums = nums.Select(int.Parse).ToList();
                    oddNums.RemoveAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", oddNums));
                }
                else if (command.Contains("GetSum"))
                {
                    List<int> sumNums = nums.Select(int.Parse).ToList();
                    Console.WriteLine(sumNums.Sum());
                }
                else if (command.Contains("Filter"))
                {
                    int number = int.Parse(command[2]);
                    List<int> numbers = nums.Select(int.Parse).ToList();
                    switch (command[1])
                    {
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > number)));
                            break;
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < number)));
                            break;
                                case ">=":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= number)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= number)));
                            break;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }

            if (chanches)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
            
        }
    }
}

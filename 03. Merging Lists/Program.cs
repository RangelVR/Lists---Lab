using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> secondList = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> mergeList = new List<double>();

            if (secondList.Count > firstList.Count )
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    mergeList.Add(firstList[i]);
                    mergeList.Add(secondList[i]);
                }
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    mergeList.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    mergeList.Add(firstList[i]);
                    mergeList.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    mergeList.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergeList));
        }
    }
}

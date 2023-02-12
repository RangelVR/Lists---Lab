List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

int theSmallestOne = Math.Min(firstList.Count, secondList.Count);

for (int i = 0; i < theSmallestOne; i++)
{
    result.Add(firstList[i]); 
    result.Add(secondList[i]); 
}

if (firstList.Count > secondList.Count)
{
    result.AddRange(firstList.Skip(secondList.Count));
}
else if(secondList.Count > firstList.Count)
{
    result.AddRange(secondList.Skip(firstList.Count));
}

Console.WriteLine(string.Join(" ", result));

-------------------------------------------------------------------------------------
//List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
//List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
//List<int> mergedList = new List<int>();

//if (list1.Count > list2.Count)
//{
//    for (int i = 0; i < list2.Count; i++)
//    {
//        mergedList.Add(list1[i]);
//        mergedList.Add(list2[i]);
//    }
//    for (int i = list2.Count; i < list1.Count; i++)
//    {
//        mergedList.Add(list1[i]);
//    }
//}
//else
//{
//    for (int i = 0; i < list1.Count; i++)
//    {
//        mergedList.Add(list1[i]);
//        mergedList.Add(list2[i]);
//    }
//    for (int i = list1.Count; i < list2.Count; i++)
//    {
//        mergedList.Add(list2[i]);
//    }
//}
//Console.WriteLine(string.Join(" ", mergedList));

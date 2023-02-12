List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] currCommArr = command.Split().ToArray();

	switch (currCommArr[0])
	{
		case "Add":
            int numberToAdd = int.Parse(currCommArr[1]);
            list.Add(numberToAdd); 
            break;

        case "Remove":
            int numberToRemove = int.Parse(currCommArr[1]);
            list.Remove(numberToRemove);
            break;

        case "RemoveAt":
            int idexToRemove = int.Parse(currCommArr[1]);
            list.RemoveAt(idexToRemove);
            break;

        case "Insert":
            int number = int.Parse(currCommArr[1]);
            int index = int.Parse(currCommArr[2]);
            list.Insert(index, number);
            break;
    }
}

Console.WriteLine(string.Join(" ", list));

-----------------------------------------------------------------------
//List<string> nums = Console.ReadLine().Split().ToList();
//string[] command = Console.ReadLine().Split().ToArray();

//while (command[0] != "end")
//{
//    if (command.Contains("Add"))
//    {
//        nums.Add(command[1]);
//    }
//    else if (command.Contains("Remove"))
//    {
//        nums.Remove(command[1]);
//    }
//    else if (command.Contains("RemoveAt"))
//    {
//        nums.RemoveAt(int.Parse(command[1]));
//    }
//    else if (command.Contains("Insert"))
//    {
//        nums.Insert(int.Parse(command[2]), command[1]);
//    }
//    command = Console.ReadLine().Split().ToArray();
//}

//Console.WriteLine(string.Join(" ", nums));

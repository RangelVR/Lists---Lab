List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

bool isMadeChanges = false;
string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] currCommArr = command.Split().ToArray();

    switch (currCommArr[0])
    {
        case "Add":
            int numberToAdd = int.Parse(currCommArr[1]);
            list.Add(numberToAdd);
            isMadeChanges = true;
            break;

        case "Remove":
            int numberToRemove = int.Parse(currCommArr[1]);
            list.Remove(numberToRemove);
            isMadeChanges = true;
            break;

        case "RemoveAt":
            int idexToRemove = int.Parse(currCommArr[1]);
            list.RemoveAt(idexToRemove);
            isMadeChanges = true;
            break;

        case "Insert":
            int number = int.Parse(currCommArr[1]);
            int index = int.Parse(currCommArr[2]);
            list.Insert(index, number);
            isMadeChanges = true;
            break;

        case "Contains":
            IsTheNumberExist(list, currCommArr);
            break;

        case "PrintEven":
            Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0)));
            break;

        case "PrintOdd":
            Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0)));
            break;

        case "GetSum":
            Console.WriteLine(list.Sum());
            break;

        case "Filter":
            PrintAllFilteredNumbers(list, currCommArr);
            break;
    }
}

if (isMadeChanges)
{
    Console.WriteLine(string.Join(" ", list));
}



static void IsTheNumberExist(List<int> list, string[] currCommArr) 
{
    int number = int.Parse(currCommArr[1]);

    if (list.Contains(number))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No such number");
    }
}

static void PrintAllFilteredNumbers(List<int> list, string[] currCommArr)
{
    string condition = currCommArr[1];
    int number = int.Parse(currCommArr[2]);

    switch (condition)
    {
        case ">":
            Console.WriteLine(string.Join(" ", list.Where(x => x > number)));
            break;

        case "<":
            Console.WriteLine(string.Join(" ", list.Where(x => x < number)));
            break;

        case ">=":
            Console.WriteLine(string.Join(" ", list.Where(x => x >= number)));
            break;

        case "<=":
            Console.WriteLine(string.Join(" ", list.Where(x => x <= number)));
            break;
    }
}

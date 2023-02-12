
List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Where(x => x > 0)
                .Reverse()
                .ToList();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}

Console.WriteLine(string.Join(" ", numbers));


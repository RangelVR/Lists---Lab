List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = 0; i < input.Count - 1; i++)
{
    input[i] += input[input.Count - 1];
    input.RemoveAt(input.Count - 1);
}

Console.WriteLine(string.Join(" ", input));

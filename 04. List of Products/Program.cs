
int n = int.Parse(Console.ReadLine());
List<string> products = new List<string>();
string currProduct;

for (int i = 0; i < n; i++)
{
    products.Add(currProduct = Console.ReadLine());
}

products.Sort();

for (int k = 0; k < products.Count; k++)
{
    Console.WriteLine($"{k + 1}.{products[k]}");
}

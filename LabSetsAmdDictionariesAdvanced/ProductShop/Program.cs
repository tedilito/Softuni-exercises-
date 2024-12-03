string input;
Dictionary<string, Dictionary<string, double>> shopProducts = new Dictionary<string, Dictionary<string, double>>();
while ((input = Console.ReadLine()) != "Revision")
{
    string[] commands = input.Split(", ");
    string name = commands[0];
    string product = commands[1];
    double price = double.Parse(commands[2]);
    if (shopProducts.ContainsKey(name))
    {
        shopProducts[name].Add(product, price);
    }
    else
    {
        shopProducts.Add(name, new Dictionary<string, double>());


        shopProducts[name].Add(product, price);
    }
}
shopProducts = shopProducts.OrderBy(n => n.Key).ToDictionary(s => s.Key, s => s.Value); 
foreach (var (shop, products) in shopProducts)
{
    Console.WriteLine($"{shop}->");
    foreach (var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}
int numOfContinents = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();
for (int i = 0; i < numOfContinents; i++)
{
    string[] input = Console.ReadLine().Split();
    string continent = input[0];
    string country = input[1];
    string city = input[2];
    if (cities.ContainsKey(continent))
    {
        if (cities[continent].ContainsKey(country))
        {
            cities[continent][country].Add(city);
        }
        else
        {
            cities[continent].Add(country, new List<string>());
            cities[continent][country].Add(city);
        }
    }
    else
    {
        cities.Add(continent, new Dictionary<string, List<string>>());
        cities[continent].Add(country, new List<string>());
        cities[continent][country].Add(city);
    }

}

foreach (var (continent, country) in cities)
{
    Console.WriteLine($"{continent}:");
    foreach (var (countryName, city) in country)
    {
        Console.WriteLine($"{countryName} -> {string.Join(", ", city)}");
    }
}
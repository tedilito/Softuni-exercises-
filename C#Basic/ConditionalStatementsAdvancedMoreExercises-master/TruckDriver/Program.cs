string season = Console.ReadLine();
double km = double.Parse(Console.ReadLine());
double price = 0;

if (km <= 5000)
{
	switch (season)
	{
		case "Spring":
		case "Autumn":
            price = km * 0.75;
			break;
		case "Summer":
            price = km * 0.90;
			break;
		case "Winter":
            price = km * 1.05;
			break;
	}
}
else if (km > 5000 && km <= 10000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            price = km * 0.95;
            break;
        case "Summer":
            price = km * 1.10;
            break;
        case "Winter":
            price = km * 1.25;
            break;
    }
}
else if (km > 10000 && km <= 20000)
{
    price = km * 1.45;
}
price = price * 4;
price -= price * 0.1;
Console.WriteLine($"{price:f2}");
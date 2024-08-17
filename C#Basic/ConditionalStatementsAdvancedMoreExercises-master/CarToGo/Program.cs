double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string typeClass = string.Empty; //"Economy class", "Compact class" или "Luxury class"
string typeCar = string.Empty; // "Cabrio" или "Jeep"
double priceCar = 0;

if (budget <= 100)
{
    typeClass = "Economy class";

	switch (season)
	{
		case "Summer":
			typeCar = "Cabrio";
            priceCar = budget * 0.35;

            break;

		case "Winter":
			typeCar = "Jeep";
            priceCar = budget * 0.65;

        break; 

		default:
			break;
	}
}
else if (budget > 100 && budget <= 500)
{
	typeClass = "Compact class";
    switch (season)
    {
        case "Summer":
            typeCar = "Cabrio";
            priceCar = budget * 0.45;

            break;

        case "Winter":
            typeCar = "Jeep";
            priceCar = budget * 0.80;

            break;

        default:
            break;
    }

}
else if (budget > 500)
{
    typeClass = "Luxury class";
    typeCar = "Jeep";
    priceCar = budget * 0.9;

}
Console.WriteLine(typeClass);
Console.WriteLine($"{typeCar} - {priceCar:f2}");
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int countFisherMan = int.Parse(Console.ReadLine());
double priceBoat = 0;

switch (season)
{
	case "Spring":
		priceBoat += 3000;
		break;

	case "Summer":
	case "Autumn":
        priceBoat += 4200;
        break;
	
	case "Winter":
        priceBoat += 2600;
        break;
	
	default:
		break;
}
if (countFisherMan <= 6)
{
	priceBoat -= priceBoat * 0.1;
}
else if (countFisherMan >= 7 && countFisherMan <= 11)
{
    priceBoat -= priceBoat * 0.15;
}
else if(countFisherMan >= 12)
{
    priceBoat -= priceBoat * 0.25;
}

if (countFisherMan % 2 == 0 && season != "Autumn")
{
	priceBoat -= priceBoat * 0.05;
}

if (budget >= priceBoat)
{
	double moneyLeft = budget - priceBoat;
    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
}
else if (budget < priceBoat)
{
	double moneyNeeded = priceBoat - budget;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
}
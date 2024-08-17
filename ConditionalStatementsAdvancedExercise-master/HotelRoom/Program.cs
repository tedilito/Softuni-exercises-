string mounth = Console.ReadLine();
int countLayover = int.Parse(Console.ReadLine());
double priceStudio = 0;
double priceApart = 0;

switch (mounth)
{
	case "May":
	case "October":
		priceStudio = 50 * countLayover;
		priceApart = 65 * countLayover;
        if (countLayover > 14)
        {
            priceStudio -= priceStudio * 0.3;
        }
        else if ( countLayover > 7)
        {
            priceStudio -= priceStudio * 0.05;
        }
        
        break;

    case "June":
    case "September":
        priceStudio = 75.20 * countLayover;
        priceApart = 68.70 * countLayover;
         if (countLayover > 14)
        {
            priceStudio -= priceStudio * 0.2;
        }
        break;

    case "July":
    case "August":
        priceStudio = 76 * countLayover;
        priceApart = 77 * countLayover;
        break;
     
}
if (countLayover > 14)
{
    priceApart -= priceApart * 0.1;
}
Console.WriteLine($"Apartment: {priceApart:f2} lv.");
Console.WriteLine($"Studio: {priceStudio:f2} lv.");


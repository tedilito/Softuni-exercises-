

int timeStay = int.Parse(Console.ReadLine());
string PlaceType = Console.ReadLine();  
string rating = Console.ReadLine();

timeStay = timeStay - 1;

double finalPrice = 0;


switch (PlaceType)
{
	case "room for one person":
        finalPrice = timeStay * 18.00;
        break;

	case "apartment":
        if (timeStay < 10)
        {
            finalPrice = timeStay * 25.00;
            finalPrice -= finalPrice * 0.3;
        }
        else if (timeStay > 10 && timeStay <= 15)
        {
            finalPrice = timeStay * 25.00;
            finalPrice -= finalPrice * 0.35;
        }
        else
        {
            finalPrice = timeStay * 25.00;
            finalPrice -= finalPrice * 0.50;
        }
        break;

	case "president apartment":
        if (timeStay < 10)
        {
            finalPrice = timeStay * 35.00;
            finalPrice -= finalPrice * 0.1;
        }
        else if (timeStay > 10 && timeStay <= 15)
        {
            finalPrice = timeStay * 35.00;
            finalPrice -= finalPrice * 0.15;
        }
        else
        {
            finalPrice = timeStay * 35.00;
            finalPrice -= finalPrice * 0.20;
        }
        break;


	default:
		break;
}
switch (rating)
{
    case "positive":
        finalPrice += finalPrice * 0.25;
        break;

    case "negative":
        finalPrice -= finalPrice * 0.1;
        break;

    default:
        break;
}
Console.WriteLine($"{finalPrice:f2}");

int countJunior = int.Parse(Console.ReadLine());
int countSenior = int.Parse(Console.ReadLine());
string typeRoute = Console.ReadLine();
double priceJunior = 0;
double priceSenior = 0;

switch (typeRoute)
{
	case "trail":
		priceJunior = 5.50;
		priceSenior = 7;
		break;

	case "cross-country":
        priceJunior = 8;
        priceSenior = 9.50;
        if ((countJunior+countSenior) >= 50)
        {
            priceSenior -= priceSenior * 0.25;
            priceJunior -= priceJunior * 0.25;

        }
        break;

	case "downhill":
        priceJunior = 12.25;
        priceSenior = 13.75;
        break;

	case "road":
        priceJunior = 20;
        priceSenior = 21.50;
        break;

}
double totalPrice = (priceJunior * countJunior) + (priceSenior * countSenior);
totalPrice -= totalPrice * 0.05;
Console.WriteLine($"{totalPrice:f2}");
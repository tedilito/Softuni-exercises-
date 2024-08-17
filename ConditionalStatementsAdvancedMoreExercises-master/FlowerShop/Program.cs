int boughtChrysa = int.Parse(Console.ReadLine());
int boughtRose = int.Parse(Console.ReadLine());
int boughtTulip =  int.Parse(Console.ReadLine());
string season  = Console.ReadLine();
char holiday = char.Parse(Console.ReadLine());

double priceChrysa = 0;
double priceRose = 0;
double priceTulip = 0;



switch (season)
{
	case "Spring":
	case "Summer":
		priceChrysa = 2.00 * boughtChrysa;
		priceRose = 4.10 * boughtRose;
		priceTulip = 2.50 * boughtTulip;
       
        break;

	case "Autumn":
	case "Winter":
		priceChrysa = 3.75 * boughtChrysa;
		priceRose = 4.50 * boughtRose;
		priceTulip = 4.15 * boughtTulip;
      
        break;
}
double totalPrice = priceChrysa + priceRose + priceTulip;
switch (holiday)
{
	case 'Y':
		totalPrice += totalPrice  * 0.15;
     
        break;


	
}
if (season == "Spring")
{
    if (boughtTulip > 7)
    {
        totalPrice -= totalPrice * 0.05;
    }

}
else if (season == "Winter")
{
    if (boughtRose >= 10)
    {
        totalPrice -= totalPrice * 0.1;
    }
}

if (boughtRose + boughtTulip + boughtChrysa > 20)
{
    totalPrice -= totalPrice * 0.2;
}
totalPrice += 2;
Console.WriteLine($"{totalPrice:f2}" );


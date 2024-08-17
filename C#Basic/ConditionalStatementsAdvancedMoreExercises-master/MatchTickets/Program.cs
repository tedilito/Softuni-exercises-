double budget = double.Parse(Console.ReadLine());   
string category = Console.ReadLine(); //VIP or Normal
int group = int.Parse(Console.ReadLine());
double transport = 0;
double price = 0;


if (group >= 1 && group <= 4)
{
    transport = budget * 0.75;
}
else if (group >= 5 && group <= 9)
{
    transport = budget * 0.6;
}
else if (group >= 10 && group <= 24)
{
    transport = budget * 0.5;
}
else if (group >= 25 && group <= 49)
{
    transport = budget * 0.4;
}
else if (group >= 50)
{
    transport = budget * 0.25;
}
budget -= transport;
switch (category)
{

    case "VIP":
        double priceVIP = 499.99;
        price = priceVIP * group;
        if (price <= budget)
        {
            double moneyLeft = budget - price;
            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
        }
        else
        {
            double moneyNeeded = price - budget;
            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
        }
        break;

    case "Normal":
        double priceNorm = 249.99;
        price = priceNorm * group;
        if (price <= budget)
        {
            double moneyLeft = budget - price;
            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
        }
        else
        {
            double moneyNeeded = price - budget;
            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
        }
        break;

}
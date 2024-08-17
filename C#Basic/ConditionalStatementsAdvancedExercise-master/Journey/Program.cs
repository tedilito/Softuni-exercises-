double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine(); //Summer or Winter
string destination = string.Empty;
string accommodation = string.Empty;
double moneySpent = 0;


if (budget <= 100)
{
    destination = "Bulgaria";

    switch (season)
    {
        case "summer":
            moneySpent=(budget * 0.3);
            accommodation = "Camp";
            break;
        case "winter":
            moneySpent =(budget * 0.7);
            accommodation = "Hotel";
            break;
        
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";

    switch (season)
    {
        case "summer":
            moneySpent = (budget * 0.40);
            accommodation = "Camp";
            break;
        case "winter":
            moneySpent = (budget * 0.80);
            accommodation = "Hotel";
            break;

    }
}
else if (budget > 1000)
{
    destination = "Europe";
    moneySpent = (budget * 0.90);
    accommodation = "Hotel";
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{accommodation} - {moneySpent:f2}");


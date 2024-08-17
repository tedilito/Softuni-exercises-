double budget = double.Parse(Console.ReadLine());
string season =  Console.ReadLine(); //"Summer" и "Winter". 
string accomodation = string.Empty; // "Hotel", "Hut" или "Camp".
string location = string.Empty; // "Alaska" и "Morocco"
double price = 0;

if (budget <= 1000)
{
    accomodation = "Camp";
	switch (season)
	{
		case "Summer":
			location = "Alaska";
			price = budget * 0.65;
            break;

		case "Winter":
            location = "Morocco";
            price = budget * 0.45;
            break; 
	}
}
else if (budget > 1000 && budget <= 3000)
{
	accomodation = "Hut";
    switch (season)
    {
        case "Summer":
            location = "Alaska";
            price = budget * 0.80;
            break;

        case "Winter":
            location = "Morocco";
            price = budget * 0.60;
            break;
    }

}
else if (budget > 3000)
{
    accomodation = "Hotel";
    switch (season)
    {
        case "Summer":
            location = "Alaska";
            price = budget * 0.9;
            break;

        case "Winter":
            location = "Morocco";
            price = budget * 0.9;
            break;
    }
    
}
Console.WriteLine($"{location} - {accomodation} - {price:f2}");
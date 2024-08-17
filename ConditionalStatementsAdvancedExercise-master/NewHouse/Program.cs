string typeFlowers = Console.ReadLine(); //- "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
int countFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double priceRoses = 5 * countFlowers;
double priceDahlias = 3.80 * countFlowers;
double priceTulips = 2.80 * countFlowers;
double priceNarcissus = 3 * countFlowers;
double priceGladiolus = 2.50  * countFlowers;

switch (typeFlowers)
{
	case "Roses":
        if (countFlowers > 80)
        {
            priceRoses -= priceRoses * 0.1; 
        }

        if (budget >= priceRoses)
        {
            double sumLeft = budget - priceRoses;
            Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {sumLeft:f2} leva left.");
        }
        else
        {
            double neededSum = priceRoses - budget;
            Console.WriteLine($"Not enough money, you need {neededSum:f2} leva more.");
        }


        break;

	case "Dahlias":
        if (countFlowers > 90)
        {
            priceDahlias -= priceDahlias * 0.15;
        }
        if (budget >= priceDahlias)
        {
            double sumLeft = budget - priceDahlias;
            Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {sumLeft:f2} leva left.");
        }
        else
        {
            double neededSum = priceDahlias - budget;
            Console.WriteLine($"Not enough money, you need {neededSum:f2} leva more.");
        }
        break;

	case "Tulips":
        if (countFlowers > 80)
        {
               priceTulips -= priceTulips * 0.15;
        }
        if (budget >= priceTulips)
        {
            double sumLeft = budget - priceTulips;
            Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {sumLeft:f2} leva left.");
        }
        else
        {
            double neededSum = priceTulips - budget;
            Console.WriteLine($"Not enough money, you need {neededSum:f2} leva more.");
        }

        break;

	case "Narcissus":
        if (countFlowers < 120)
        {
            priceNarcissus += priceNarcissus * 0.15;
        }
        if (budget >= priceNarcissus)
        {
            double sumLeft = budget - priceNarcissus;
            Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {sumLeft:f2} leva left.");
        }
        else
        {
            double neededSum = priceNarcissus - budget;
            Console.WriteLine($"Not enough money, you need {neededSum:f2} leva more.");
        }

        break;

	case "Gladiolus":
        if (countFlowers < 80)
        {
            priceGladiolus += priceGladiolus * 0.20;
        }
        if (budget >= priceGladiolus)
        {
            double sumLeft = budget - priceGladiolus;
            Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {sumLeft:f2} leva left.");
        }
        else
        {
            double neededSum = priceGladiolus - budget;
            Console.WriteLine($"Not enough money, you need {neededSum:f2} leva more.");
        }
        break;
}

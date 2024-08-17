string typeCinema = Console.ReadLine();
int col = int.Parse(Console.ReadLine());
int row = int.Parse(Console.ReadLine());    

int seats = col * row;
double income = 0;
switch (typeCinema)
{
	case "Premiere":
		income = seats * 12.00;
		break;

	case "Normal":
		income = seats * 7.50;
		break;

	case "Discount":
		income = seats * 5.00;
		break;
       

    default:
		break;
}
Console.WriteLine("{0:f2} leva" , income);
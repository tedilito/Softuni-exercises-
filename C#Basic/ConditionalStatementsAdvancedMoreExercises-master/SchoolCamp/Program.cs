string season = Console.ReadLine();
string typeGroup = Console.ReadLine();
int countStudents = int.Parse(Console.ReadLine());
int timeStay  = int.Parse(Console.ReadLine());

double price = 0;
string sport = string.Empty;


switch (season)
{
    case "Winter":
        switch (typeGroup)
        {
            case "boys":
                sport = "Judo";
                price = timeStay * 9.60 * countStudents;
                break; 
            case "girls":
                price = timeStay * 9.60 * countStudents;
                sport = "Gymnastics";
                break;

            case "mixed":
                price = timeStay * 10 * countStudents;
                sport = "Ski";

                break;

        }
        break;

    case "Spring":
        switch (typeGroup)
        {
            case "boys":
                sport = "Tennis";
                price = timeStay * 7.20 * countStudents;
                break;

            case "girls":
                price = timeStay * 7.20 * countStudents;
                sport = "Athletics";
                break;

            case "mixed":
                price = timeStay * 9.50 * countStudents;
                sport = "Cycling";
                break;

        }
        break;

    case "Summer":
        switch (typeGroup)
        {
            case "boys":
                sport = "Football";
                price = timeStay * 15 * countStudents;
                break;

            case "girls":
                price = timeStay * 15 * countStudents;
                sport = "Volleyball";
                break;

            case "mixed":
                price = timeStay * 20 * countStudents       ;
                sport = "Swimming";
                break;

        }
        break;


}

if (countStudents >= 50)
{
    price -= price * 0.5;
}
else if (countStudents >= 20 && countStudents < 50)
{
    price -= price * 0.15;

}
else if (countStudents >= 10 && countStudents < 20)
{
    price -= price * 0.05;
}
Console.WriteLine($"{sport} {price:f2} lv.");

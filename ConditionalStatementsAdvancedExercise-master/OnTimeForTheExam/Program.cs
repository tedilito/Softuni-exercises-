using System.Diagnostics.Metrics;

int hourOfExam = int.Parse(Console.ReadLine());
int minutesOfExam = int.Parse(Console.ReadLine());
int hoursOfEntry = int.Parse(Console.ReadLine());
int minutesOfEntry = int.Parse(Console.ReadLine());

int minutesExam = hourOfExam * 60 + minutesOfExam;
int minutesEntry = hoursOfEntry * 60 + minutesOfEntry;
int difference = minutesEntry - minutesExam;

if (difference == 0 && difference >= - 30)
{
    Console.WriteLine("On time");
}
else if (difference > 0)
{
    Console.WriteLine("Late");
}
else if (difference < -30)
{
    Console.WriteLine("Early");
}

if (difference != 0)
{
    int minutes = Math.Abs(difference % 60);
    int hours = Math.Abs(difference / 60);

    if (difference < 0)
    {
        if (hours > 0)
        {
            Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
        }
        else
        {
            Console.WriteLine($"{minutes} minutes before the start");
        }


    }
    else
    {
        if (hours > 0)
        {
            Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
        }
        else
        {
            Console.WriteLine($"{minutes} minutes after the start");
        }
    }
}
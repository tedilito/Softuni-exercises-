using System.Text;

int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>();
string input;
int countCars = 0;
bool carHasPassed = false;
bool hasCrashed = false;
while ((input = Console.ReadLine()) != "END")
{

    if (input == "green")
    {
        int currentGreenLight = greenLight;
        while (queue.Count > 0 && currentGreenLight > 0)
        {
            string car = queue.Dequeue();
            if (car.Length <= currentGreenLight)
            {
                currentGreenLight -= car.Length;
                countCars++;
            }
            else
            {
                int remainingTime = currentGreenLight + freeWindow;
                if (car.Length <= remainingTime)
                {
                    countCars++;
                }
                else
                {
                    int hitIndex = remainingTime;
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[hitIndex]}.");
                    return;
                }
                break;
            }
        }


    }
    else
    {
        queue.Enqueue(input);
    }


    



}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{countCars} total cars passed the crossroads.");
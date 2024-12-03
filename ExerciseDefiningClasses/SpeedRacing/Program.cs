namespace SpeedRacing
{
    public class program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                Car currentCar = new Car(inputInfo[0], double.Parse(inputInfo[1]), double.Parse(inputInfo[2]));
               cars[inputInfo[0]] = currentCar;
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string carModel = commands[1];
                double amountOfKm = double.Parse(commands[2]);
                cars[carModel].canTravel(carModel, amountOfKm);

            }
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Travelleddistance} ");
            }
        }
    }
}
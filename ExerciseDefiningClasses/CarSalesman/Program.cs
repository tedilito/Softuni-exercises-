namespace CarSalesman
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);

                string displacement = "n/a";
                string efficiency = "n/a";

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int disp))
                    {
                        displacement = disp.ToString();
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    displacement = engineInfo[2];
                    efficiency = engineInfo[3];
                }

                Engine engine = new Engine(engineModel, enginePower, displacement, efficiency);
                engines[engineModel] = engine;
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                string engineModel = carInfo[1];

                string weight = "n/a";
                string color = "n/a";

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int carWeight))
                    {
                        weight = carWeight.ToString();
                    }
                    else
                    {
                        color = carInfo[2];
                    }
                }
                else if (carInfo.Length >= 4)
                {
                    weight = carInfo[2];
                    color = carInfo[3];
                }

                Car car = new Car(carModel, engines[engineModel], weight, color);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
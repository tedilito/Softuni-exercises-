namespace RawData
{
    public class program
    {
        public static void Main()
        {


            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string model = commands[0];

                int engineSpeed = int.Parse(commands[1]);
                int edginePower = int.Parse(commands[2]);
                Engine engine = new Engine(engineSpeed, edginePower);


                int cargoWeight = int.Parse(commands[3]);
                string cargotype = commands[4];
                Cargo cargo = new Cargo(cargotype, cargoWeight);


                double tirePressure1 = double.Parse(commands[5]);
                int tireAge1 = int.Parse(commands[6]);
                Tires tires = new Tires(tirePressure1, tireAge1);

                double tirePressure2 = double.Parse(commands[7]);
                int tireAge2 = int.Parse(commands[8]);
                Tires tires2 = new Tires(tirePressure2, tireAge2);

                double tirePressure3 = double.Parse(commands[9]);
                int tireAge3 = int.Parse(commands[10]);
                Tires tires3 = new Tires(tirePressure3, tireAge3);

                double tirePressure4 = double.Parse(commands[11]);
                int tireAge4 = int.Parse(commands[12]);
                Tires tires4 = new Tires(tirePressure4, tireAge4);



                List<Tires> tiresList = new List<Tires>();
                tiresList.Add(tires);
                tiresList.Add(tires2);
                tiresList.Add(tires3);
                tiresList.Add(tires4);

                Car currentCar = new Car(model, engine, cargo, tiresList);
                cars[i] = currentCar;
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "fragile" && item.Tires.Any(x => x.Pressure < 1))
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
            else
            {   
                foreach (var item in cars)
                {
                    if (item.Cargo.Type == "flammable" && item.Engine.Power > 250)
                    {
                        Console.WriteLine($"{item.Model}");
                    }
                }
            }
        }
    }
}
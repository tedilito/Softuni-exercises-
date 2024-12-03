using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>(Capacity);
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            return Vehicles.Remove(Vehicles.Where(x => x.VIN == vin).FirstOrDefault());
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            return Vehicles.OrderBy(x => x.Mileage).FirstOrDefault();

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

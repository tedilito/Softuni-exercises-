namespace DataCenter
{
    public class Server
    {
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int PowerUsage { get; set; }

        public Server(string serialNumber, string model, int capacity, int powerUsage)
        {
            this.SerialNumber = serialNumber;
            this.Model = model;
            this.Capacity = capacity;
            this.PowerUsage = powerUsage;

        }

        public override string ToString()
        {
            return $"Server {SerialNumber}: {Model}, {Capacity}TB, {PowerUsage}W";
        }
    }
}

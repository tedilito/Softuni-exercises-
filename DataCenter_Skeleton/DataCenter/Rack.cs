using System.Text;

namespace DataCenter
{
    public class Rack
    {
        public Rack(int slots)
        {
            Slots = slots;
            Servers = new List<Server>(Slots);
        }

        public int Slots { get; set; }
        public List<Server> Servers { get; set; }

        public int GetCount
        {
            get { return Servers.Count; }

        }

        public void AddServer(Server server)
        {
            if (Servers.Count < Slots)
            {
                if (!Servers.Any(x => x.SerialNumber == server.SerialNumber))
                {
                    Servers.Add(server);
                }

            }

            
        }

        public bool RemoveServer(string serialNumber)
        {
            if (Servers.Any(x => x.SerialNumber == serialNumber))
            {
                Servers.RemoveAll(x => x.SerialNumber == serialNumber);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetHighestPowerUsage()
        {
            
            return Servers.OrderByDescending(x => x.PowerUsage).FirstOrDefault().ToString();
        }

        public int GetTotalCapacity()
        {
            return Servers.Sum(x => x.Capacity);
        }

        public string DeviceManager()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} servers operating:");
            foreach (var server in Servers)
            {
                sb.AppendLine(server.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

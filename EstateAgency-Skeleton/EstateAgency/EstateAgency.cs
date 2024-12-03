using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            RealEstates = new List<RealEstate>();
        }

        public int Capacity { get; set; }
        public List<RealEstate> RealEstates { get; set; }
        public int Count => RealEstates.Count;


        public void AddRealEstate(RealEstate realEstate)
        {
            if (Count < Capacity && !RealEstates.Any(x => x.Address == realEstate.Address))
            {
                RealEstates.Add(realEstate);
            }
        }

        public bool RemoveRealEstate(string address)
        {
            return RealEstates.Remove(RealEstates.Where(x => x.Address == address).FirstOrDefault());
        }
        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return RealEstates.FindAll(x => x.PostalCode == postalCode);
        }
        public RealEstate GetCheapest()
        {
            return RealEstates.OrderBy(x => x.Price).FirstOrDefault();
        }

        public double GetLargest()
        {
            return RealEstates.OrderByDescending(x => x.Size).FirstOrDefault().Size;
        }

        public string EstateReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Real estates available:");
            foreach (var item in RealEstates)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim().TrimEnd();
        }
    }
}
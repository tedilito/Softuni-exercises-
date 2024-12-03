using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        private int capacity;
        public int Count => RealEstates.Count;
        public List<RealEstate> RealEstates { get; set; }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            RealEstates = new List<RealEstate>(capacity);
        }



        public bool AddRealEstate(RealEstate realEstate)
        {
            if (this.RealEstates.Any(r => r.Address == realEstate.Address))
            {
                return false;
            }
            if (Count < Capacity)
            {
                RealEstates.Add(realEstate);
                return true;
            }
            return false;
        }
        public bool RemoveRealEstate(string address)
        {
            RealEstate realEstate = RealEstates.FirstOrDefault(r => r.Address == address);
            if (realEstate != null)
            {
                RealEstates.Remove(realEstate);
                return true;
            }
            return false;
        }

        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return RealEstates.Where(x => x.PostalCode == postalCode).ToList();
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
            sb.AppendLine("Real estates available: ");
            foreach (var item in RealEstates)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

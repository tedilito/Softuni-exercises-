using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public int Capacity { get; set; }
        public double  Turnover { get; set; }   
        public List<Product> Stall { get; set; }

        public void AddProduct(Product product)
        {
            if (!Stall.Contains(product) && Stall.Count < Capacity)
            {
                Stall.Add(product);
            }
        }

        public bool RemoveProduct(string name)
        {
            return Stall.Remove(Stall.Where(x => x.Name == name).FirstOrDefault());
        }

        public string SellProduct(string name, double quantity)
        {
            if (Stall.Any(x => x.Name == name))
            {
                Product product = Stall.Where(x => x.Name == name).First();
                Turnover += product.Price * quantity;
                return $"{product.Name} - {product.Price * quantity:F2}$";
            }
            else
            {
                return "Product not found";
            }
        }
        public string GetMostExpensive()
        {
            return Stall.OrderByDescending(x => x.Price).FirstOrDefault().ToString();
        }

        public string CashReport()
        {
            return $"Total Turnover: {Turnover:F2}$";
        }
         
        public string PriceList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Groceries Price List:");
            foreach (var product in Stall)
            {
                sb.AppendLine(product.ToString());
            }
            return sb.ToString().Trim().TrimEnd();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>(storageCapacity);
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes { get; set; }
        public int Count { get { return Shoes.Count; } }


        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
            else
            {
                return "No more space in the storage room.";
            }
        }

        public int RemoveShoes(string Material)
        {
            int count = 0;
            foreach (var shoe in Shoes.Where(s => s.Material == Material))
            {
                
                count++;
            }
            Shoes.RemoveAll(s => s.Material == Material);
            return count;

        }

        public List<Shoe> GetShoesByType(string type)
        {
            return Shoes.Where(x => x.Type.ToLower() == type.ToLower()).ToList();
        }

        public Shoe GetShoeBySize(double size)
        {
            return Shoes.Where(s => s.Size == size).FirstOrDefault(); 
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            if (Shoes.Any(s => s.Size == size && s.Type == type))
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var shoe in Shoes.Where(s => s.Size == size && s.Type == type))
                {
                    sb.AppendLine(shoe.ToString());
            }
            }
            else
            {
                sb.AppendLine("No matches found!");
            }
            return sb.ToString().Trim().TrimEnd();
        }
    }
}

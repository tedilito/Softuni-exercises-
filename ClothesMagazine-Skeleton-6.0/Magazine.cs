using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>(capacity);
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }


        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            return Clothes.Remove(Clothes.Where(x => x.Color == color).FirstOrDefault());
        }

        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(x => x.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color)
        {
            return Clothes.Where(x => x.Color == color).FirstOrDefault();
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in Clothes.OrderBy(x => x.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}

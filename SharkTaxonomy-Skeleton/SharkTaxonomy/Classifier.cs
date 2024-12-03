using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>(capacity);
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount
        {
            get { return Species.Count; }
        }

        public void AddShark(Shark shark)
        {
            if (!Species.Any(x => x.Kind == shark.Kind) && Species.Count < Species.Capacity)
            {
                Species.Add(shark);
            }
          
        }
        public bool RemoveShark(string kind)
        {
            if (Species.Any(x => x.Kind == kind))
            {
                Species.RemoveAll(x => x.Kind == kind);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetLargestShark()
        {
            return Species.OrderByDescending(x => x.Length).FirstOrDefault().ToString();
        }

        public double GetAverageLength()
        {
            return Species.Average(x => x.Length);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (var shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

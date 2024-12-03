using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public List<Renovator> Renovators { get; set; }


        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }


        public int Count
        {
            get { return Renovators.Count; }
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            else if (NeededRenovators <= Renovators.Count)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                Renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }


        public bool RemoveRenovator(string name)
        {
            return Renovators.Remove(Renovators.Where(x => x.Name == name).FirstOrDefault());
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            return Renovators.RemoveAll(x => x.Type == type);
        }

        public Renovator HireRenovator(string name)
        {
            if (Renovators.Any(x => x.Name == name))
            {
                Renovator renovator  = Renovators.Where(x => x.Name == name).First();
                renovator.Hired = true;
                return renovator;
            }
            return null;
        }
        public List<Renovator> PayRenovators(int days)
        {
            return Renovators.Where(x => x.Days >= days).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in Renovators.Where(x => x.Hired == false))
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString().Trim().TrimEnd();
        }

    }


}

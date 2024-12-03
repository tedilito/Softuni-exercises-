using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }


        public int ChildrenCount
        {
            get { return Registry.Count; }
            private set { ChildrenCount = value; }
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string ChildFullName)
        {
            string firstName = ChildFullName.Split(" ")[0].ToString();
            string lastName = ChildFullName.Split(" ")[1].ToString();
            return Registry.Remove(Registry.Where(x => x.LastName == lastName && x.FirstName == firstName).FirstOrDefault());
        }

        public Child GetChild(string childFullName)
        {
            string firstName = childFullName.Split(" ")[0].ToString();
            string lastName = childFullName.Split(" ")[1].ToString();
            if (Registry.Any(x => x.LastName == lastName && x.FirstName == firstName))
            {
                return Registry.Where(x => x.LastName == lastName && x.FirstName == firstName).FirstOrDefault();
            }
            return null;
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var child in Registry
       .OrderBy(x => x.LastName)
       .ThenBy(x => x.FirstName))
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}


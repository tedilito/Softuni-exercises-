using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child> (capacity);
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount =>  Registry.Count;

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add (child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] childName = childFullName.Split();
            return Registry.Remove(Registry.Where(x => x.FirstName == childName[0].ToString() && x.LastName == childName[1].ToString()).FirstOrDefault());
        }

        public Child GetChild(string childFullName)
        {
            string[] childName = childFullName.Split();
            if (Registry.Any(x => x.FirstName == childName[0].ToString() && x.LastName == childName[1].ToString()))
            {
                return Registry.Where(x => x.FirstName == childName[0].ToString() && x.LastName == childName[1].ToString()).First();
            }
            else
            {
                return null;
            }
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (Child child in Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName))
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().Trim().TrimEnd();
        }

    }
}

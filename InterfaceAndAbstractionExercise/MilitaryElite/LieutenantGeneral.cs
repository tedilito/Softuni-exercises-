using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class LieutenantGeneral : ILieutenantGeneral
    {
       

        public LieutenantGeneral( string id, string firstName, string lastName, decimal salary, IEnumerable<IPrivate> collection)
        {
            
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Privates = collection.ToList();
           
        }

        public decimal Salary { get; }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public List<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (IPrivate priv in Privates)
            {
                sb.AppendLine(priv.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}

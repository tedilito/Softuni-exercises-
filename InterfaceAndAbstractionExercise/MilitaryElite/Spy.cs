using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Spy : ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CodeNumber = codeNumber;
        }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public int CodeNumber { get; }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.AppendLine($"Code Number: {this.CodeNumber}");
            return sb.ToString().TrimEnd();
        }

    }
}

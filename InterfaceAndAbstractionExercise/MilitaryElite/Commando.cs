using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Commando : ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, Dictionary<string, string> codeNameByState)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;
            CodeNameByState = codeNameByState;
        }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public decimal Salary { get; }

        public string Corps { get; }

        public Dictionary<string, string> CodeNameByState { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Missions:");
            foreach (var mission in CodeNameByState)
            {
                sb.AppendLine($"Code Name: {mission.Key} State: {mission.Value}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

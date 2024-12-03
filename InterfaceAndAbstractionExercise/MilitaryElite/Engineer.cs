using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public class Engineer : IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps,  Dictionary<string, string> repairByHours)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            RepairsByHours = new Dictionary<string, string>();
            RepairsByHours = repairByHours;
            HoursWorked = GetHoutsWorked(RepairsByHours);
        }

        private int GetHoutsWorked(Dictionary<string, string> repairsByHours)
        {
            int hoursWorked = 0;
            foreach (var item in repairsByHours)
            {
                hoursWorked += int.Parse(item.Value);
               
            }
            return hoursWorked;
        }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public decimal Salary { get; }

        public string Corps { get; }

        public Dictionary<string, string> RepairsByHours { get; set; }

        public int HoursWorked { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");
            foreach (var part in RepairsByHours)
            {
                sb.AppendLine($"Part Name: {part.Key} Hours Worked: {part.Value}");
            }
            return sb.ToString().TrimEnd();
        }


    }
}

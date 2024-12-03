using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
		private string name;
		private List<Person> firstTeam;
		private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
			firstTeam = new List<Person>();
			reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> ReserveTeam
		{
			get { return reserveTeam.AsReadOnly(); }
			
		}

		public IReadOnlyCollection<Person> FirstTeam
		{
			get { return firstTeam.AsReadOnly(); }
			
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void AddPlayer(Person person)
		{
            if (person.Age < 40)
            {
				firstTeam.Add(person);
            }
			else
			{
				reserveTeam.Add(person);
			}
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
			sb.AppendLine($"First team has {FirstTeam.Count} players.");
			sb.AppendLine($"Reserve team has {ReserveTeam.Count} players.");
			return sb.ToString();
        }

    }
}

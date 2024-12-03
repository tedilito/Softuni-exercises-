using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public Dictionary<string, string> RepairsByHours { get;  }
        public int HoursWorked { get;  }
    }
}

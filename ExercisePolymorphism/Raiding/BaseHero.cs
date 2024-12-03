using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public abstract class BaseHero
    {

		private string name;
		private int power;

        protected BaseHero(string name)
        {
            Name = name;
        }

        public int Power
		{
			get { return power; }
			set { power = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string CastAbility()
		{
			return " ";
		}
		

	}
}

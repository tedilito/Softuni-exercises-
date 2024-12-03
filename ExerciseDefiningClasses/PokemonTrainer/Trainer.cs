using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
		private string  name;
		private int numberOfBadged = 0;
		private List<Pokemon> pokemons = new List<Pokemon>();

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
			set { pokemons = value; }
		}

		public int NumberOfBadged
		{
			get { return numberOfBadged; }
			set { numberOfBadged = value; }
		}

		public string  Name
		{
			get { return name; }
			set { name = value; }
		}

        public Trainer(string name)
        {
				this.name = name;
			
        }


    }
}

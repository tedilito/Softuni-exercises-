using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double stats;

        private int endurance;
        private int dribble;
        private int sprint;
        private int passing;
        private int shooting;

        public Player(string playerName, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = playerName;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;

            this.Stats = (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        }

        private int Shooting
        {
            get { return shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Shooting should be between 0 and 100.");
                }

                shooting = value;

            }
        }


        private int Passing
        {
            get { return passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Passing should be between 0 and 100.");
                }
                passing = value;
            }
        }

        private int Dribble
        {
            get { return dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Dribble should be between 0 and 100.");
                }
                dribble = value;
            }
        }
        private int Sprint
        {
            get { return sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }


        private int Endurance
        {
            get { return endurance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Endurance should be between 0 and 100.");
                }
                endurance = value;
            }
        }




        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;

            }
        }
        public double Stats
        {
            get { return stats; }
            private set { stats = value; }
        }

    }
}

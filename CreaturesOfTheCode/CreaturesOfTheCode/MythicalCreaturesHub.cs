using System.Text;

namespace CreaturesOfTheCode
{
    public class MythicalCreaturesHub
    {
        public MythicalCreaturesHub(int capacity)
        {
            Capacity = capacity;
            Creatures = new List<Creature>();
        }

        public List<Creature> Creatures { get; set; }
        public int Capacity { get; set; }


        public void AddCreature(Creature creature)
        {
            if (Creatures.Count < Capacity  && !Creatures.Any(x => x.Name.ToLower() == creature.Name.ToLower()))
            {
                Creatures.Add(creature);
            }
        }
        public bool RemoveCreature(string name)
        {
            return Creatures.Remove(Creatures.Where(x => x.Name == name).FirstOrDefault());
        }

        public Creature GetStrongestCreature()
        {
            return Creatures.OrderByDescending(x => x.Health).FirstOrDefault();
        }

        public string Details(string creatureName)
        {
            if (Creatures.Any(x => x.Name == creatureName))
            {
                return Creatures.Where(x => x.Name == creatureName).FirstOrDefault().ToString();
            }
            return $"Creature with the name {creatureName} not found.";
        }

        public string GetAllCreatures()
        {
            StringBuilder sb =  new StringBuilder();
            sb.AppendLine("Mythical Creatures:");
            foreach (Creature creature in Creatures.OrderBy(x => x.Name))
            {
                sb.AppendLine($"{creature.Name} -> {creature.Kind}");
            }
            return sb.ToString().Trim();
        }
    }
}

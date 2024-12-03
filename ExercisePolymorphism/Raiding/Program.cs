namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            List<BaseHero> raidGroup = new List<BaseHero>();
            while(raidGroup.Count != n)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                if (heroType == "Druid")
                {
                    BaseHero baseHero = new Druid(heroName);
                    raidGroup.Add(baseHero);
                   
                }
                else if (heroType == "Paladin")
                {
                    BaseHero baseHero = new Paladin(heroName);
                    raidGroup.Add(baseHero);
                }
                else if (heroType == "Rogue")
                {
                    BaseHero baseHero = new Rogue(heroName);
                    raidGroup.Add(baseHero);
                }
                else if (heroType == "Warrior")
                {
                    BaseHero baseHero = new Warrior(heroName);
                    raidGroup.Add(baseHero);


                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

            }
            int bossPower = int.Parse(Console.ReadLine());
            foreach (var item in raidGroup)
            {

                Console.WriteLine(item.CastAbility()); 
            }
            if (raidGroup.Sum(x => x.Power) >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}

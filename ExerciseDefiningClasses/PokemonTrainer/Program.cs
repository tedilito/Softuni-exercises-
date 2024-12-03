namespace PokemonTrainer
{
    public class program
    {
        public static void Main()
        {
            string input;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();   
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Pokemon currentPoke = new Pokemon(info[1], info[2], int.Parse(info[3]));
                if (trainers.ContainsKey(info[0]))
                {
                    trainers[info[0]].Pokemons.Add(currentPoke);
                }
                else
                {
                    Trainer trainer = new Trainer(info[0]);
                    trainers.Add(info[0], trainer);
                    trainers[info[0]].Pokemons.Add(currentPoke);
                }

            }

            while ((input = Console.ReadLine()) != "End")
            {

                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Exists(x => x.Element == input))
                    {
                        trainer.NumberOfBadged++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons  )
                        {
                            pokemon.Health -= 10;
                         
                        }
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

            }

            foreach (var trainer in trainers.Values.OrderByDescending(x => x.NumberOfBadged))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadged} {trainer.Pokemons.Count}");
            }

        }
    }
}
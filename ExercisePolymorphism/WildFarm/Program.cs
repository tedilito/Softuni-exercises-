using System.Net;
using WildFarm.Animals;
using WildFarm.FoodClasses;

namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal currentAnimal = null;
            Food food = null;

            List<Animal> Anals = new List<Animal>();
            string commans;
            int i = 0;
            while ((commans = Console.ReadLine()) != "End")
            {
                string[] tokens = commans.Split();
            
              
                if (i % 2 == 0)
                {
                    string name = tokens[1];
                    double weight = double.Parse(tokens[2]);
                    switch (tokens[0])
                    {
                        case "Owl":
                            currentAnimal = new Owl(name, weight, double.Parse(tokens[3]));

                            break;
                        case "Hen":
                            currentAnimal = new Hen(name, weight, double.Parse(tokens[3]));

                            break;
                        case "Mouse":
                            currentAnimal = new Mouse(name, weight, tokens[3]);

                            break;
                        case "Dog":
                            currentAnimal = new Dog(name, weight, tokens[3]);

                            break;
                        case "Cat":
                            currentAnimal = new Cat(name, weight, tokens[3], tokens[4]);

                            break;
                        case "Tiger":
                            currentAnimal = new Tiger(name, weight, tokens[3], tokens[4]);

                            break;
                    }
                    Anals.Add(currentAnimal);
                }
                else
                {
                    Console.WriteLine(currentAnimal.ProduceSoung());
                    switch (tokens[0])
                    {
                        case "Vegetable":
                            food = new Vegetable(int.Parse(tokens[1]));
                            break;
                        case "Fruit":
                            food = new Fruit(int.Parse(tokens[1]));
                            break;
                        case "Meat":
                            food = new Meat(int.Parse(tokens[1]));
                            break;
                        case "Seeds":
                            food = new Seeds(int.Parse(tokens[1]));
                            break;
                    }

                    if (currentAnimal.GetType().Name == "Mouse" && food.GetType().Name != "Vegetable" 
                        && food.GetType().Name != "Fruit")
                    {
                        Console.WriteLine($"{currentAnimal.GetType().Name} does not eat {food.GetType().Name}!");
                    }
                    else if (currentAnimal.GetType().Name == "Cat" && food.GetType().Name != "Vegetable"
                        && food.GetType().Name != "Meat")
                    {
                        Console.WriteLine($"{currentAnimal.GetType().Name} does not eat {food.GetType().Name}!");
                    }
                    else if ((currentAnimal.GetType().Name == "Tiger" || currentAnimal.GetType().Name == "Dog" || currentAnimal.GetType().Name == "Owl") && food.GetType().Name != "Meat")

                    {
                        Console.WriteLine($"{currentAnimal.GetType().Name} does not eat {food.GetType().Name}!");
                    }
                    else
                    {
                        currentAnimal.Eat(int.Parse(tokens[1]));
                    }
                   
                    
                }

             
                i++;
            }


            Anals.ForEach(x => Console.WriteLine(x.ToString()));
        }


    }
}

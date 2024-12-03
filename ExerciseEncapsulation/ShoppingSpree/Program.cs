
using System;

namespace ShoppingSpree;
internal class Program
{
    public static void Main(string[] args)
    {
        Dictionary<Person, List<Product>> dic = new Dictionary<Person, List<Product>>();
        List<Person> persons = new List<Person>();
        string[] personsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
        string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
        bool hasToEnd = false;
        List<Product> list = new List<Product>();

        try
        {
            foreach (var item in personsInfo)
            {
                string[] currentPerson = item.Split("=");
                Person person = new Person(currentPerson[0], int.Parse(currentPerson[1]));
                persons.Add(person);
            }

            foreach (var product in products)
            {
                string[] currentProduct = product.Split("=");
                Product prod = new Product(currentProduct[0], int.Parse(currentProduct[1]));
                list.Add(prod);
            }
        }
        catch (Exception ex)
        {
            hasToEnd = true;
            Console.WriteLine(ex.Message);
        }

        string commands;
        while ((commands = Console.ReadLine()) != "END" && !hasToEnd)
        {
            string[] personAndProduct = commands.Split();
            var person = persons.FirstOrDefault(x => x.Name == personAndProduct[0]);
            var product = list.FirstOrDefault(x => x.Name == personAndProduct[1]);

            
            if (person == null || product == null)
            {
                Console.WriteLine("Person or product not found.");
                continue;
            }


            if (person.Money >= product.Cost)
            {
                person.Money -= product.Cost;

                if (!dic.ContainsKey(person))
                {
                    dic[person] = new List<Product>();
                }

                dic[person].Add(product);
                Console.WriteLine($"{person.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{person.Name} can't afford {product.Name}");
            }
        }

        if (!hasToEnd)
        {
            foreach (var person in persons)
            {
                if (dic.ContainsKey(person) && dic[person].Count > 0)
                {
                    string productsBought = string.Join(", ", dic[person].Select(p => p.Name));
                    Console.WriteLine($"{person.Name} - {productsBought}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }

            }
        }
    }
}
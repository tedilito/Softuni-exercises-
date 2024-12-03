using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> guests = Console.ReadLine().Split().ToList();

        string command;
        while ((command = Console.ReadLine()) != "Party!")
        {
            string[] tokens = command.Split();
            string action = tokens[0];
            string condition = tokens[1];
            string parameter = tokens[2];

            if (action == "Remove")
            {
                if (condition == "StartsWith")
                {
                    guests.RemoveAll(name => name.StartsWith(parameter));
                }
                else if (condition == "EndsWith")
                {
                    guests.RemoveAll(name => name.EndsWith(parameter));
                }
                else if (condition == "Length")
                {
                    guests.RemoveAll(name => name.Length == int.Parse(parameter));
                }
            }
            else if (action == "Double")
            {
                List<string> guestsToDouble = new List<string>();

                if (condition == "StartsWith")
                {
                    guestsToDouble = guests.Where(name => name.StartsWith(parameter)).ToList();
                }
                else if (condition == "EndsWith")
                {
                    guestsToDouble = guests.Where(name => name.EndsWith(parameter)).ToList();
                }
                else if (condition == "Length")
                {
                    guestsToDouble = guests.Where(name => name.Length == int.Parse(parameter)).ToList();
                }

                foreach (var guest in guestsToDouble)
                {
                    int index = guests.IndexOf(guest);
                    guests.Insert(index + 1, guest);
                }
            }
        }

        if (guests.Count > 0)
        {
            Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}

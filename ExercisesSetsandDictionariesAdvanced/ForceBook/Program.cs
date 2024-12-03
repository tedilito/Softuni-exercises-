using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> sideUsers = new Dictionary<string, List<string>>();

        string input;
        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            if (input.Contains(" | "))
            {
                var parts = input.Split(" | ");
                string forceSide = parts[0];
                string forceUser = parts[1];

                if (!sideUsers.ContainsKey(forceSide))
                {
                    sideUsers[forceSide] = new List<string>();
                }

                if (!sideUsers.Values.Any(list => list.Contains(forceUser)))
                {
                    sideUsers[forceSide].Add(forceUser);
                }
            }
            else if (input.Contains(" -> "))
            {
                var parts = input.Split(" -> ");
                string forceUser = parts[0];
                string forceSide = parts[1];

                foreach (var side in sideUsers)
                {
                    if (side.Value.Contains(forceUser))
                    {
                        side.Value.Remove(forceUser);
                        break;
                    }
                }

                if (!sideUsers.ContainsKey(forceSide))
                {
                    sideUsers[forceSide] = new List<string>();
                }

                sideUsers[forceSide].Add(forceUser);
                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }
        }

        foreach (var side in sideUsers.OrderByDescending(x => x.Value.Count).ThenBy(s => s.Key))
        {
            if (side.Value.Count > 0)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}

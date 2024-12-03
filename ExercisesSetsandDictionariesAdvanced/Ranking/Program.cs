using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contests = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, int>> usersAndContests = new Dictionary<string, Dictionary<string, int>>();
        string input;

        while ((input = Console.ReadLine()) != "end of contests")
        {
            string[] commands = input.Split(':');
            string contestName = commands[0];
            string contestPass = commands[1];

            if (!contests.ContainsKey(contestName))
            {
                contests.Add(contestName, contestPass);
            }
        }

        while ((input = Console.ReadLine()) != "end of submissions")
        {
            string[] commands = input.Split("=>");
            string contestName = commands[0];
            string contestPass = commands[1];
            string user = commands[2];
            int points = int.Parse(commands[3]);

            if (contests.ContainsKey(contestName) && contests[contestName] == contestPass)
            {
                if (!usersAndContests.ContainsKey(user))
                {
                    usersAndContests[user] = new Dictionary<string, int>();
                }

                if (!usersAndContests[user].ContainsKey(contestName))
                {
                    usersAndContests[user].Add(contestName, points);
                }
                else
                {
                    if (usersAndContests[user][contestName] < points)
                    {
                        usersAndContests[user][contestName] = points;
                    }
                }
            }
        }

        var usersTotalPoints = usersAndContests
            .ToDictionary(user => user.Key, user => user.Value.Values.Sum());

        var bestUser = usersTotalPoints
            .OrderByDescending(user => user.Value)
            .First();

        Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value} points.");
        Console.WriteLine("Ranking:");

        foreach (var (user, contestsParticipated) in usersAndContests.OrderBy(x => x.Key))
        {
            Console.WriteLine(user);
            foreach (var item in contestsParticipated.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {item.Key} -> {item.Value}");
            }
        }
    }
}

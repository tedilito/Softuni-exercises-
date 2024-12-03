using System.ComponentModel.Design;

Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
Dictionary<string, int> count = new Dictionary<string, int>();


string input;
while ((input = Console.ReadLine()) != "exam finished")
{
    string[] commands = input.Split('-');
    string userName = commands[0];
    string banOrLanguage = commands[1];

    if (banOrLanguage == "banned")
    {

        if (users.ContainsKey(userName))
        {
            users.Remove(userName);
        }


    }
    else if (!users.ContainsKey(userName))
    {

        int points = int.Parse(commands[2]);
        users.Add(userName, new Dictionary<string, int>());
        users[userName].Add(banOrLanguage, points);
        if (!count.ContainsKey(banOrLanguage))
        {
            count.Add(banOrLanguage, 1);
        }
        else
        {
            count[banOrLanguage]++;
        }
    }
    else if (!users[userName].ContainsKey(banOrLanguage))
    {
        int points = int.Parse(commands[2]);
        users[userName].Add(banOrLanguage, points);
        if (!count.ContainsKey(banOrLanguage))
        {
            count.Add(banOrLanguage, 1);
        }
        else
        {
            count[banOrLanguage]++;
        }
    }
    else
    {
        int points = int.Parse(commands[2]);
        if (points > users[userName][banOrLanguage])
        {
            users[userName][banOrLanguage] = points;
        }

        if (!count.ContainsKey(banOrLanguage))
        {
            count.Add(banOrLanguage, 1);
        }
        else
        {
            count[banOrLanguage]++;
        }
    }

}


Console.WriteLine("Results:");
foreach (var user in users.OrderByDescending(x => x.Value.Values.Max()).ThenBy(x => x.Key))
{
    
    foreach (var contest in user.Value.OrderByDescending(c => c.Value))
    {
        Console.WriteLine($"{user.Key} | {contest.Value}");
    }
}

Console.WriteLine("Submissions:");
foreach (var item in count.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
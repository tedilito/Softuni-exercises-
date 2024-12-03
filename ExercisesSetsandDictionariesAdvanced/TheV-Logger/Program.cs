Dictionary<string, HashSet<string>> vlogersFollowed = new Dictionary<string, HashSet<string>>(); //sledva
Dictionary<string, HashSet<string>> vlogersFollowing = new Dictionary<string, HashSet<string>>(); //sledvat go

string input;
while ((input = Console.ReadLine()) != "Statistics")
{
    string[] commands = input.Split();
    string command = commands[1];
    if (command == "joined")
    {
        string user = commands[0];
        if (!vlogersFollowed.ContainsKey(user) && !vlogersFollowing.ContainsKey(user))
        {
            vlogersFollowed.Add(user, new HashSet<string>());
            vlogersFollowing.Add(user, new HashSet<string>());
        }
    }
    else
    {
        string followingVloger = commands[0]; //sledva
        string followedVloger = commands[2];  //sledvat go

        if (followingVloger != followedVloger && !vlogersFollowed[followingVloger].Contains(followedVloger)
            && vlogersFollowed.ContainsKey(followingVloger) && vlogersFollowed.ContainsKey(followedVloger))
        {
            vlogersFollowed[followingVloger].Add(followedVloger);
            vlogersFollowed[followedVloger].Add(followingVloger);
        }


    }
}
Console.WriteLine($"The V-Logger has a total of {vlogersFollowed.Count} vloggers in its logs.");


var sortedVloggers = vlogersFollowed
    .OrderByDescending(v => vlogersFollowing[v.Key].Count)  // Order by followers count (descending)
    .ThenBy(v => vlogersFollowed[v.Key].Count)              // Then by number they follow (ascending)
    .ThenBy(v => v.Key);                                     // Then by name lexicographically

var mostFamous = sortedVloggers.First();
Console.WriteLine($"1. {mostFamous.Key} : {vlogersFollowing[mostFamous.Key].Count} followers, {vlogersFollowed[mostFamous.Key].Count} following");

if (vlogersFollowing[mostFamous.Key].Count > 0)
{
    foreach (var follower in vlogersFollowing[mostFamous.Key].OrderBy(f => f))
    {
        Console.WriteLine($"*  {follower}");
    }
}


int rank = 2;
foreach (var vlogger in sortedVloggers.Skip(1))
{
    Console.WriteLine($"{rank++}. {vlogger.Key} : {vlogersFollowing[vlogger.Key].Count} followers, {vlogersFollowed[vlogger.Key].Count} following");
}
    

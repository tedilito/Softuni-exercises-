
string input;

Dictionary<string, HashSet<string>> vlogersFollowers = new Dictionary<string, HashSet<string>>();
Dictionary<string, HashSet<string>> vlogersFollowed = new Dictionary<string, HashSet<string>>();
while ((input = Console.ReadLine()) != "Statistics")
{
    string[] commands = input.Split();
    if (commands[1] == "joined")
    {
        string vloger = commands[0];
       
            
           
        
    }
    else
    {
        string vlogerFollow = commands[0];
        string vlogerFollowed = commands[2];
       
    }
}

List<string> invitations = Console.ReadLine().Split().ToList();
List<string> filters = new List<string>();

string command;
while ((command = Console.ReadLine()) != "Print")
{
    var parts = command.Split(';');
    string action = parts[0];
    string filterType = parts[1];
    string filterParameter = parts[2];

    if (action == "Add filter")
    {
        filters.Add($"{filterType};{filterParameter}");
    }
    else if (action == "Remove filter")
    {
        filters.Remove($"{filterType};{filterParameter}");
    }
}

foreach (var filter in filters)
{
    var parts = filter.Split(';');
    string filterType = parts[0];
    string filterParameter = parts[1];

    if (filterType == "Starts with")
    {
        invitations = invitations.Where(name => !name.StartsWith(filterParameter)).ToList();
    }
    else if (filterType == "Ends with")
    {
        invitations = invitations.Where(name => !name.EndsWith(filterParameter)).ToList();
    }
    else if (filterType == "Length")
    {
        invitations = invitations.Where(name => name.Length != int.Parse(filterParameter)).ToList();
    }
    else if (filterType == "Contains")
    {
        invitations = invitations.Where(name => !name.Contains(filterParameter)).ToList();
    }
}

Console.WriteLine(string.Join(" ", invitations));